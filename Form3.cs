
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        private string connectionString = "server=lochnagar.abertay.ac.uk;uid=sql2203399;pwd=oJ8HnTiBzB68;database=sql2203399;";
        public string combinedValue;
        public Form3()
        {
            InitializeComponent();
        }

       

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
               nist_Button.Visible = false;
               nist_ListBox.Visible = false;
                // Create a new MySqlConnection
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    try
                    {
                        // Open the connection
                        connection.Open();

                        // Perform a SELECT query to retrieve the data
                        string query = "SELECT * FROM HardwareAssets";
                        MySqlCommand command = new MySqlCommand(query, connection);
                        MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                        DataTable dataTable = new DataTable();


                        // Fill the DataTable with the query results
                        adapter.Fill(dataTable);


                        dataGridView1.DataSource = dataTable;

                        this.Controls.Add(dataGridView1);

                        // Close the connection
                        connection.Close();
                    }
                    catch (MySqlException ex)
                    {
                        // Handle any exceptions that occur during the connection process
                        Console.WriteLine("Error: " + ex.Message);
                    }
                }
            }

            else if (comboBox1.SelectedIndex == 1)
            {
                nist_Button.Visible = true;
                nist_ListBox.Visible = true;
                // Create a new MySqlConnection
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    try
                    {
                        // Open the connection
                        connection.Open();

                        // Perform a SELECT query to retrieve the data
                        string query = "SELECT * FROM SoftwareAssets";
                        MySqlCommand command = new MySqlCommand(query, connection);
                        MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                        DataTable dataTable = new DataTable();

                        // Fill the DataTable with the query results
                        adapter.Fill(dataTable);


                        dataGridView1.DataSource = dataTable;

                        this.Controls.Add(dataGridView1);

                        StringBuilder combinedValues = new StringBuilder();

                        foreach (DataRow row in dataTable.Rows)
                        {
                            object column1Value = row[1]; 
                            object column2Value = row[2]; 

                            combinedValue = $"{column1Value} {column2Value}"; // Combine values into a single string
                            combinedValues.AppendLine(combinedValue);
                            
                        }


                        // Close the connection
                        connection.Close();
                    }
                    catch (MySqlException ex)
                    {
                        // Handle any exceptions that occur during the connection process
                        Console.WriteLine("Error: " + ex.Message);
                    }
                }
            }
        }
        private void return_To_Main_View_Button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.ShowDialog();
            form2.Show();

        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void back_Button_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.ShowDialog();
            form2.Show();
        }

        private async void nist_Button_Click(object sender, EventArgs e)
        {
            string keyword = combinedValue;

            // Clear the existing vulnerabilities
            nist_ListBox.Items.Clear();

            // Create an instance of HttpClient
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    
                    HttpResponseMessage response = await client.GetAsync($"https://services.nvd.nist.gov/rest/json/cves/2.0?keywordSearch={keyword}");

                    // Check if the request was successful
                    if (response.IsSuccessStatusCode)
                    {
                        string responseContent = await response.Content.ReadAsStringAsync();
                        var jsonData = JsonDocument.Parse(responseContent);
                        // Get the array of vulnerabilities from the JSON response
                        JsonElement vulnerabilitiesArray = jsonData.RootElement.GetProperty("result").GetProperty("CVE_Items");
                        // Loop through each vulnerability and add it to the ListBox
                        foreach (JsonElement vulnerabilityElement in vulnerabilitiesArray.EnumerateArray())
                        {
                            // Extract the vulnerability information from the JSON
                            string id = vulnerabilityElement.GetProperty("cve").GetProperty("CVE_data_meta").GetProperty("ID").GetString();
                            string description = vulnerabilityElement.GetProperty("cve").GetProperty("description").GetProperty("description_data")[0].GetProperty("value").GetString();

                            // Combine the ID and description into a single string
                            string vulnerabilityString = $"{id}: {description}";

                            // Add the vulnerability string to the ListBox
                            nist_ListBox.Items.Add(vulnerabilityString);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error: Failed to retrieve vulnerabilities.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
        }
    }
    }

