namespace LibrarySystem
{
    partial class issuebookscreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mySqlConnection1 = new MySql.Data.MySqlClient.MySqlConnection();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbmemberemail = new System.Windows.Forms.Label();
            this.pictureBoxmember = new System.Windows.Forms.PictureBox();
            this.txtmembersearch = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lbmembername = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnisuue = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lbidbook = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbidmember = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbavilable = new System.Windows.Forms.Label();
            this.lbgenre = new System.Windows.Forms.Label();
            this.lbauthor = new System.Windows.Forms.Label();
            this.pictureBoxbook = new System.Windows.Forms.PictureBox();
            this.lbbookname = new System.Windows.Forms.Label();
            this.txtsearchbook = new System.Windows.Forms.TextBox();
            this.btnbooksearch = new System.Windows.Forms.Button();
            this.dataGridViewIssues = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.button2 = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxmember)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxbook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIssues)).BeginInit();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Violet;
            this.groupBox1.Controls.Add(this.lbmemberemail);
            this.groupBox1.Controls.Add(this.pictureBoxmember);
            this.groupBox1.Controls.Add(this.txtmembersearch);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.lbmembername);
            this.groupBox1.Location = new System.Drawing.Point(12, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(319, 309);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Member";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lbmemberemail
            // 
            this.lbmemberemail.AutoSize = true;
            this.lbmemberemail.Location = new System.Drawing.Point(160, 104);
            this.lbmemberemail.Name = "lbmemberemail";
            this.lbmemberemail.Size = new System.Drawing.Size(44, 16);
            this.lbmemberemail.TabIndex = 4;
            this.lbmemberemail.Text = "Name";
            // 
            // pictureBoxmember
            // 
            this.pictureBoxmember.Location = new System.Drawing.Point(15, 50);
            this.pictureBoxmember.Name = "pictureBoxmember";
            this.pictureBoxmember.Size = new System.Drawing.Size(139, 128);
            this.pictureBoxmember.TabIndex = 3;
            this.pictureBoxmember.TabStop = false;
            // 
            // txtmembersearch
            // 
            this.txtmembersearch.Location = new System.Drawing.Point(15, 256);
            this.txtmembersearch.Name = "txtmembersearch";
            this.txtmembersearch.Size = new System.Drawing.Size(181, 22);
            this.txtmembersearch.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(218, 251);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 31);
            this.button1.TabIndex = 1;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbmembername
            // 
            this.lbmembername.AutoSize = true;
            this.lbmembername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbmembername.Location = new System.Drawing.Point(160, 62);
            this.lbmembername.Name = "lbmembername";
            this.lbmembername.Size = new System.Drawing.Size(52, 18);
            this.lbmembername.TabIndex = 0;
            this.lbmembername.Text = "Name";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Wheat;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(13, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(682, 595);
            this.panel1.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(173, 36);
            this.label5.TabIndex = 13;
            this.label5.Text = "Issue Book";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.dateTimePicker1);
            this.panel2.Controls.Add(this.btnisuue);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Location = new System.Drawing.Point(26, 389);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(635, 187);
            this.panel2.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Set Due Date :";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(123, 143);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 13;
            // 
            // btnisuue
            // 
            this.btnisuue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnisuue.Location = new System.Drawing.Point(381, 142);
            this.btnisuue.Name = "btnisuue";
            this.btnisuue.Size = new System.Drawing.Size(156, 28);
            this.btnisuue.TabIndex = 12;
            this.btnisuue.Text = "Issue Book";
            this.btnisuue.UseVisualStyleBackColor = true;
            this.btnisuue.Click += new System.EventHandler(this.btnisuue_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Violet;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.lbidbook);
            this.panel3.Location = new System.Drawing.Point(351, 40);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(241, 63);
            this.panel3.TabIndex = 0;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "BookId :";
            // 
            // lbidbook
            // 
            this.lbidbook.AutoSize = true;
            this.lbidbook.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbidbook.Location = new System.Drawing.Point(132, 23);
            this.lbidbook.Name = "lbidbook";
            this.lbidbook.Size = new System.Drawing.Size(0, 18);
            this.lbidbook.TabIndex = 5;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Violet;
            this.panel4.Controls.Add(this.lbidmember);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Location = new System.Drawing.Point(27, 40);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(241, 63);
            this.panel4.TabIndex = 1;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // lbidmember
            // 
            this.lbidmember.AutoSize = true;
            this.lbidmember.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbidmember.Location = new System.Drawing.Point(161, 23);
            this.lbidmember.Name = "lbidmember";
            this.lbidmember.Size = new System.Drawing.Size(0, 18);
            this.lbidmember.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "MemberId :";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Violet;
            this.groupBox2.Controls.Add(this.lbavilable);
            this.groupBox2.Controls.Add(this.lbgenre);
            this.groupBox2.Controls.Add(this.lbauthor);
            this.groupBox2.Controls.Add(this.pictureBoxbook);
            this.groupBox2.Controls.Add(this.lbbookname);
            this.groupBox2.Controls.Add(this.txtsearchbook);
            this.groupBox2.Controls.Add(this.btnbooksearch);
            this.groupBox2.Location = new System.Drawing.Point(350, 58);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(318, 309);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Book";
            // 
            // lbavilable
            // 
            this.lbavilable.AutoSize = true;
            this.lbavilable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbavilable.Location = new System.Drawing.Point(161, 188);
            this.lbavilable.Name = "lbavilable";
            this.lbavilable.Size = new System.Drawing.Size(52, 18);
            this.lbavilable.TabIndex = 11;
            this.lbavilable.Text = "Name";
            // 
            // lbgenre
            // 
            this.lbgenre.AutoSize = true;
            this.lbgenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbgenre.Location = new System.Drawing.Point(161, 147);
            this.lbgenre.Name = "lbgenre";
            this.lbgenre.Size = new System.Drawing.Size(52, 18);
            this.lbgenre.TabIndex = 10;
            this.lbgenre.Text = "Name";
            // 
            // lbauthor
            // 
            this.lbauthor.AutoSize = true;
            this.lbauthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbauthor.Location = new System.Drawing.Point(161, 104);
            this.lbauthor.Name = "lbauthor";
            this.lbauthor.Size = new System.Drawing.Size(52, 18);
            this.lbauthor.TabIndex = 9;
            this.lbauthor.Text = "Name";
            // 
            // pictureBoxbook
            // 
            this.pictureBoxbook.Location = new System.Drawing.Point(16, 50);
            this.pictureBoxbook.Name = "pictureBoxbook";
            this.pictureBoxbook.Size = new System.Drawing.Size(139, 128);
            this.pictureBoxbook.TabIndex = 8;
            this.pictureBoxbook.TabStop = false;
            // 
            // lbbookname
            // 
            this.lbbookname.AutoSize = true;
            this.lbbookname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbbookname.Location = new System.Drawing.Point(161, 62);
            this.lbbookname.Name = "lbbookname";
            this.lbbookname.Size = new System.Drawing.Size(52, 18);
            this.lbbookname.TabIndex = 5;
            this.lbbookname.Text = "Name";
            // 
            // txtsearchbook
            // 
            this.txtsearchbook.Location = new System.Drawing.Point(16, 256);
            this.txtsearchbook.Name = "txtsearchbook";
            this.txtsearchbook.Size = new System.Drawing.Size(181, 22);
            this.txtsearchbook.TabIndex = 7;
            // 
            // btnbooksearch
            // 
            this.btnbooksearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbooksearch.Location = new System.Drawing.Point(221, 251);
            this.btnbooksearch.Name = "btnbooksearch";
            this.btnbooksearch.Size = new System.Drawing.Size(91, 27);
            this.btnbooksearch.TabIndex = 6;
            this.btnbooksearch.Text = "Search";
            this.btnbooksearch.UseVisualStyleBackColor = true;
            this.btnbooksearch.Click += new System.EventHandler(this.btnbooksearch_Click);
            // 
            // dataGridViewIssues
            // 
            this.dataGridViewIssues.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewIssues.Location = new System.Drawing.Point(701, 86);
            this.dataGridViewIssues.Name = "dataGridViewIssues";
            this.dataGridViewIssues.RowHeadersWidth = 51;
            this.dataGridViewIssues.RowTemplate.Height = 24;
            this.dataGridViewIssues.Size = new System.Drawing.Size(740, 415);
            this.dataGridViewIssues.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1210, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 16);
            this.label4.TabIndex = 3;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(31, 22);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(367, 22);
            this.dateTimePicker2.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(464, 21);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(196, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Search";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Snow;
            this.panel5.Controls.Add(this.dateTimePicker2);
            this.panel5.Controls.Add(this.button2);
            this.panel5.Location = new System.Drawing.Point(705, 14);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(736, 62);
            this.panel5.TabIndex = 6;
            // 
            // issuebookscreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(1470, 616);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridViewIssues);
            this.Controls.Add(this.panel1);
            this.Name = "issuebookscreen";
            this.Text = "issuebookscreen";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxmember)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxbook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIssues)).EndInit();
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MySql.Data.MySqlClient.MySqlConnection mySqlConnection1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtmembersearch;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbmembername;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbmemberemail;
        private System.Windows.Forms.PictureBox pictureBoxmember;
        private System.Windows.Forms.Label lbavilable;
        private System.Windows.Forms.Label lbgenre;
        private System.Windows.Forms.Label lbauthor;
        private System.Windows.Forms.PictureBox pictureBoxbook;
        private System.Windows.Forms.Label lbbookname;
        private System.Windows.Forms.TextBox txtsearchbook;
        private System.Windows.Forms.Button btnbooksearch;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbidmember;
        private System.Windows.Forms.Label lbidbook;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnisuue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView dataGridViewIssues;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel5;
    }
}