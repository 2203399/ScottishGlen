﻿using System;
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
        private readonly Form3 Form3;
        
        public Form2()
        {
            InitializeComponent();
            Form3 = new Form3();
        }

        private void display_Btn_Click(object sender, EventArgs e)
        {
            this.Close();
            Form3.Show();
        }
    }
}
