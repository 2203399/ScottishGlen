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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            
        }

        private void display_Btn_Click(object sender, EventArgs e)
        {
           
            this.Hide();
            Form3 form3= new Form3();
            form3.ShowDialog();
            form3.Show();
        }

        private void add_Btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 form4 = new Form4();
            form4.ShowDialog();
            form4.Show();
        }

        private void delete_Btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("To be implemented in part 3");
        }

        private void edit_Btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("To be implemented in part 3");
        }

        private void logout_Btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
