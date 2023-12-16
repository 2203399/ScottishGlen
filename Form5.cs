using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            string selectedAsset = softwareAsset_ComboBox.SelectedItem.ToString();
            softwareName_TextBox.Text = selectedAsset;
            
            string query = "SELECT version FROM SoftwareAssets WHERE name = '" + selectedAsset + "'";
            string version = getSingleItemFromDatabase(query, connectionString);
            softwareVersion_TextBox.Text = version.ToString();

            string licenseQuery = "SELECT license_info FROM SoftwareAssets WHERE name = '" + selectedAsset + "'";
            string license = getSingleItemFromDatabase(licenseQuery, connectionString);
            softwareLicenseInfo_TextBox.Text = license.ToString();

            string purchaseQuery = "SELECT purchase_date FROM SoftwareAssets WHERE name = '" + selectedAsset + "'";
            string purchaseDate = getSingleItemFromDatabase(purchaseQuery, connectionString);
            softwarePurchaseDate_TextBox.Text = purchaseDate.ToString();

            string addNotesQuery = "SELECT COALESCE(additional_notes, '') FROM SoftwareAssets WHERE name = '" + selectedAsset + "'";
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
            string selectedAsset = hardwareAsset_ComboBox.SelectedItem.ToString();
            hardwareName_TextBox.Text = selectedAsset;

            string modelQuery = "SELECT model FROM HardwareAssets";
            string model = getSingleItemFromDatabase(modelQuery, connectionString);
            hardwareModel_TextBox.Text = model.ToString();

            string manufacturerQuery = "SELECT manufacturer FROM HardwareAssets";
            string manufacturer = getSingleItemFromDatabase(manufacturerQuery, connectionString);
            hardwareManufacturer_TextBox.Text = manufacturer.ToString();

            string typeQuery = "SELECT type FROM HardwareAssets";
            string type = getSingleItemFromDatabase(typeQuery, connectionString);
            hardwareType_TextBox.Text = type.ToString();

            string ipQuery = "SELECT ip_address FROM HardwareAssets";
            string ip = getSingleItemFromDatabase(ipQuery, connectionString);
            hardwareIpAddress_TextBox.Text = ip.ToString();

            string purchaseQuery = "SELECT purchase_date FROM HardwareAssets";
            string purchase = getSingleItemFromDatabase(purchaseQuery, connectionString);
            hardwarePurchaseDate_TextBox.Text = purchase.ToString();

            string addQuery = "SELECT additional_notes FROM HardwareAssets";
            string addNotes = getSingleItemFromDatabase(addQuery, connectionString);
            hardwareAddNotes_TextBox.Text = addNotes.ToString();
        }
    }
}
