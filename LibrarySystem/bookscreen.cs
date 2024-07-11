using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Net;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace LibrarySystem
{
    public partial class bookscreen : Form
    {
        private MySqlConnection connection;
        private DataTable dt; // DataTable to hold search results

        public bookscreen()
        {
            InitializeComponent();
            InitializeDatabaseConnection();

            // Initialize DataTable
            dt = new DataTable();
            griddataveiw.DataSource = dt;

            // Attach TextChanged event handler to txtsearch
            txtsearch.TextChanged += Txtsearch_TextChanged;

            // Set up autocomplete
            txtsearch.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtsearch.AutoCompleteSource = AutoCompleteSource.CustomSource;

          

            


            // Attach SelectionChanged event handler to griddataveiw
            griddataveiw.SelectionChanged += Griddataveiw_SelectionChanged;
            startpicture();
          
        }
        private void startpicture()
        {
            pictureBox1.Image = Image.FromFile("C:\\Users\\Hasidu\\Downloads\\R.jpg");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
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
                MessageBox.Show($"Database error: {ex.Message}");
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show($"Connection error: {ex.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unexpected error: {ex.Message}");
            }
        }

        private void Txtsearch_TextChanged(object sender, EventArgs e)
        {
            search();
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

                string query = "SELECT * FROM books WHERE Title LIKE @search OR Author LIKE @search OR PublishedYear LIKE @search OR Genre LIKE @search OR Available LIKE @search";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@search", $"%{searchText}%");

                // Clear previous data from DataTable
                dt.Clear();

                // Fill the DataTable with new search results
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                {
                    adapter.Fill(dt);
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"MySQL error: {ex.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unexpected error: {ex.Message}");
            }
            finally
            {
                connection.Close();
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            txtsearch.Text = "";
        }

        private void Griddataveiw_SelectionChanged(object sender, EventArgs e)
        {
            if (griddataveiw.SelectedRows.Count > 0 && !griddataveiw.CurrentRow.IsNewRow)
            {
                DataGridViewRow selectedRow = griddataveiw.SelectedRows[0];

                // Populate text fields with data from selected row
                txtname.Text = selectedRow.Cells["Title"].Value.ToString();
                txtauthor.Text = selectedRow.Cells["Author"].Value.ToString();
                txtpublished.Text = selectedRow.Cells["PublishedYear"].Value.ToString();
                txtgenre.Text = selectedRow.Cells["Genre"].Value.ToString();
                txtavalable.Text = selectedRow.Cells["Available"].Value.ToString();
                txtimageurl.Text= selectedRow.Cells["imgurl"].Value.ToString();

                if (griddataveiw.Columns.Contains("BookId"))
                {
                    lbid.Text = selectedRow.Cells["BookId"].Value?.ToString();
                }
                else
                {
                    // Handle case where BookId column is not found
                    lbid.Text = "N/A";
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
                                if (imgUrl != "")
                                {
                                    pictureBox1.Image = Image.FromStream(ms);
                                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                }
                                else
                                {
                                    using (FileStream fs = new FileStream("C:\\Users\\Hasidu\\Downloads\\l2.jpg", FileMode.Open, FileAccess.Read))
                                    {
                                        pictureBox1.Image = Image.FromStream(fs);
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                    }
                                }

                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error loading student image: {ex.Message}");
                    }
                }
                else
                {
                    pictureBox1.Image = null;
                }
            }
        }


        private void btninsert_Click(object sender, EventArgs e)
        {
            string title = txtname.Text;
            string author = txtauthor.Text;
            int publishedYear;
            int.TryParse(txtpublished.Text, out publishedYear);
            string genre = txtgenre.Text;
            bool available = txtavalable.Text == "1";
            String imageurl=txtimageurl.Text;

            try
            {
                connection.Open();
                string query = "INSERT INTO books (Title, Author, PublishedYear, Genre, Available) VALUES (@Title, @Author, @PublishedYear, @Genre, @Available ,@imgurl)";
                MySqlCommand cmd = new MySqlCommand(query, connection);

                cmd.Parameters.AddWithValue("@Title", title);
                cmd.Parameters.AddWithValue("@Author", author);
                cmd.Parameters.AddWithValue("@PublishedYear", publishedYear != 0 ? (object)publishedYear : DBNull.Value);
                cmd.Parameters.AddWithValue("@Genre", genre ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@Available", available ? 1 : 0);
                cmd.Parameters.AddWithValue("@imgurl", imageurl);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Record inserted successfully.");
            }
            catch (Exception)
            {
             
            }
            finally
            {
                connection.Close();
            }
        }
        private void btnupdate_Click(object sender, EventArgs e)
        {
            // Retrieve values from text fields
            string title = txtname.Text;
            string author = txtauthor.Text;
            int publishedYear;
            int.TryParse(txtpublished.Text, out publishedYear);
            string genre = txtgenre.Text;
            bool available = txtavalable.Text == "1";
            String imageurl = txtimageurl.Text;

            // Check if a row is selected in griddataveiw
            if (griddataveiw.SelectedRows.Count > 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = griddataveiw.SelectedRows[0];

                // Retrieve the book ID or any unique identifier for the selected row
                int bookId = int.Parse(lbid.Text);

                try
                {
                    // Open connection if not already open
                    if (connection.State != ConnectionState.Open)
                    {
                        connection.Open();
                    }

                    // Prepare the update query
                    string query = "UPDATE books SET Title = @Title, Author = @Author, PublishedYear = @PublishedYear, Genre = @Genre, Available = @Available imgurl=@imageurl WHERE BookId = @BookId";
                    MySqlCommand cmd = new MySqlCommand(query, connection);

                    // Bind parameters
                    cmd.Parameters.AddWithValue("@Title", title);
                    cmd.Parameters.AddWithValue("@Author", author);
                    cmd.Parameters.AddWithValue("@PublishedYear", publishedYear);
                    cmd.Parameters.AddWithValue("@Genre", genre);
                    cmd.Parameters.AddWithValue("@Available", available ? 1 : 0);
                    cmd.Parameters.AddWithValue("@BookId", bookId);
                    cmd.Parameters.AddWithValue("@imgurl", imageurl);


                    // Execute the update command
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Record updated successfully.");
                        // Clear previous data from DataTable
                        dt.Clear();
                        clearTextFeild();

                        txtsearch.Text = $"{bookId}";
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            adapter.Fill(dt);
                        }
                    }
                    else
                    {
                        MessageBox.Show("No record updated.");
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show($"MySQL error: {ex.Message}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Unexpected error: {ex.Message}");
                }
                finally
                {
                    // Close connection
                    connection.Close();
                }
            }
            else
            {
                MessageBox.Show("Please select a row to update.");
            }
        }
        private void clearTextFeild()
        {
            txtname.Clear();
            txtauthor.Clear();  
            txtpublished.Clear();
            txtgenre.Clear();
            txtavalable.Clear();
            lbid.Text = "";
            txtimageurl.Clear();
            

        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            int bookId=int.Parse(lbid.Text);

            try
            {
                // Open connection if not already open
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }

                // Prepare the delete query
                string query = "DELETE FROM books WHERE BookId = @BookId";
                MySqlCommand cmd = new MySqlCommand(query, connection);

                // Bind parameter
                cmd.Parameters.AddWithValue("@BookId", bookId);

                // Execute the delete command
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Record deleted successfully.");
                    // Clear previous data from DataTable
                    dt.Clear();

                    // Optionally, refetch and display updated data
                    search();
                }
                else
                {
                    MessageBox.Show("No record deleted.");
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"MySQL error: {ex.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unexpected error: {ex.Message}");
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            clearTextFeild();
        }
    }
}
