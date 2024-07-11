namespace LibrarySystem
{
    partial class bookscreen
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
            this.lbid = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btninsert = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.txtavalable = new System.Windows.Forms.TextBox();
            this.txtgenre = new System.Windows.Forms.TextBox();
            this.txtpublished = new System.Windows.Forms.TextBox();
            this.txtauthor = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.griddataveiw = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.lbimgurl = new System.Windows.Forms.Label();
            this.txtimageurl = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.griddataveiw)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CadetBlue;
            this.panel1.Controls.Add(this.txtimageurl);
            this.panel1.Controls.Add(this.lbimgurl);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lbid);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.txtavalable);
            this.panel1.Controls.Add(this.txtgenre);
            this.panel1.Controls.Add(this.txtpublished);
            this.panel1.Controls.Add(this.txtauthor);
            this.panel1.Controls.Add(this.txtname);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(507, 729);
            this.panel1.TabIndex = 0;
            // 
            // lbid
            // 
            this.lbid.AutoSize = true;
            this.lbid.BackColor = System.Drawing.Color.Transparent;
            this.lbid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbid.Location = new System.Drawing.Point(203, 345);
            this.lbid.Name = "lbid";
            this.lbid.Size = new System.Drawing.Size(24, 20);
            this.lbid.TabIndex = 18;
            this.lbid.Text = "Id";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(36, 345);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = "Id";
            // 
            // txtsearch
            // 
            this.txtsearch.Location = new System.Drawing.Point(110, 13);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(221, 22);
            this.txtsearch.TabIndex = 16;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.btninsert);
            this.panel2.Controls.Add(this.btnupdate);
            this.panel2.Controls.Add(this.btndelete);
            this.panel2.Controls.Add(this.btnclear);
            this.panel2.Location = new System.Drawing.Point(21, 625);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(466, 77);
            this.panel2.TabIndex = 15;
            // 
            // btninsert
            // 
            this.btninsert.Location = new System.Drawing.Point(19, 28);
            this.btninsert.Name = "btninsert";
            this.btninsert.Size = new System.Drawing.Size(75, 23);
            this.btninsert.TabIndex = 6;
            this.btninsert.Text = "Insert";
            this.btninsert.UseVisualStyleBackColor = true;
            this.btninsert.Click += new System.EventHandler(this.btninsert_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(146, 28);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(75, 23);
            this.btnupdate.TabIndex = 14;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(261, 28);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(75, 23);
            this.btndelete.TabIndex = 7;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(375, 28);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(75, 23);
            this.btnclear.TabIndex = 8;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // txtavalable
            // 
            this.txtavalable.Location = new System.Drawing.Point(207, 534);
            this.txtavalable.Name = "txtavalable";
            this.txtavalable.Size = new System.Drawing.Size(221, 22);
            this.txtavalable.TabIndex = 13;
            // 
            // txtgenre
            // 
            this.txtgenre.Location = new System.Drawing.Point(207, 496);
            this.txtgenre.Name = "txtgenre";
            this.txtgenre.Size = new System.Drawing.Size(221, 22);
            this.txtgenre.TabIndex = 12;
            // 
            // txtpublished
            // 
            this.txtpublished.Location = new System.Drawing.Point(207, 451);
            this.txtpublished.Name = "txtpublished";
            this.txtpublished.Size = new System.Drawing.Size(221, 22);
            this.txtpublished.TabIndex = 11;
            // 
            // txtauthor
            // 
            this.txtauthor.Location = new System.Drawing.Point(207, 412);
            this.txtauthor.Name = "txtauthor";
            this.txtauthor.Size = new System.Drawing.Size(221, 22);
            this.txtauthor.TabIndex = 10;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(207, 375);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(221, 22);
            this.txtname.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(36, 412);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Author";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(36, 453);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Published year";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 496);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Genre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 534);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Available";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 377);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Title";
            // 
            // griddataveiw
            // 
            this.griddataveiw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.griddataveiw.Location = new System.Drawing.Point(525, 23);
            this.griddataveiw.Name = "griddataveiw";
            this.griddataveiw.RowHeadersWidth = 51;
            this.griddataveiw.RowTemplate.Height = 24;
            this.griddataveiw.Size = new System.Drawing.Size(1087, 552);
            this.griddataveiw.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(39, 89);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(264, 236);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.clearButton);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.txtsearch);
            this.panel3.Location = new System.Drawing.Point(40, 14);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(447, 47);
            this.panel3.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(16, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 20);
            this.label7.TabIndex = 21;
            this.label7.Text = "Search";
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(338, 12);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 22;
            this.clearButton.Text = "Clean";
            this.clearButton.UseVisualStyleBackColor = true;
            // 
            // lbimgurl
            // 
            this.lbimgurl.AutoSize = true;
            this.lbimgurl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbimgurl.Location = new System.Drawing.Point(35, 571);
            this.lbimgurl.Name = "lbimgurl";
            this.lbimgurl.Size = new System.Drawing.Size(87, 20);
            this.lbimgurl.TabIndex = 21;
            this.lbimgurl.Text = "Image url";
            // 
            // txtimageurl
            // 
            this.txtimageurl.Location = new System.Drawing.Point(207, 569);
            this.txtimageurl.Name = "txtimageurl";
            this.txtimageurl.Size = new System.Drawing.Size(221, 22);
            this.txtimageurl.TabIndex = 22;
            // 
            // bookscreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1651, 771);
            this.Controls.Add(this.griddataveiw);
            this.Controls.Add(this.panel1);
            this.Name = "bookscreen";
            this.Text = "bookscreen";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.griddataveiw)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtavalable;
        private System.Windows.Forms.TextBox txtgenre;
        private System.Windows.Forms.TextBox txtpublished;
        private System.Windows.Forms.TextBox txtauthor;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btninsert;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView griddataveiw;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.Label lbid;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.TextBox txtimageurl;
        private System.Windows.Forms.Label lbimgurl;
    }
}