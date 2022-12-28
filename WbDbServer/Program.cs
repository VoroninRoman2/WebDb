using Newtonsoft.Json;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using WbDbServer.DA;

namespace WbDbServer
{
    class Program
    {
        public static bool CheckPassword(string password)
        {
            Regex regex = new Regex(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9])(?=.*[^a-zA-Z0-9])\S{1,16}$");
            return regex.IsMatch(password);
        }
        const string ip = "127.0.0.1";
        // const string ip = "192.168.88.247";

        static TcpListener listener = new TcpListener(IPAddress.Parse(ip), 5050);
        static List<TcpClient> Clients = new List<TcpClient>();
        static void Main(string[] args)
        {

            listener.Start();

            while (true)
            {
                var client = listener.AcceptTcpClient();
                Clients.Add(client);
                Task.Factory.StartNew(() =>
                {

                    StreamReader sr = new StreamReader(client.GetStream());
                    StreamWriter sw = new StreamWriter(client.GetStream());
                    sw.AutoFlush = true;

                    string Login;

                    //Client authentication
                    while (client.Connected)
                    {
                        var line = sr.ReadLine();

                        Console.WriteLine(line);
                        if (line.Contains("Connect"))
                        {
                            string[] str = line.Split(':');
                             Login = str[1];
                            DataTable table = DAO.GetData($"Select * From Account Where Login='{str[1]}'");
                            DataRow row;
                            if(table.Rows.Count>0)
                                row= table.Rows[0];
                            else
                            {
                                Console.WriteLine("Wrong login " + Login);
                                sw.WriteLine("Wrong login");
                                client.Client.Disconnect(false);
                                break;
                            }
                            if (row[1].ToString() == str[2])
                            {
                                Console.WriteLine("Succes " + Login);
                                if (row[2].ToString() == "1") sw.WriteLine("admin");
                                else sw.WriteLine("user");
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Wrong password "+ Login);
                                sw.WriteLine("Wrong password");
                                client.Client.Disconnect(false);
                                break;
                            }
                        }
                        else if(line.Contains("Register"))
                        {
                            string[] str = line.Split(':');
                            Login = str[1];
                            if(str.Length==4)
                            {
                                string queri = $"Insert Into Account (Login, Password, Admin) Values ('{str[1]}','{str[2]}', '{str[3]}')";
                                Exception e = DAO.NoAnswerQueri(queri);
                                if(e!= null)
                                {
                                    Console.WriteLine(e.Message+" " + Login);
                                    sw.WriteLine(e.Message);
                                    client.Client.Disconnect(false);
                                    break;
                                }

                                Console.WriteLine("Succes " + Login);
                                if (str[3].ToString() == "1") sw.WriteLine("admin");
                                else sw.WriteLine("user");
                                break;

                            }
                            else
                            {
                                Console.WriteLine("Wrong password number of attributes" + Login);
                                sw.WriteLine("Wrong password number of attributes");
                                client.Client.Disconnect(false);
                                break;
                            }
                        }

                    }

                    while (client.Connected)
                    {

                        string[] line = sr.ReadLine().Split(':');
                        if (line[1].Contains("Select"))
                        {
                            DataTable t = DAO.GetData(line[1]);
                            string str = JsonConvert.SerializeObject(t);
                            sw.WriteLine(line[0]);
                            sw.WriteLine(str);
                        }
                        else 
                        {
                            DAO.NoAnswerQueri(line[1]);
                            UpdateTable(line[0]);
                        }




                    }

                });
            }
        }

        public static void UpdateTable(string tableName)
        {
            string queri="";
            switch (tableName)
            {
                case ("Hotel"):
                   queri= $"Select Hotel.id, Hotel.Name, Area.Name, HotelType.Type From Hotel Inner Join Area On Hotel.AreaId=Area.Id Inner Join HotelType On Hotel.TypeId=HotelType.Id ";
                    UpdateTable("FreeRoom");
                    break;
                case ("HotelType"):
                  queri= $"Select * From HotelType";
                    UpdateTable("Hotel");
                    break;
                case ("FreeRoom"):
                  queri= $"Select FreeRoom.id, Hotel.Name, FreeRoom.RoomNumber, FreeRoom.Price From FreeRoom Inner Join Hotel On FreeRoom.HotelId=Hotel.Id Where FreeRoom.RoomNumber>0";
                    break;
                case ("Area"):
                  queri= $"Select * From Area";
                    UpdateTable("Hotel");
                    break;
            }

            DataTable t = DAO.GetData(queri);
            string str = JsonConvert.SerializeObject(t);
            foreach (var item in Clients)
            {
                StreamWriter swt = new StreamWriter(item.GetStream());
                swt.AutoFlush= true;
                swt.WriteLine(tableName);
                swt.WriteLine(str);
            }
           
        }
    }
}
