using Newtonsoft.Json;
using System.Data;
using System.IO;
using System.Windows.Forms;
using WebDbClient.ServerConnection;
using WebDbLib;

namespace WebDbClient.DAO
{
    internal class HotelTypeDAO : IDAO<HotelType>
    {
        public void DeleteById(int id)
        {
            string comm = $"Delete From HotelType Where id ={id}";
            using (StreamWriter writer = new StreamWriter(Connection.Client.GetStream()))
            {
                writer.WriteLine(comm);
            }
            using (StreamReader reader = new StreamReader(Connection.Client.GetStream()))
            {
                string line = reader.ReadLine();
                if(line=="0") MessageBox.Show("Entry does not exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public DataTable GetAll()
        {
            string comm = $"Select * From HotelType";
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

        public HotelType GetbyId(int id)
        {
            string comm = $"Select * From HotelType Where id={id}";
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
                    return (HotelType)JsonConvert.DeserializeObject(line, typeof(HotelType));
            }
        }

        public void Insert(HotelType obj)
        {
            string comm = $"Insert Into HotelType (Type) Values ({obj.Type})";
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

        public void Update(HotelType obj)
        {
            string comm = $"Update HotelType Set Type= '{obj.Type}' Where id ={obj.Id}";
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
