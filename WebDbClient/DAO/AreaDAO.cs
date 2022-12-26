using Newtonsoft.Json;
using System;
using System.Data;
using System.IO;
using System.Windows.Forms;
using WebDbClient.ServerConnection;
using WebDbLib;

namespace WebDbClient.DAO
{
    internal class AreaDAO : IDAO<Area>
    {
        public void DeleteById(int id)
        {
            string comm = $"Delete From Area Where id ={id}";
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
            string comm = $"Select * From Area";
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

        public Area GetbyId(int id)
        {
            string comm = $"Select * From Area Where id={id}";
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
                    return (Area)JsonConvert.DeserializeObject(line, typeof(Area));
            }
        }

        public void Insert(Area obj)
        {
            string comm = $"Insert Into Area (Type) Values ({obj.Name})";
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

        public void Update(Area obj)
        {
            string comm = $"Update Area Set Name= '{obj.Name}' Where id ={obj.Id}";
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
