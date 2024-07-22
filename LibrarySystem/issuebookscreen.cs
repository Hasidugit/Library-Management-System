using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace LibrarySystem
{
    public partial class issuebookscreen : Form
    {
        private MySqlConnection connection;
        private DataTable dt;
        public issuebookscreen()
        {
            InitializeComponent();
            InitializeDatabaseConnection();
            dt = new DataTable(); // Initialize the DataTable here
            LoadTodaysIssues();
        }


        private void LoadTodaysIssues()
        {
            DateTime today = DateTime.Today;

            try
            {
                string query = "SELECT books.Title AS BookTitle, members.FirstName AS MemberFirstName, members.LastName AS MemberLastName, issuebook.IssueDate, issuebook.DueDate " +
                               "FROM issuebook " +
                               "INNER JOIN books ON issuebook.BookId = books.BookId " +
                               "INNER JOIN members ON issuebook.MemberId = members.MemberId " +
                               "WHERE DATE(issuebook.IssueDate) = @today";

                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@today", today);

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dt); // Fill the DataTable with data from the database
                dataGridViewIssues.DataSource = dt; // Bind the DataTable to the DataGridView
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

        // Other methods for button clicks, etc. as per your application logic

        
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

        private void button1_Click(object sender, EventArgs e)
        {
            int searchmember;
            if (!int.TryParse(txtmembersearch.Text, out searchmember))
            {
                MessageBox.Show("Please enter a valid Member ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            lbidmember.Text = searchmember.ToString();
            try
            {
                string query = "SELECT * FROM members WHERE MemberId = @searchmember";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@searchmember", searchmember);

                // Execute the query
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        // Assuming lbmembername is a label to display the member name
                        string fname = reader["FirstName"].ToString(); // Corrected typo in column name
                        string lname = reader["LastName"].ToString();
                        string email = reader["Email"].ToString();
                        string imgurl = reader["imgurl"].ToString();
                        lbmembername.Text = fname + " " + lname;
                        lbmemberemail.Text = email;

                        try
                        {
                            using (WebClient webClient = new WebClient())
                            {
                                byte[] imageBytes = webClient.DownloadData(imgurl);
                                using (MemoryStream ms = new MemoryStream(imageBytes))
                                {
                                    pictureBoxmember.Image = Image.FromStream(ms);
                                    pictureBoxmember.SizeMode = PictureBoxSizeMode.StretchImage;
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Error loading member image: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Member not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        lbmembername.Text = ""; // Clear the member name label
                        lbmemberemail.Text = ""; // Clear the member email label
                        pictureBoxmember.Image = null; // Clear the member picture box
                    }
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

        private void btnbooksearch_Click(object sender, EventArgs e)
        {
            int bookid;
            if (!int.TryParse(txtsearchbook.Text, out bookid))
            {
                MessageBox.Show("Please enter a valid Book ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            lbidbook.Text=bookid.ToString();
            try
            {
                string query = "SELECT * FROM books WHERE BookId = @bokid";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@bokid", bookid);

                // Execute the query
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        // Assuming lbbookname, lbauthor, lbgenre, lbavailable are labels to display book information
                        string name = reader["Title"].ToString();
                        string author = reader["Author"].ToString();
                        string genre = reader["Genre"].ToString();
                        string available = reader["Available"].ToString();
                        string imgurl = reader["imgurl"].ToString();

                        lbbookname.Text = name;
                        lbauthor.Text = author;
                        lbgenre.Text = genre;
                        lbavilable.Text = available;

                        try
                        {
                            using (WebClient webClient = new WebClient())
                            {
                                byte[] imageBytes = webClient.DownloadData(imgurl);
                                using (MemoryStream ms = new MemoryStream(imageBytes))
                                {
                                    pictureBoxbook.Image = Image.FromStream(ms);
                                    pictureBoxbook.SizeMode = PictureBoxSizeMode.StretchImage;
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Error loading book image: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Book not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        lbbookname.Text = ""; // Clear the book name label
                        lbauthor.Text = ""; // Clear the author label
                        lbgenre.Text = ""; // Clear the genre label
                        lbavilable.Text = ""; // Clear the available label
                        pictureBoxbook.Image = null; // Clear the book picture box
                    }
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnisuue_Click(object sender, EventArgs e)
        {
            int bookId;
            if (!int.TryParse(txtsearchbook.Text, out bookId))
            {
                MessageBox.Show("Please enter a valid Book ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int memberId;
            if (!int.TryParse(txtmembersearch.Text, out memberId))
            {
                MessageBox.Show("Please enter a valid Member ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check book availability before issuing
            bool isAvailable = CheckBookAvailability(bookId);
            if (!isAvailable)
            {
                MessageBox.Show("The selected book is not available.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DateTime issueDate = DateTime.Now; // Issue date is current date and time
            DateTime dueDate = dateTimePicker1.Value;

            try
            {
                // Insert into issuebook table
                string insertIssueQuery = "INSERT INTO issuebook (BookId, MemberId, IssueDate, DueDate) VALUES (@bookId, @memberId, @issueDate, @dueDate)";
                MySqlCommand insertCmd = new MySqlCommand(insertIssueQuery, connection);
                insertCmd.Parameters.AddWithValue("@bookId", bookId);
                insertCmd.Parameters.AddWithValue("@memberId", memberId);
                insertCmd.Parameters.AddWithValue("@issueDate", issueDate);
                insertCmd.Parameters.AddWithValue("@dueDate", dueDate);
                insertCmd.ExecuteNonQuery();

                // Update books table to mark the book as unavailable
                string updateBookQuery = "UPDATE books SET Available = 0 WHERE BookId = @bookId";
                MySqlCommand updateCmd = new MySqlCommand(updateBookQuery, connection);
                updateCmd.Parameters.AddWithValue("@bookId", bookId);
                updateCmd.ExecuteNonQuery();

                MessageBox.Show("Book issued successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private bool CheckBookAvailability(int bookId)
        {
            try
            {
                string query = "SELECT Available FROM books WHERE BookId = @bookId";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@bookId", bookId);

                object result = cmd.ExecuteScalar();
                if (result != null && result != DBNull.Value)
                {
                    int available = Convert.ToInt32(result);
                    return available == 1; // Return true if book is available (1), false otherwise
                }
                else
                {
                    return false; // Book record not found or Available field is null
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Database error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unexpected error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        private void DisplayTodaysIssues()
        {
            DateTime today = DateTime.Today;

            try
            {
                string query = "SELECT books.Title AS BookTitle, members.FirstName AS MemberFirstName, members.LastName AS MemberLastName, issuebook.IssueDate, issuebook.ReturnDate " +
                               "FROM issuebook " +
                               "INNER JOIN books ON issuebook.BookId = books.BookId " +
                               "INNER JOIN members ON issuebook.MemberId = members.MemberId " +
                               "WHERE issuebook.IssueDate = @today";

                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@today", today);

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dataGridViewIssues.DataSource = dt;
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

        private void YourForm_Load(object sender, EventArgs e)
        {
            InitializeDatabaseConnection();
            DisplayTodaysIssues();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DateTime today = dateTimePicker2.Value;

            try
            {
                string query = "SELECT books.Title AS BookTitle, members.FirstName AS MemberFirstName, members.LastName AS MemberLastName, issuebook.IssueDate, issuebook.DueDate " +
                               "FROM issuebook " +
                               "INNER JOIN books ON issuebook.BookId = books.BookId " +
                               "INNER JOIN members ON issuebook.MemberId = members.MemberId " +
                               "WHERE DATE(issuebook.DueDate) = @today";

                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@today", today);

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                dt.Clear(); // Clear the DataTable before filling with new data
                adapter.Fill(dt); // Fill the DataTable with data from the database
                dataGridViewIssues.DataSource = dt; // Bind the DataTable to the DataGridView
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

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
