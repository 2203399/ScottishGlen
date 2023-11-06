using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class Form4 : Form
    {
        public string connectionString = "server=lochnagar.abertay.ac.uk;uid=sql2203399;pwd=oJ8HnTiBzB68;database=sql2203399;";
        public Form4()
        {
            InitializeComponent();
           
            string query = "SELECT employee_id FROM Employees";
            
            using(MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                using(MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader()) { 
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                string item = reader.GetString(0);
                                employee_Id_ComboBox.Items.Add(item);
                                semployee_Id_ComboBox.Items.Add(item);
                            }
                        }
                    }
                    
                }
            }
        }

        private void back_Button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.ShowDialog();
            form2.Show();
        }

        private void select_Asset_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(select_Asset_ComboBox.SelectedIndex == 0)
            {
                hardware_Panel.Visible = true;
                software_Panel.Visible = false;
                monthCalendar1.Visible = true;
                monthCalendar2.Visible = false;
            }

            else if (select_Asset_ComboBox.SelectedIndex == 1 )
            {
                software_Panel.Visible = true;
                hardware_Panel.Visible = false;
                monthCalendar1.Visible = false;
                monthCalendar2.Visible = true;
            }
        }

        private void Form4_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            DateTime selectedDate = e.Start;
            purchase_Date_TxtBox.Text = selectedDate.ToString("yyyy-MM-dd");
        }

        private void monthCalendar2_DateChanged(object sender, DateRangeEventArgs e)
        {
            DateTime selectedDate = e.Start;
            spurchase_Date_TxtBox.Text = selectedDate.ToString("yyyy-MM-dd");
        }

        private void add_HAsset_Button_Click(object sender, EventArgs e)   
        {
            

            if (string.IsNullOrEmpty(hname_TxtBox.Text) && string.IsNullOrEmpty(hmodel_TxtBox.Text) && string.IsNullOrEmpty(hmanufacturer_TxtBox.Text) && string.IsNullOrEmpty(htype_TxtBox.Text) && string.IsNullOrEmpty(ip_Address_TxtBox.Text) && string.IsNullOrEmpty(purchase_Date_TxtBox.Text))
            {
                MessageBox.Show("Please make sure all fields have been filled out");
            }

            else if (employee_Id_ComboBox.SelectedIndex != -1)
            {
                
                
                string query = "INSERT INTO HardwareAssets (name, model, manufacturer, type, ip_address, purchase_date, additional_notes, employee_id) VALUES (@Value1, @Value2, @Value3, @Value4, @Value5, @Value6, @Value7, @Value8)";
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        string a = employee_Id_ComboBox.SelectedItem.ToString();
                        int b = int.Parse(a);
                        command.Parameters.AddWithValue("@Value1", hname_TxtBox.Text);
                        command.Parameters.AddWithValue("@Value2", hmodel_TxtBox.Text);
                        command.Parameters.AddWithValue("@Value3", hmanufacturer_TxtBox.Text);
                        command.Parameters.AddWithValue("@Value4", htype_TxtBox.Text);
                        command.Parameters.AddWithValue("@Value5", ip_Address_TxtBox.Text);
                        command.Parameters.AddWithValue("@Value6", purchase_Date_TxtBox.Text);
                        command.Parameters.AddWithValue("@Value7", additional_Notes_TxtBox.Text);
                        command.Parameters.AddWithValue("@Value8", b);
                   

                        try
                        {
                            command.ExecuteNonQuery();
                            Console.WriteLine("Data added to the database successfully.");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Error: " + ex.Message);
                        }
                    }
                }
            }

            else
            {
                MessageBox.Show("Ran into an issue");
            }
            
            
        }

        private void add_SAsset_Button_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(sname_TxtBox.Text) && string.IsNullOrEmpty(sversion_Txtbox.Text) && string.IsNullOrEmpty(license_Info_TxtBox.Text) && string.IsNullOrEmpty(spurchase_Date_TxtBox.Text))
            {
                MessageBox.Show("Please make sure all fields have been filled out");
            }

            if (semployee_Id_ComboBox.SelectedIndex != -1)
            {
                
                string query = "INSERT INTO SoftwareAssets (name, version, license_info, purchase_date, additional_notes, employee_id) VALUES (@Value1, @Value2, @Value3, @Value4, @Value5, @Value6)";
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        string c = semployee_Id_ComboBox.SelectedItem.ToString();
                        int bd = int.Parse(c);

                        command.Parameters.AddWithValue("@Value1", sname_TxtBox.Text);
                        command.Parameters.AddWithValue("@Value2", sversion_Txtbox.Text);
                        command.Parameters.AddWithValue("@Value3", license_Info_TxtBox.Text);
                        command.Parameters.AddWithValue("@Value4", spurchase_Date_TxtBox.Text);
                        command.Parameters.AddWithValue("@Value5", sadditional_Notes_TxtBox.Text);
                        command.Parameters.AddWithValue("@Value6", c);
                    }
                }
            }
        }

    
    }
}
