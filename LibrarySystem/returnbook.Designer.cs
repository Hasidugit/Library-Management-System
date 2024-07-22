namespace LibrarySystem
{
    partial class returnbook
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbmembername1 = new System.Windows.Forms.Label();
            this.lbidmember = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbduedate = new System.Windows.Forms.Label();
            this.lbbookid = new System.Windows.Forms.Label();
            this.lbbooktitle = new System.Windows.Forms.Label();
            this.lbissudate = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbmemberemail = new System.Windows.Forms.Label();
            this.pictureBoxmember = new System.Windows.Forms.PictureBox();
            this.txtmembersearch = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lbmembername = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxmember)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Wheat;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.listBox1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(9, 18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(824, 716);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(390, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Issued Books";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(193, 36);
            this.label5.TabIndex = 14;
            this.label5.Text = "Retrun Book";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(394, 109);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(399, 100);
            this.listBox1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SpringGreen;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(24, 430);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(774, 270);
            this.panel2.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(216, 214);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(238, 53);
            this.button2.TabIndex = 8;
            this.button2.Text = "Return Book";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.PeachPuff;
            this.panel4.Controls.Add(this.lbmembername1);
            this.panel4.Controls.Add(this.lbidmember);
            this.panel4.Location = new System.Drawing.Point(28, 21);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(275, 171);
            this.panel4.TabIndex = 7;
            // 
            // lbmembername1
            // 
            this.lbmembername1.AutoSize = true;
            this.lbmembername1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbmembername1.Location = new System.Drawing.Point(35, 113);
            this.lbmembername1.Name = "lbmembername1";
            this.lbmembername1.Size = new System.Drawing.Size(57, 20);
            this.lbmembername1.TabIndex = 5;
            this.lbmembername1.Text = "Name";
            // 
            // lbidmember
            // 
            this.lbidmember.AutoSize = true;
            this.lbidmember.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbidmember.Location = new System.Drawing.Point(35, 49);
            this.lbidmember.Name = "lbidmember";
            this.lbidmember.Size = new System.Drawing.Size(24, 20);
            this.lbidmember.TabIndex = 5;
            this.lbidmember.Text = "Id";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.PeachPuff;
            this.panel3.Controls.Add(this.lbduedate);
            this.panel3.Controls.Add(this.lbbookid);
            this.panel3.Controls.Add(this.lbbooktitle);
            this.panel3.Controls.Add(this.lbissudate);
            this.panel3.Location = new System.Drawing.Point(341, 21);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(413, 171);
            this.panel3.TabIndex = 6;
            // 
            // lbduedate
            // 
            this.lbduedate.AutoSize = true;
            this.lbduedate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbduedate.Location = new System.Drawing.Point(19, 141);
            this.lbduedate.Name = "lbduedate";
            this.lbduedate.Size = new System.Drawing.Size(0, 20);
            this.lbduedate.TabIndex = 9;
            // 
            // lbbookid
            // 
            this.lbbookid.AutoSize = true;
            this.lbbookid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbbookid.Location = new System.Drawing.Point(19, 24);
            this.lbbookid.Name = "lbbookid";
            this.lbbookid.Size = new System.Drawing.Size(0, 20);
            this.lbbookid.TabIndex = 7;
            // 
            // lbbooktitle
            // 
            this.lbbooktitle.AutoSize = true;
            this.lbbooktitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbbooktitle.Location = new System.Drawing.Point(19, 62);
            this.lbbooktitle.Name = "lbbooktitle";
            this.lbbooktitle.Size = new System.Drawing.Size(0, 20);
            this.lbbooktitle.TabIndex = 6;
            // 
            // lbissudate
            // 
            this.lbissudate.AutoSize = true;
            this.lbissudate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbissudate.Location = new System.Drawing.Point(19, 104);
            this.lbissudate.Name = "lbissudate";
            this.lbissudate.Size = new System.Drawing.Size(0, 20);
            this.lbissudate.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Violet;
            this.groupBox1.Controls.Add(this.lbmemberemail);
            this.groupBox1.Controls.Add(this.pictureBoxmember);
            this.groupBox1.Controls.Add(this.txtmembersearch);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.lbmembername);
            this.groupBox1.Location = new System.Drawing.Point(22, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(345, 309);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Member";
            // 
            // lbmemberemail
            // 
            this.lbmemberemail.AutoSize = true;
            this.lbmemberemail.Location = new System.Drawing.Point(160, 113);
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
            this.button1.Size = new System.Drawing.Size(112, 31);
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Member ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(367, 2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Retrun book details";
            // 
            // returnbook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 746);
            this.Controls.Add(this.panel1);
            this.Name = "returnbook";
            this.Text = "returnbook";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxmember)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbmemberemail;
        private System.Windows.Forms.PictureBox pictureBoxmember;
        private System.Windows.Forms.TextBox txtmembersearch;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbmembername;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbidmember;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label lbbooktitle;
        private System.Windows.Forms.Label lbbookid;
        private System.Windows.Forms.Label lbduedate;
        private System.Windows.Forms.Label lbissudate;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lbmembername1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}