using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using Org.BouncyCastle.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WindowsFormsApp1
{
    public partial class Form6 : Form
    {
        public string connectionString = "server=lochnagar.abertay.ac.uk;uid=sql2203399;pwd=oJ8HnTiBzB68;database=sql2203399;";
        public string selectedHItem, selectedSItem;
        public Form6()
        {
            InitializeComponent();
        }

        private void HS_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (HS_ComboBox.SelectedIndex == 0)
            {
                software_ComboBox.Visible = false;
                HS_ComboBox.Visible = false;
                hardware_ComboBox.Visible = true;
                string query = "SELECT name FROM HardwareAssets";

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    string item = reader.GetString(0);
                                    hardware_ComboBox.Items.Add(item);
                                }
                            }
                        }

                    }
                }
            }

            else if (HS_ComboBox.SelectedIndex == 1)
            {
                software_ComboBox.Visible = true;
                HS_ComboBox.Visible = false;
                hardware_ComboBox.Visible = false;
                string query = "SELECT name FROM SoftwareAssets";

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    string item = reader.GetString(0);
                                    software_ComboBox.Items.Add(item);
                                }
                            }
                        }

                    }
                }
            }
        }

        private void hardware_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedHItem = hardware_ComboBox.SelectedItem.ToString();
            string query = "SELECT * FROM HardwareAssets WHERE name = '" + selectedHItem + "'";
        }

        private void software_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedSItem = software_ComboBox.SelectedItem.ToString();
            string query = "SELECT * FROM SoftwareAssets WHERE name = '" + selectedSItem + "'";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        // Use StringBuilder to store the output
                        StringBuilder output = new StringBuilder();
                        // Process the retrieved values
                        while (reader.Read())
                        {
                            // Iterate through each column in the record
                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                string columnName = reader.GetName(i);
                                object columnValue = reader.GetValue(i);
                                // Do something with the column name and value, such as outputting them
                                output.AppendLine($"Column Name: {columnName}, Value: {columnValue}");
                            }
                        }
                        printItem_Label.Text = output.ToString();
                        reader.Close();
                    }

                }
            }
        }

        private void delete_Button_Click(object sender, EventArgs e)
        {
            if (software_ComboBox.Visible == true) {
                string query = "DELETE FROM SoftwareAssets WHERE name = @selectedSItem";
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@selectedSItem", selectedSItem);
                        try
                        {
                            connection.Open();
                            int rowsAffected = command.ExecuteNonQuery();
                            MessageBox.Show("Data deleted successfully. Rows affected: " + rowsAffected);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex.Message);
                        }
                    }
                }
            }

            else if (hardware_ComboBox.Visible == true)
            {
                string query = "DELETE FROM HardwareAssets WHERE name = @selectedSItem";
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@selectedSItem", selectedHItem);
                        try
                        {
                            connection.Open();
                            int rowsAffected = command.ExecuteNonQuery();
                            MessageBox.Show("Data deleted successfully. Rows affected: " + rowsAffected);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex.Message);
                        }
                    }
                }
            }
        }

        private void Form6_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
