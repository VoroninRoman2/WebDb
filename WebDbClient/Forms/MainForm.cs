using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.OracleClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using WebDbClient.DAO;
using WebDbClient.ServerConnection;

namespace WebDbClient.Forms
{
    public partial class MainForm : Form
    {
        bool Admin;
        bool UpdateHotels;
        bool UpdateRooms;

        public MainForm(bool admin)
        {
            Admin= admin;
            UpdateHotels = false;
            UpdateRooms = false;
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            GetMessages();
            string comm = $"Select Hotel.id, Hotel.Name, Area.Name, HotelType.Type From Hotel Inner Join Area On Hotel.AreaId=Area.Id Inner Join HotelType On Hotel.TypeId=HotelType.Id";
            NoAnswerQueri(comm, "Hotel");
            comm = $"Select * From HotelType";
            NoAnswerQueri(comm, "HotelType");
            comm = $"Select FreeRoom.id, Hotel.Name, FreeRoom.RoomNumber, FreeRoom.Price From FreeRoom Inner Join Hotel On FreeRoom.HotelId=Hotel.Id";
            NoAnswerQueri(comm, "FreeRoom");
            comm = $"Select * From Area";
            NoAnswerQueri(comm, "Area");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string comm = $"Select Hotel.id, Hotel.Name, Area.Name, HotelType.Type From Hotel Inner Join Area On Hotel.AreaId=Area.Id Inner Join HotelType On Hotel.TypeId=HotelType.Id";
            NoAnswerQueri(comm, "Hotel");
            comm = $"Select * From HotelType";
            NoAnswerQueri(comm, "HotelType");
            comm = $"Select FreeRoom.id, Hotel.Name, FreeRoom.RoomNumber, FreeRoom.Price From FreeRoom Inner Join Hotel On FreeRoom.HotelId=Hotel.Id Where FreeRoom.RoomNumber>0";
            NoAnswerQueri(comm, "FreeRoom");
            comm = $"Select * From Area";
            NoAnswerQueri(comm, "Area");

        }

        public static void NoAnswerQueri(string queri, string tableName)
        {
            queri = tableName + ":" + queri;
            var sw = new StreamWriter(Connection.Client.GetStream());
            sw.AutoFlush = true;
            sw.WriteLine(queri);

        }
        public async void GetMessages()
        {
            await Task.Factory.StartNew(() =>
            {
                var sr = new StreamReader(Connection.Client.GetStream());
                var sw = new StreamWriter(Connection.Client.GetStream());
                while (true)
                {

                    try
                    {
                        if (Connection.Client.Connected)
                        {
                            var line = sr.ReadLine();
                            if(line!=null)
                            {
                                if(line =="locked")
                                {
                                    MessageBox.Show("Table locked \n try again later", "Warnind", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    continue;
                                }                                
                                var Data = sr.ReadLine();
                                switch (line)
                                {
                                    case ("Hotel"):
                                        DataTable HotelTable = (DataTable)JsonConvert.DeserializeObject(Data, typeof(DataTable)); ;
                                        hotelGridView.Invoke((MethodInvoker)delegate
                                        {
                                            hotelGridView.DataSource = HotelTable;
                                        });
                                        hotelComboBox.Invoke((MethodInvoker)delegate
                                        {
                                            hotelComboBox.DataSource = HotelTable;
                                            hotelComboBox.DisplayMember = "Name";
                                            hotelComboBox.ValueMember = "Id";
                                        });
                                        hotelIndexComboBox.Invoke((MethodInvoker)delegate
                                        {
                                            hotelIndexComboBox.DataSource = HotelTable;
                                            hotelIndexComboBox.DisplayMember = "Name";
                                            hotelIndexComboBox.ValueMember = "Id";
                                        });
                                        break;
                                    case ("HotelType"):
                                        DataTable HotelTypeTable = (DataTable)JsonConvert.DeserializeObject(Data, typeof(DataTable)); ;
                                        hotelTypeGridView.Invoke((MethodInvoker)delegate
                                        {
                                            hotelTypeGridView.DataSource = HotelTypeTable;
                                        });
                                        hotelTypeComboBox.Invoke((MethodInvoker)delegate
                                        {
                                            hotelTypeComboBox.DataSource = HotelTypeTable;
                                            hotelTypeComboBox.DisplayMember= "Type";
                                            hotelTypeComboBox.ValueMember= "Id";
                                        });
                                        hotelTypesDeleteComboBox.Invoke((MethodInvoker)delegate
                                        {
                                            hotelTypesDeleteComboBox.DataSource = HotelTypeTable;
                                            hotelTypesDeleteComboBox.DisplayMember = "Type";
                                            hotelTypesDeleteComboBox.ValueMember = "Id";
                                        });
                                        break;
                                    case ("FreeRoom"):
                                        DataTable FreeRoomTable = (DataTable)JsonConvert.DeserializeObject(Data, typeof(DataTable)); ;
                                        freeRoomGridView.Invoke((MethodInvoker)delegate
                                        {
                                            freeRoomGridView.DataSource = FreeRoomTable;
                                        });
                                        roomComboBox.Invoke((MethodInvoker)delegate
                                        {
                                            roomComboBox.DataSource = FreeRoomTable;
                                            roomComboBox.DisplayMember = "Id";
                                            roomComboBox.ValueMember = "Id";
                                        });
                                        break;
                                    case ("Area"):
                                        DataTable Area = (DataTable)JsonConvert.DeserializeObject(Data, typeof(DataTable)); ;
                                        areaGridView.Invoke((MethodInvoker)delegate
                                        {
                                            areaGridView.DataSource = Area;
                                        });
                                        areaComboBox.Invoke((MethodInvoker)delegate
                                        {
                                            areaComboBox.DataSource = Area;
                                            areaComboBox.DisplayMember = "Name";
                                            areaComboBox.ValueMember = "Id";
                                        });
                                        areaDeleteCombobox.Invoke((MethodInvoker)delegate
                                        {
                                            areaDeleteCombobox.DataSource = Area;
                                            areaDeleteCombobox.DisplayMember = "Name";
                                            areaDeleteCombobox.ValueMember = "Id";
                                        });
                                        break;
                                    default:
                                        break;
                                }

                            }
                        }
                        else
                        {
                            Connection.Client.Close();
                            Console.WriteLine("Error");
                            break;
                        }
                        Task.Delay(50).Wait();
                    }
                    catch (Exception e) { }
                }
            });
        }

        private void hotelsGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void areaInsertButton_Click(object sender, EventArgs e)
        {
            var sw = new StreamWriter(Connection.Client.GetStream());
            if(areaInsertTextBox.Text.Length > 0)
            {
                string comm = $"Insert Into Area (Name) Values ('{areaInsertTextBox.Text}')";
                NoAnswerQueri(comm,"Area");
            }
            else
            {
                MessageBox.Show("Input the name", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void hotelTypeInsertButton_Click(object sender, EventArgs e)
        {
            var sw = new StreamWriter(Connection.Client.GetStream());
            if (hotelTypeInserttextBox.Text.Length > 0)
            {
                string comm = $"Insert Into HotelType (Type) Values ('{hotelTypeInserttextBox.Text}')";
                NoAnswerQueri(comm, "HotelType");
            }
            else
            {
                MessageBox.Show("Input the name", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void hotelInsertButton_Click(object sender, EventArgs e)
        {
            string queri;
            if (UpdateHotels)
            {
                queri = $"Update Hotel Set Name= '{hotelInsertTextBox.Text}', AreaId= '{areaComboBox.SelectedValue}' ,TypeId= '{hotelTypeComboBox.SelectedValue}' Where id ={hotelIndexComboBox.SelectedValue}";
                
            }
            else
            {
                queri = $"Insert Into Hotel (Name, AreaId,TypeId) Values ('{hotelInsertTextBox.Text}','{areaComboBox.SelectedValue}','{hotelTypeComboBox.SelectedValue}')";
            }
            if (hotelInsertTextBox.Text!="")
            {
                NoAnswerQueri(queri, "Hotel");
            }
            else
            {
                MessageBox.Show("Wrong input", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if(UpdateHotels)
            {
                UpdateHotels = false;
                updateHotelButton.Text = "Update";
                hotelInsertTextBox.Text = "";
                areaComboBox.SelectedValue = 1;
                hotelTypeComboBox.SelectedValue = 1;
            }
        }

        private void insertRoomButton_Click(object sender, EventArgs e)
        {
            string queri;
            if (UpdateRooms)
            {
                queri = $"Update FreeRoom Set HotelId= '{hotelComboBox.SelectedValue}', RoomNumber= '{roomNumberTextBox.Text}' ,Price= '{roomPriceTextBox.Text}' Where id ={roomComboBox.SelectedValue}";
            }
            else
            {
                queri = $"Insert Into FreeRoom (HotelId, RoomNumber,Price) Values ('{hotelComboBox.SelectedValue}','{roomNumberTextBox.Text}',{roomPriceTextBox.Text})";
            }
            if (roomNumberTextBox.Text != ""&& roomPriceTextBox.Text != "")
            { 
                NoAnswerQueri(queri, "FreeRoom");
            }
            else
            {
                MessageBox.Show("Wrong input", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (UpdateRooms)
            {
                UpdateRooms = false;
                roomUpdateButton.Text = "Update";
                roomNumberTextBox.Text = "";
                insertRoomButton.Text = "Insert";
                roomPriceTextBox.Text = "";
                hotelComboBox.SelectedValue = 1;
            }
        }

        private void deleteHotelButton_Click(object sender, EventArgs e)
        {

            
            
        }

        private void roomDeleteButton_Click(object sender, EventArgs e)
        {
            string queri = $"Delete From FreeRoom Where id ='{hotelIndexComboBox.SelectedValue}'";
            NoAnswerQueri(queri, "FreeRoom");

        }

        private void deleteHotelButton_Click_1(object sender, EventArgs e)
        {
            string queri = $"Delete From Hotel Where id ='{hotelIndexComboBox.SelectedValue}'";
            NoAnswerQueri(queri, "Hotel");
        }

        private void hotelTypesDeleteButton_Click(object sender, EventArgs e)
        {
            string queri = $"Delete From HotelType Where id ='{hotelTypesDeleteComboBox.SelectedValue}'";
            NoAnswerQueri(queri, "HotelType");
        }

        private void areaDeleteButton_Click(object sender, EventArgs e)
        {
             string queri = $"Delete From Area Where id ='{areaDeleteCombobox.SelectedValue}'";
            NoAnswerQueri(queri, "Area");
        }

        private void updateHotelButton_Click(object sender, EventArgs e)
        {
            if(UpdateHotels)
            {
                UpdateHotels = false;
                updateHotelButton.Text = "Update";
                insertRoomButton.Text = "Insert";
                hotelInsertTextBox.Text = "";
                areaComboBox.SelectedValue = 1;
                hotelTypeComboBox.SelectedValue = 1;
            }
            else
            {
                UpdateHotels = true;
                updateHotelButton.Text = "Stop";
                insertRoomButton.Text = "Update";
                DataGridViewRow row = null;
                foreach (DataGridViewRow row1 in hotelGridView.Rows)
                {
                    string line = row1.Cells["id"].Value.ToString();
                    if (row1.Cells["id"].Value.ToString() == hotelIndexComboBox.SelectedValue.ToString())
                    {
                        row = row1;
                        break;
                    }
                }

                hotelInsertTextBox.Text = row.Cells["Name"].Value.ToString();
                areaComboBox.SelectedIndex = areaComboBox.FindStringExact(row.Cells["Name1"].Value.ToString());
                hotelTypeComboBox.SelectedIndex = hotelTypeComboBox.FindStringExact(row.Cells["Type"].Value.ToString());
            }
        }

        private void roomUpdateButton_Click(object sender, EventArgs e)
        {
            if (UpdateRooms)
            {
                UpdateRooms = false;
                roomUpdateButton.Text = "Update";
                roomNumberTextBox.Text = "";
                insertRoomButton.Text = "Insert";
                roomPriceTextBox.Text = "";
                hotelComboBox.SelectedValue = 1;
            }
            else
            {
                UpdateRooms = true;
                roomUpdateButton.Text = "Stop";
                insertRoomButton.Text = "Update";
                DataGridViewRow row = null;
                foreach (DataGridViewRow row1 in freeRoomGridView.Rows)
                {
                    string line = row1.Cells["id"].Value.ToString();
                    if (row1.Cells["id"].Value.ToString() == roomComboBox.SelectedValue.ToString())
                    {
                        row = row1;
                        break;
                    }
                }
                roomNumberTextBox.Text = row.Cells["RoomNumber"].Value.ToString();
                roomPriceTextBox.Text = row.Cells["Price"].Value.ToString();
                hotelComboBox.SelectedIndex = hotelComboBox.FindStringExact(row.Cells["Name"].Value.ToString());
            }
        }
    }
}
