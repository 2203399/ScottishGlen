
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        private string connectionString = "server=lochnagar.abertay.ac.uk;uid=sql2203399;pwd=oJ8HnTiBzB68;database=sql2203399;";
        public Form3()
        {
            InitializeComponent();
        }

       

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
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
    }
}
