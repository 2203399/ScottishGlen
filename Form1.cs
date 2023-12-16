using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private static string GetIP()
        {
            IPHostEntry host;
            string localIP = "";
            host = Dns.GetHostEntry(Dns.GetHostName());

            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily.ToString() == "InterNetwork")
                {
                    localIP = ip.ToString();
                }
            }
            return localIP;
        }

       

        private void login_Btn_Click(object sender, EventArgs e)
        {
            if(string.Equals(username_TxtBox.Text, "username") && string.Equals(password_TxtBox.Text, "password")) {


                string ipAddress = GetIP();
                string machineName = Environment.MachineName; // reference https://learn.microsoft.com/en-us/dotnet/api/system.environment.machinename?view=net-8.0#system-environment-machinename
                string osVersion = Environment.OSVersion.ToString();
                string processorCount = Environment.ProcessorCount.ToString();

                string filePath = "output.txt"; // Specify the path of the output file

                try
                {
                    using (StreamWriter writer = new StreamWriter(filePath))
                    {
                        writer.WriteLine("IP Address: " + ipAddress);
                        writer.WriteLine("Machine Name: " + machineName);
                        writer.WriteLine("OS Version: " + osVersion);
                        writer.WriteLine("Processor Count: " + processorCount);
                    }

                    MessageBox.Show("Information written to the file successfully.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error writing to the file: " + ex.Message);
                }




                this.Hide();
                Form2 form2 = new Form2();
                form2.ShowDialog();
                form2.Show();
               
            }
             
            else
            {
                MessageBox.Show("Inavalid login");
                username_TxtBox.Text = "";
                password_TxtBox.Text= "";
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void password_TxtBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
