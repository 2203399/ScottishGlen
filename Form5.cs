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
    public partial class Form5 : Form
    {
        public string connectionString = "server=lochnagar.abertay.ac.uk;uid=sql2203399;pwd=oJ8HnTiBzB68;database=sql2203399;"
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void hsAsset_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (hsAsset_ComboBox.SelectedIndex == 0)
            {

            }

            else if (hsAsset_ComboBox.SelectedIndex == 1)
            {

            }
        }
    }
}
