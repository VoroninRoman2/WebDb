using Newtonsoft.Json;
using System.Data;
using System.IO;
using System.Windows.Forms;
using WebDbClient.ServerConnection;
using WebDbLib;

namespace WebDbClient.DAO
{
    internal class FreeRoomDAO : IDAO<FreeRoom>
    {
        public void DeleteById(int id)
        {
            string comm = $"Delete From FreeRoom Where id ={id}";
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
            string comm = $"Select FreeRoom.id, Hotel.Name, FreeRoom.RoomNumber, FreeRoom.Price From FreeRoom Inner Join Hote On FreeRoom.HotelId=Area.Id";
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

        public FreeRoom GetbyId(int id)
        {
            string comm = $"Select FreeRoom.id, Hotel.Name, FreeRoom.RoomNumber, FreeRoom.Price From FreeRoom Inner Join Hote On FreeRoom.HotelId=Area.Id Where FreeRoom.id = {id}";
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
                    return (FreeRoom)JsonConvert.DeserializeObject(line, typeof(FreeRoom));
            }
        }

        public void Insert(FreeRoom obj)
        {
            string comm = $"Insert Into FreeRoom (HotelId, RoomNumber,Price) Values ({obj.HotelId},{obj.RoomNumber},{obj.Price})";
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

        public void Update(FreeRoom obj)
        {
            string comm = $"Update FreeRoom Set HotelId= '{obj.HotelId}', RoomNumber= '{obj.RoomNumber}' ,Price= '{obj.Price}' Where id ={obj.Id}";
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
