using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibrarySystem
{
    public partial class returnbook : Form
    {
        private MySqlConnection connection;
       
        public returnbook()
        {
            InitializeComponent();
            InitializeDatabaseConnection();
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
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

        private void button1_Click(object sender, EventArgs e)
        {
            int searchmember;
            if (!int.TryParse(txtmembersearch.Text, out searchmember))
            {
                MessageBox.Show("Please enter a valid Member ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            lbidmember.Text = searchmember.ToString();
            

            // Clear previous items in listBox1
            listBox1.Items.Clear();

            try
            {
                // Fetch member details
                string memberQuery = "SELECT * FROM members WHERE MemberId = @searchmember";
                MySqlCommand memberCmd = new MySqlCommand(memberQuery, connection);
                memberCmd.Parameters.AddWithValue("@searchmember", searchmember);

                // Execute member query
                using (MySqlDataReader memberReader = memberCmd.ExecuteReader())
                {
                    if (memberReader.Read())
                    {
                        string fname = memberReader["FirstName"].ToString();
                        string lname = memberReader["LastName"].ToString();
                        string email = memberReader["Email"].ToString();
                        string imgurl = memberReader["imgurl"].ToString();
                        lbmembername.Text = fname + " " + lname;
                        lbmemberemail.Text = email;
                        lbmembername1.Text = fname + " " + lname;
                        try
                        {
                            // Load member image
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
                        lbmembername.Text = "";
                        lbmemberemail.Text = "";
                        pictureBoxmember.Image = null;
                        return; // Exit method if member not found
                    }
                }
                dataload(searchmember);
            
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
        private void dataload(int searchmember)
        {
            // Fetch return book list for the specified member
            string returnBookQuery = @"
            SELECT b.BookId, b.Title, b.Author, i.IssueDate, i.DueDate, i.ReturnDate
            FROM books b 
            JOIN issuebook i ON b.BookId = i.BookId 
            WHERE i.MemberId = @searchmember";

            MySqlCommand returnBookCmd = new MySqlCommand(returnBookQuery, connection);
            returnBookCmd.Parameters.AddWithValue("@searchmember", searchmember);

            // Execute return book query
            using (MySqlDataReader returnBookReader = returnBookCmd.ExecuteReader())
            {
                while (returnBookReader.Read())
                {
                    string bookId = returnBookReader["BookId"].ToString();
                    string title = returnBookReader["Title"].ToString();
                    string author = returnBookReader["Author"].ToString();
                    string issueDate = returnBookReader["IssueDate"] is DBNull ? "Not Issued" : ((DateTime)returnBookReader["IssueDate"]).ToString("yyyy-MM-dd");
                    string dueDate = returnBookReader["DueDate"] is DBNull ? "Not Issued" : ((DateTime)returnBookReader["DueDate"]).ToString("yyyy-MM-dd");
                    string returnDate = returnBookReader["ReturnDate"] is DBNull ? "Not Returned" : ((DateTime)returnBookReader["ReturnDate"]).ToString("yyyy-MM-dd");

                    // Format the output for each book
                    string bookDetails = $"Book ID: {bookId}, Title: {title}, Author: {author}, Issue Date: {issueDate}, Due Date: {dueDate}, Return Date: {returnDate}";

                    // Add formatted book details to listBox1
                    listBox1.Items.Add(bookDetails);
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                // Extract the details from the selected item
                string selectedItem = listBox1.SelectedItem.ToString();

                // Extract book title
                int titleStartIndex = selectedItem.IndexOf("Title: ") + "Title: ".Length;
                int titleEndIndex = selectedItem.IndexOf(",", titleStartIndex);
                string bookTitle = selectedItem.Substring(titleStartIndex, titleEndIndex - titleStartIndex);

                // Extract book ID
                int idStartIndex = selectedItem.IndexOf("Book ID: ") + "Book ID: ".Length;
                int idEndIndex = selectedItem.IndexOf(",", idStartIndex);
                string bookId = selectedItem.Substring(idStartIndex, idEndIndex - idStartIndex);

                // Extract issue date
                int issueStartIndex = selectedItem.IndexOf("Issue Date: ") + "Issue Date: ".Length;
                int issueEndIndex = selectedItem.IndexOf(",", issueStartIndex);
                string issueDate = selectedItem.Substring(issueStartIndex, issueEndIndex - issueStartIndex);

                // Extract due date
                int dueStartIndex = selectedItem.IndexOf("Due Date: ") + "Due Date: ".Length;
                string dueDate = selectedItem.Substring(dueStartIndex).Trim();

                // Assign values to respective labels
                lbbooktitle.Text = bookTitle.Trim();
                lbbookid.Text = bookId.Trim();
                lbissudate.Text = issueDate.Trim();
                lbduedate.Text = dueDate.Trim();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                // Extract the book ID from the selected item
                string selectedItem = listBox1.SelectedItem.ToString();
                int startIndex = selectedItem.IndexOf("Book ID: ") + "Book ID: ".Length;
                int endIndex = selectedItem.IndexOf(",", startIndex);
                string bookId = selectedItem.Substring(startIndex, endIndex - startIndex).Trim();

                // Update the database to mark the book as returned in issuebook table
                try
                {
                    // Update issuebook table
                    string updateIssueBookQuery = "UPDATE issuebook SET ReturnDate = @returnDate WHERE BookId = @bookId";
                    MySqlCommand updateIssueBookCmd = new MySqlCommand(updateIssueBookQuery, connection);
                    updateIssueBookCmd.Parameters.AddWithValue("@returnDate", DateTime.Today); // Assuming today is the return date
                    updateIssueBookCmd.Parameters.AddWithValue("@bookId", bookId);

                    int rowsAffectedIssueBook = updateIssueBookCmd.ExecuteNonQuery();

                    // Update books table to set Available = 1 (true)
                    if (rowsAffectedIssueBook > 0)
                    {
                        string updateBooksQuery = "UPDATE books SET Available = 1 WHERE BookId = @bookId";
                        MySqlCommand updateBooksCmd = new MySqlCommand(updateBooksQuery, connection);
                        updateBooksCmd.Parameters.AddWithValue("@bookId", bookId);

                        int rowsAffectedBooks = updateBooksCmd.ExecuteNonQuery();
                        if (rowsAffectedBooks > 0)
                        {
                            MessageBox.Show("Book returned successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Log the action in the log table
                            string logAction = "Book returned by member";
                            LogAction(logAction, int.Parse(lbidmember.Text));

                            // Refresh the list after update
                            button1_Click(sender, e); // Call button1_Click to reload the list
                        }
                        else
                        {
                            MessageBox.Show("Failed to update the books table.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Failed to return the book in issuebook table.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            else
            {
                MessageBox.Show("Please select a book to return.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LogAction(string action, int memberId)
        {
            try
            {
                // Insert into log table
                string insertLogQuery = "INSERT INTO log (Action, ActionDateTime) VALUES (@action, @actionDateTime)";
                MySqlCommand insertLogCmd = new MySqlCommand(insertLogQuery, connection);
                insertLogCmd.Parameters.AddWithValue("@action", $"{action} {memberId}");
                insertLogCmd.Parameters.AddWithValue("@actionDateTime", DateTime.Now);

                int rowsAffected = insertLogCmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    Console.WriteLine("Log entry added successfully.");
                }
                else
                {
                    Console.WriteLine("Failed to add log entry.");
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

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
