using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void select_Asset_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(select_Asset_ComboBox.SelectedIndex == 0)
            {
                hardware_Panel.Visible = true;
                software_Panel.Visible = false;
            }

            else if (select_Asset_ComboBox.SelectedIndex == 1 )
            {
                software_Panel.Visible = true;
                hardware_Panel.Visible = false;
            }
        }

        private void Form4_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
