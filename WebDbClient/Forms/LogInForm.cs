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
using WebDbClient.Forms;
using WebDbClient.ServerConnection;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WebDbClient
{
    public partial class LogInForm : Form
    {
        const string ip = "127.0.0.1";
        // const string ip = "192.168.88.247";
        const int port = 5050;
        bool Admin;

        public LogInForm()
        {
            InitializeComponent();
        }

        private void logInButton_Click(object sender, EventArgs e)
        {
            if (loginBox.Text != "" && passwordBox.Text != "")
            {
                if (Connect("Connect:"+ loginBox.Text+":"+ passwordBox.Text))
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
                   Admin= true;
                    return true;
                }
                else if(str == "user")
                { 
                    Admin= false;
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
            catch
            {
                return false;
            }


        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterForm Rf= new RegisterForm();            
            Rf.Show();
            this.Hide();
        }
    }
}
