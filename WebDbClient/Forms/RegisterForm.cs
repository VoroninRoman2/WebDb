using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebDbClient.ServerConnection;

namespace WebDbClient.Forms
{
    public partial class RegisterForm : Form
    {
        const string ip = "127.0.0.1";
        // const string ip = "192.168.88.247";
        const int port = 5050;
        bool Admin;


        public RegisterForm()
        {
            InitializeComponent();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            if (loginBox.Text != "" && passwordBox.Text != ""&&(adminRadioButton.Checked||userRadioButton.Checked))
            {
                string admin="0";
                if (adminRadioButton.Checked) admin = "1";
                if (Connect("Register:" + loginBox.Text + ":" + passwordBox.Text+":"+admin))
                {
                    MainForm Mf = new MainForm(Admin);
                    Mf.Show();
                    this.Hide();
                }
            }
        }
        private bool Connect(string msg)
        {
            try
            {
                Connection.Initialize(ip, port);
                var sr = new StreamReader(Connection.Client.GetStream());
                var sw = new StreamWriter(Connection.Client.GetStream());
                sw.AutoFlush = true;

                sw.WriteLine(msg);

                var str = sr.ReadLine();
                if (str == "admin")
                {
                    Admin = true;
                    return true;
                }
                else if (str == "user")
                {
                    Admin = false;
                    return true;
                }
                else
                {
                    label1.Text = str;
                    label1.Show();
                    Connection.Client.Close();
                    return false;
                }

            }
            catch (Exception e)
            {
                return false;
            }


        }
    }
}
