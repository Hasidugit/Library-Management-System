using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace LibrarySystem
{
    public partial class memeberscreen : Form
    {
        private MySqlConnection connection;
        private DataTable dt;
        private DataTable dt2; // DataTable for issuedbooks

        public memeberscreen()
        {
            InitializeComponent();
            InitializeDatabaseConnection();

            // Initialize DataTables
            dt = new DataTable();
            dt2 = new DataTable(); // Initialize dt2
            griddataveiw.DataSource = dt;
            dataGridView1.DataSource = dt2;

            // Attach TextChanged event handler to txtsearch
            txtsearch.TextChanged += Txtsearch_TextChanged;

            // Set up autocomplete
            txtsearch.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtsearch.AutoCompleteSource = AutoCompleteSource.CustomSource;

            // Attach SelectionChanged event handler to griddataveiw
            griddataveiw.SelectionChanged += Griddataveiw_SelectionChanged;

            startpicture();
            datagrideveiw1show(); // Populate griddataveiw initially
        }

        private void Txtsearch_TextChanged(object sender, EventArgs e)
        {
            search();
        }

        private void startpicture()
        {
            try
            {
                pictureBox1.Image = Image.FromFile("C:\\Users\\Hasidu\\Downloads\\p.png");
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading picture: {ex.Message}");
            }
        }

        private void search()
        {
            string searchText = txtsearch.Text.Trim();

            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }

                string query = "SELECT * FROM members WHERE MemberId LIKE @search OR LastName LIKE @search OR FirstName LIKE @search OR Address LIKE @search OR Email LIKE @search OR Phone LIKE @search";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@search", $"%{searchText}%");

                // Clear previous data from DataTable dt
                dt.Clear();

                // Fill the DataTable dt with new search results
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                {
                    adapter.Fill(dt);
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"MySQL error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unexpected error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
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

        private void Griddataveiw_SelectionChanged(object sender, EventArgs e)
        {
            // When a row is selected in griddataveiw, update details and show issued books for the member
            if (griddataveiw.SelectedRows.Count > 0 && !griddataveiw.CurrentRow.IsNewRow)
            {
                DataGridViewRow selectedRow = griddataveiw.SelectedRows[0];

                // Populate text fields with data from selected row
                txtfistname.Text = selectedRow.Cells["FirstName"].Value?.ToString();
                txtlastname.Text = selectedRow.Cells["LastName"].Value?.ToString();
                txtaddress.Text = selectedRow.Cells["Address"].Value?.ToString();
                txtemail.Text = selectedRow.Cells["Email"].Value?.ToString();
                txtphone.Text = selectedRow.Cells["Phone"].Value?.ToString();
                txtimage.Text = selectedRow.Cells["imgurl"].Value?.ToString();

                if (selectedRow.Cells["MemberId"] != null)
                {
                    lbmemberid.Text = selectedRow.Cells["MemberId"].Value?.ToString();
                }
                else
                {
                    lbmemberid.Text = "N/A";
                }

                string imgUrl = selectedRow.Cells["imgurl"].Value?.ToString();
                if (!string.IsNullOrEmpty(imgUrl))
                {
                    try
                    {
                        using (WebClient webClient = new WebClient())
                        {
                            byte[] imageBytes = webClient.DownloadData(imgUrl);
                            using (MemoryStream ms = new MemoryStream(imageBytes))
                            {
                                pictureBox1.Image = Image.FromStream(ms);
                                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error loading student image: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    try
                    {
                        pictureBox1.Image = Image.FromFile("C:\\Users\\Hasidu\\Downloads\\st2.jpg");
                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error loading default image: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                // Show issued books for the selected member
                datagrideveiw1show();
            }
        }

        private void datagrideveiw1show()
        {
            int memberId = 0;

            if (griddataveiw.SelectedRows.Count > 0 && !griddataveiw.CurrentRow.IsNewRow)
            {
                memberId = Convert.ToInt32(griddataveiw.CurrentRow.Cells["MemberId"].Value);

                try
                {
                    if (connection.State != ConnectionState.Open)
                    {
                        connection.Open();
                    }

                    string query = "SELECT IssueId, BookId, IssueDate, DueDate, ReturnDate FROM issuebook WHERE MemberId = @memberId";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@memberId", memberId);

                    // Clear previous data bindings
                    dt2.Clear(); // Clear the DataTable dt2

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt2); // Fill dt2 with data from the database
                    }

                    // Bind the DataGridView to the new DataTable dt2
                    dataGridView1.DataSource = dt2;
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show($"MySQL error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Unexpected error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (connection.State == ConnectionState.Open)
                    {
                        connection.Close();
                    }
                }
            }
        }

        private void btninsert_Click(object sender, EventArgs e)
        {
            // Insert member record
            string fname = txtfistname.Text;
            string lname = txtlastname.Text;
            string address = txtaddress.Text;
            string email = txtemail.Text;
            string phone = txtphone.Text;
            string imgurl = txtimage.Text;

            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }

                string query = "INSERT INTO members (FirstName, LastName, Address, Email, Phone, imgurl) VALUES (@fname, @lname, @address, @email, @phone, @imgurl)";
                MySqlCommand cmd = new MySqlCommand(query, connection);

                cmd.Parameters.AddWithValue("@fname", fname);
                cmd.Parameters.AddWithValue("@lname", lname);
                cmd.Parameters.AddWithValue("@address", address);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@phone", phone);
                cmd.Parameters.AddWithValue("@imgurl", imgurl);

                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Record Inserted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    search(); // Refresh the data grid view
                }
                else
                {
                    MessageBox.Show("No record inserted.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"MySQL error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unexpected error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            // Update member record
            string fname = txtfistname.Text;
            string lname = txtlastname.Text;
            string address = txtaddress.Text;
            string email = txtemail.Text;
            string phone = txtphone.Text;
            string imgurl = txtimage.Text;

            if (griddataveiw.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = griddataveiw.SelectedRows[0];
                int memberId = int.Parse(lbmemberid.Text);

                try
                {
                    if (connection.State != ConnectionState.Open)
                    {
                        connection.Open();
                    }

                    string query = "UPDATE members SET FirstName = @fname, LastName = @lname, Address = @address, Email = @email, Phone = @phone, imgurl = @imgurl WHERE MemberId = @memberId";
                    MySqlCommand cmd = new MySqlCommand(query, connection);

                    cmd.Parameters.AddWithValue("@fname", fname);
                    cmd.Parameters.AddWithValue("@lname", lname);
                    cmd.Parameters.AddWithValue("@address", address);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@phone", phone);
                    cmd.Parameters.AddWithValue("@imgurl", imgurl);
                    cmd.Parameters.AddWithValue("@memberId", memberId);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Record updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        search(); // Refresh the data grid view
                    }
                    else
                    {
                        MessageBox.Show("No record updated.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show($"MySQL error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Unexpected error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (connection.State == ConnectionState.Open)
                    {
                        connection.Close();
                    }
                }
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            // Delete member record
            int memberId = int.Parse(lbmemberid.Text);

            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }

                // Delete related records from issuedbooks table
                string deleteIssuedBooksQuery = "DELETE FROM issuebook WHERE MemberId = @memberId";
                MySqlCommand deleteIssuedBooksCmd = new MySqlCommand(deleteIssuedBooksQuery, connection);
                deleteIssuedBooksCmd.Parameters.AddWithValue("@memberId", memberId);
                deleteIssuedBooksCmd.ExecuteNonQuery();

                // Delete record from members table
                string deleteMemberQuery = "DELETE FROM members WHERE MemberId = @memberId";
                MySqlCommand deleteMemberCmd = new MySqlCommand(deleteMemberQuery, connection);
                deleteMemberCmd.Parameters.AddWithValue("@memberId", memberId);

                int rowsAffected = deleteMemberCmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Record deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    search(); // Refresh the data grid view
                }
                else
                {
                    MessageBox.Show("No record deleted.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"MySQL error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unexpected error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            clearTextFeild();
        }

        private void clearTextFeild()
        {
            txtlastname.Clear();
            txtfistname.Clear();
            txtaddress.Clear();
            txtemail.Clear();
            txtphone.Clear();
            lbmemberid.Text = "";
            txtimage.Clear();
            pictureBox1.Image = null;
        }

        // Dispose method to release resources
    }
}
