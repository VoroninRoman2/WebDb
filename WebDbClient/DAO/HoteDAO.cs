using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebDbClient.ServerConnection;
using WebDbLib;

namespace WebDbClient.DAO
{
    internal class HoteDAO : IDAO<Hotel>
    {
        public void DeleteById(int id)
        {
            string comm = $"Delete From Hotel Where id ={id}";
            using (StreamWriter writer = new StreamWriter(Connection.Client.GetStream()))
            {
                writer.WriteLine(comm);
            }
            using (StreamReader reader = new StreamReader(Connection.Client.GetStream()))
            {
                string line = reader.ReadLine();
                if (line == "0") MessageBox.Show("Entry does not exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public DataTable GetAll()
        {
            string comm = $"Select Hotel.id, Hotel.Name, Area.Name, HotelType.Type From Hotel Inner Join Area On Hotel.AreaId=Area.Id Inner Join HotelType On Hotel.AreaId=HotelType.Id ";
            using (StreamWriter writer = new StreamWriter(Connection.Client.GetStream()))
            {
                writer.WriteLine(comm);
            }
            using (StreamReader reader = new StreamReader(Connection.Client.GetStream()))
            {
                string line = reader.ReadLine();
                if (line == "0")
                {
                    MessageBox.Show("Faild to get", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return new DataTable();
                }
                else
                    return (DataTable)JsonConvert.DeserializeObject(line, typeof(DataTable));
            }
        }

        public Hotel GetbyId(int id)
        {
            string comm = $"Select Hotel.id, Hotel.Name, Area.Name, HotelType.Type From Hotel Inner Join Area On Hotel.AreaId=Area.Id Inner Join HotelType On Hotel.AreaId=HotelType.Id Where Hotel.id =1";
            using (StreamWriter writer = new StreamWriter(Connection.Client.GetStream()))
            {
                writer.WriteLine(comm);
            }
            using (StreamReader reader = new StreamReader(Connection.Client.GetStream()))
            {
                string line = reader.ReadLine();
                if (line == "0")
                {
                    MessageBox.Show("Faild to get", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
                else
                    return (Hotel)JsonConvert.DeserializeObject(line, typeof(Hotel));
            }
        }

        public void Insert(Hotel obj)
        {
            string comm = $"Insert Into Hotel (Name, AreaId,TypeId) Values ({obj.Name},{obj.AreaId},{obj.TypeId})";
            using (StreamWriter writer = new StreamWriter(Connection.Client.GetStream()))
            {
                writer.WriteLine(comm);
            }
            using (StreamReader reader = new StreamReader(Connection.Client.GetStream()))
            {
                string line = reader.ReadLine();
                if (line == "0") MessageBox.Show("Faild to insert", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Update(Hotel obj)
        {
            string comm = $"Update Hotel Set Name= '{obj.Name}', AreaId= '{obj.AreaId}' ,TypeId= '{obj.TypeId}' Where id ={obj.Id}";
            using (StreamWriter writer = new StreamWriter(Connection.Client.GetStream()))
            {
                writer.WriteLine(comm);
            }
            using (StreamReader reader = new StreamReader(Connection.Client.GetStream()))
            {
                string line = reader.ReadLine();
                if (line == "0") MessageBox.Show("Faild to update", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else if (line == "lock") MessageBox.Show("Table locked \n try again later", "Warnind", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
