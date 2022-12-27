using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WbDbServer.DA;

namespace WbDbServer
{
    class Program
    {
        const string ip = "127.0.0.1";
        // const string ip = "192.168.88.247";

        static TcpListener listener = new TcpListener(IPAddress.Parse(ip), 5050);
        static List<TcpListener> Clients = new List<TcpListener>();
        static void Main(string[] args)
        {

            listener.Start();

            while (true)
            {
                var client = listener.AcceptTcpClient();
                Task.Factory.StartNew(() =>
                {

                    StreamReader sr = new StreamReader(client.GetStream());
                    StreamWriter sw = new StreamWriter(client.GetStream());
                    sw.AutoFlush = true;


                    //Client authentication
                    while (client.Connected)
                    {
                        var line = sr.ReadLine();

                        Console.WriteLine(line);
                        if (line.Contains("Connect"))
                        {
                            string[] str = line.Split(':');
                            DataRow row = DAO.DAO.GetbyId($"");
                            if ()
                        }
                    }

                });
            }
        }
    }
}
