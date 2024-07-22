using System;
using System.Drawing;
using System.Windows.Forms;

namespace LibrarySystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            startpicture();
        
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            bookscreen bookscreen = new bookscreen();
            bookscreen.Show();
        }
        private void startpicture()
        {
            try
            {
                pictureBox1.Image = Image.FromFile("C:\\Users\\Hasidu\\Downloads\\library.png");
                pictureBox2.Image = Image.FromFile("C:\\Users\\Hasidu\\Downloads\\Icon_library.png");
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading picture: {ex.Message}");
            }
        }

        private void btnMember_Click(object sender, EventArgs e)
        {
            memeberscreen memeberscreen = new memeberscreen();
            memeberscreen.Show();
        }

        private void btnissuebook_Click(object sender, EventArgs e)
        {
            issuebookscreen issuebookscreen = new issuebookscreen();
            issuebookscreen.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            returnbook returnbook=new returnbook();
            returnbook.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            logscreen logscreen = new logscreen();
            logscreen.Show();
        }
    }
}
