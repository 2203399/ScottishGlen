using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

       

        private void login_Btn_Click(object sender, EventArgs e)
        {
            if(string.Equals(username_TxtBox.Text, "username") && string.Equals(password_TxtBox.Text, "password")) {

                this.Hide();
                Form2 form2 = new Form2();
                form2.ShowDialog();
                form2.Show();
               
            }
             
            else
            {
                MessageBox.Show("Inavalid login");
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
