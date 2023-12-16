using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form5 : Form
    {
        public string connectionString = "server=lochnagar.abertay.ac.uk;uid=sql2203399;pwd=oJ8HnTiBzB68;database=sql2203399;";
        public string selectedHAsset, selectedSAsset;
        private bool fieldChange = false;
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            

        }

        private void textChanged(object sender, EventArgs e)
        {
            fieldChange = true;
            edit_Button.Enabled = true;
        }

        public string getSingleItemFromDatabase(string query, string connectionString)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            reader.Read();
                            string item = reader.GetString(0);
                            return item;
                        }
                    }
                }
            }

            return null;
        }

        private void hsAsset_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (hsAsset_ComboBox.SelectedIndex == 0)
            {
                hsAsset_ComboBox.Visible = false;
                hardwareCalendar.Visible = true;
                hardwareAsset_ComboBox.Visible = true;
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
                                    hardwareAsset_ComboBox.Items.Add(item);
                                }
                            }
                        }

                    }
                }
            }

            else if (hsAsset_ComboBox.SelectedIndex == 1)
            {
                hsAsset_ComboBox.Visible = false;
                softwareCalendar.Visible = true;
                softwareAsset_ComboBox.Visible = true;
                editSoftwarePanel.Visible = true;
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
                                    softwareAsset_ComboBox.Items.Add(item);
                                }
                            }
                        }

                    }
                }

            }
        }



        private void softwareCalendar_DateSelected(object sender, DateRangeEventArgs e)
        {
            DateTime selectedDate = e.Start;
            softwarePurchaseDate_TextBox.Text = selectedDate.ToString("yyyy-MM-dd");
        }

        private void hardwareCalendar_DateSelected(object sender, DateRangeEventArgs e)
        {
            DateTime selectedDate = e.Start;
            hardwarePurchaseDate_TextBox.Text = selectedDate.ToString("yyyy-MM-dd");
        }

        private void softwareAsset_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedSAsset = softwareAsset_ComboBox.SelectedItem.ToString();
            softwareName_TextBox.Text = selectedSAsset;
            
            string query = "SELECT version FROM SoftwareAssets WHERE name = '" + selectedSAsset + "'";
            string version = getSingleItemFromDatabase(query, connectionString);
            softwareVersion_TextBox.Text = version.ToString();

            string licenseQuery = "SELECT license_info FROM SoftwareAssets WHERE name = '" + selectedSAsset + "'";
            string license = getSingleItemFromDatabase(licenseQuery, connectionString);
            softwareLicenseInfo_TextBox.Text = license.ToString();

            string purchaseQuery = "SELECT DATE_FORMAT(purchase_date, '%Y-%m-%d') AS formattedDate FROM SoftwareAssets WHERE name = '" + selectedSAsset + "'";
            string purchaseDate = getSingleItemFromDatabase(purchaseQuery, connectionString);
            softwarePurchaseDate_TextBox.Text = purchaseDate.ToString();

            string addNotesQuery = "SELECT COALESCE(additional_notes, '') FROM SoftwareAssets WHERE name = '" + selectedSAsset + "'";
            string addNotes = getSingleItemFromDatabase(addNotesQuery, connectionString);
            softwareAddNotes_TextBox.Text = addNotes.ToString();
           

            softwareName_TextBox.TextChanged += textChanged;
            softwareVersion_TextBox.TextChanged += textChanged;
            softwareLicenseInfo_TextBox.TextChanged += textChanged;
            softwarePurchaseDate_TextBox.TextChanged += textChanged;
            softwareAddNotes_TextBox.TextChanged += textChanged;

        }

        private void hardwareAsset_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedHAsset = hardwareAsset_ComboBox.SelectedItem.ToString();
            hardwareName_TextBox.Text = selectedHAsset;

            string modelQuery = "SELECT model FROM HardwareAssets WHERE name = '" + selectedHAsset + "'";
            string model = getSingleItemFromDatabase(modelQuery, connectionString);
            hardwareModel_TextBox.Text = model.ToString();

            string manufacturerQuery = "SELECT manufacturer FROM HardwareAssets WHERE name = '" + selectedHAsset + "'";
            string manufacturer = getSingleItemFromDatabase(manufacturerQuery, connectionString);
            hardwareManufacturer_TextBox.Text = manufacturer.ToString();

            string typeQuery = "SELECT type FROM HardwareAssets WHERE name = '" + selectedHAsset + "'";
            string type = getSingleItemFromDatabase(typeQuery, connectionString);
            hardwareType_TextBox.Text = type.ToString();

            string ipQuery = "SELECT ip_address FROM HardwareAssets WHERE name = '" + selectedHAsset + "'";
            string ip = getSingleItemFromDatabase(ipQuery, connectionString);
            hardwareIpAddress_TextBox.Text = ip.ToString();

            string purchaseQuery = "SELECT DATE_FORMAT(purchase_date, '%Y-%m-%d') AS formattedDate FROM HardwareAssets WHERE name = '" + selectedHAsset + "'";
            string purchase = getSingleItemFromDatabase(purchaseQuery, connectionString);
            hardwarePurchaseDate_TextBox.Text = purchase.ToString();

            string addQuery = "SELECT COALESCE(additional_notes, '') FROM HardwareAssets WHERE name = '" + selectedHAsset + "'";
            string addNotes = getSingleItemFromDatabase(addQuery, connectionString);
            hardwareAddNotes_TextBox.Text = addNotes.ToString();

            hardwareName_TextBox.TextChanged += textChanged;
            hardwareModel_TextBox.TextChanged += textChanged;
            hardwareManufacturer_TextBox.TextChanged += textChanged;
            hardwareType_TextBox.TextChanged += textChanged;
            hardwareIpAddress_TextBox.TextChanged += textChanged;
            hardwarePurchaseDate_TextBox.TextChanged += textChanged;
            hardwareAddNotes_TextBox.TextChanged += textChanged;
        }

        private void edit_Button_Click(object sender, EventArgs e)
        {
            if (edit_Button.Enabled == false)
            {
                MessageBox.Show("No data has been edited");
            }

            else
            {
                if (editSoftwarePanel.Visible == true)
                {
                    string name = softwareName_TextBox.Text;
                    string version = softwareVersion_TextBox.Text;
                    string license = softwareLicenseInfo_TextBox.Text;
                    string purchaseDate = softwarePurchaseDate_TextBox.Text;
                    string notes = softwareAddNotes_TextBox.Text;

                    string query = "UPDATE SoftwareAssets SET name = @name, version = @version, license_info = @license, purhcase_date = @purchaseDate, additional_notes = @notes WHERE name = '" + selectedSAsset + "'";
                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        using (MySqlCommand command = new MySqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@name", name);
                            command.Parameters.AddWithValue("@version", version);
                            command.Parameters.AddWithValue("@license", license);
                            command.Parameters.AddWithValue("@purchaseDate", purchaseDate);
                            command.Parameters.AddWithValue("@notes", notes);
                        }
                    }
                }

                else if (editHardwarePanel.Visible == true) {
                    string name = hardwareName_TextBox.Text;
                    string model = hardwareModel_TextBox.Text;
                    string manufacturer = hardwareManufacturer_TextBox.Text;
                    string type = hardwareType_TextBox.Text;
                    string ip = hardwareIpAddress_TextBox.Text;
                    string purchaseDate = hardwarePurchaseDate_TextBox.Text;
                    string notes = hardwareAddNotes_TextBox.Text;

                    string query = "UPDATE HardwareAssets SET mame = @name, model = @model, manufacturer = @manufacturer, type = @type, ip_address = @ip, purchase_date = @purchaseDate, additional_notes = @notes WHERE name = '" + selectedHAsset + "'";
                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        using (MySqlCommand command = new MySqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@name", name);
                            command.Parameters.AddWithValue("@model", model);
                            command.Parameters.AddWithValue("@manufacturer", manufacturer);
                            command.Parameters.AddWithValue("@type", type);
                            command.Parameters.AddWithValue("@ip", ip);
                            command.Parameters.AddWithValue("@purchaseDate", purchaseDate);
                            command.Parameters.AddWithValue("@notes", notes);
                        }
                    }
                }
            }
        }
    }
}
