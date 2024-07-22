using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace LibrarySystem
{
    public partial class logscreen : Form
    {
        private MySqlConnection connection;

        public logscreen()
        {
            InitializeComponent();
            InitializeDatabaseConnection();
            LoadLogData();
        }

        private void InitializeDatabaseConnection()
        {
            string server = "localhost";
            string database = "librarymanagement";
            string username = "root";
            string password = "";
            string connectionString = $"Server={server};Database={database};Uid={username};Pwd={password};";

            try
            {
                connection = new MySqlConnection(connectionString);
                connection.Open();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Database error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show($"Connection error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unexpected error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadLogData()
        {
            string logQuery = "SELECT Action, ActionDateTime FROM log ORDER BY ActionDateTime";
            MySqlCommand logCmd = new MySqlCommand(logQuery, connection);

            try
            {
                using (MySqlDataReader logReader = logCmd.ExecuteReader())
                {
                    var logEntries = new Dictionary<DateTime, List<string>>();

                    while (logReader.Read())
                    {
                        string action = logReader["Action"].ToString();
                        DateTime actionDateTime = (DateTime)logReader["ActionDateTime"];
                        DateTime actionDate = actionDateTime.Date; // Get only the date part

                        if (!logEntries.ContainsKey(actionDate))
                        {
                            logEntries[actionDate] = new List<string>();
                        }

                        logEntries[actionDate].Add($"{actionDateTime:HH:mm:ss} - {action}");
                    }

                    DisplayLogData(logEntries);
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Database error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unexpected error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DisplayLogData(Dictionary<DateTime, List<string>> logEntries)
        {
            listBox1.Items.Clear();

            foreach (var entry in logEntries.OrderBy(e => e.Key))
            {
                listBox1.Items.Add($"Date: {entry.Key:yyyy-MM-dd}");
                foreach (var log in entry.Value)
                {
                    listBox1.Items.Add($"    {log}");
                }
            }
        }
    }
}
