using System;
using System.Windows.Forms;

namespace LibrarySystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            bookscreen bookscreen = new bookscreen();
            bookscreen.Show();
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
    }
}
