namespace SOFT562Week18
{
    partial class DatabaseForm
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
            this.dataGridViewAdministrator = new System.Windows.Forms.DataGridView();
            this.comboBoxQueryChoice = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIDSearch = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtfirstname = new System.Windows.Forms.TextBox();
            this.txtlastname = new System.Windows.Forms.TextBox();
            this.txtgender = new System.Windows.Forms.TextBox();
            this.txtrelationship = new System.Windows.Forms.TextBox();
            this.txtcity = new System.Windows.Forms.TextBox();
            this.txthometown = new System.Windows.Forms.TextBox();
            this.dataGridViewWorkplaces = new System.Windows.Forms.DataGridView();
            this.dataGridViewUniversities = new System.Windows.Forms.DataGridView();
            this.lstfriends = new System.Windows.Forms.ListBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lstmessages = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdministrator)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWorkplaces)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUniversities)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewAdministrator
            // 
            this.dataGridViewAdministrator.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAdministrator.Location = new System.Drawing.Point(5, 18);
            this.dataGridViewAdministrator.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewAdministrator.Name = "dataGridViewAdministrator";
            this.dataGridViewAdministrator.RowHeadersWidth = 51;
            this.dataGridViewAdministrator.RowTemplate.Height = 24;
            this.dataGridViewAdministrator.Size = new System.Drawing.Size(370, 449);
            this.dataGridViewAdministrator.TabIndex = 0;
            // 
            // comboBoxQueryChoice
            // 
            this.comboBoxQueryChoice.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxQueryChoice.FormattingEnabled = true;
            this.comboBoxQueryChoice.Items.AddRange(new object[] {
            "Users table",
            "Friends table",
            "Messages table",
            "Universities or colleges table",
            "Workplaces table"});
            this.comboBoxQueryChoice.Location = new System.Drawing.Point(5, 504);
            this.comboBoxQueryChoice.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxQueryChoice.Name = "comboBoxQueryChoice";
            this.comboBoxQueryChoice.Size = new System.Drawing.Size(276, 29);
            this.comboBoxQueryChoice.TabIndex = 2;
            this.comboBoxQueryChoice.SelectedIndexChanged += new System.EventHandler(this.comboBoxQueryChoice_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBoxQueryChoice);
            this.groupBox1.Controls.Add(this.dataGridViewAdministrator);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(399, 591);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Administrator database test";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 476);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Please select a database to display, using the dropdown below.";
            // 
            // txtIDSearch
            // 
            this.txtIDSearch.Location = new System.Drawing.Point(443, 46);
            this.txtIDSearch.Name = "txtIDSearch";
            this.txtIDSearch.Size = new System.Drawing.Size(115, 20);
            this.txtIDSearch.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(440, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Search by UserID here:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(440, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "UserID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(440, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "First name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(440, 197);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Last name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(440, 239);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Gender";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(571, 239);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Relationship status";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(440, 279);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Hometown";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(440, 321);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(24, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "City";
            // 
            // BtnSearch
            // 
            this.BtnSearch.Location = new System.Drawing.Point(574, 46);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(100, 20);
            this.BtnSearch.TabIndex = 16;
            this.BtnSearch.Text = "Search";
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(443, 110);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(346, 20);
            this.txtID.TabIndex = 17;
            // 
            // txtfirstname
            // 
            this.txtfirstname.Enabled = false;
            this.txtfirstname.Location = new System.Drawing.Point(443, 169);
            this.txtfirstname.Name = "txtfirstname";
            this.txtfirstname.Size = new System.Drawing.Size(231, 20);
            this.txtfirstname.TabIndex = 18;
            // 
            // txtlastname
            // 
            this.txtlastname.Enabled = false;
            this.txtlastname.Location = new System.Drawing.Point(443, 213);
            this.txtlastname.Name = "txtlastname";
            this.txtlastname.Size = new System.Drawing.Size(231, 20);
            this.txtlastname.TabIndex = 19;
            // 
            // txtgender
            // 
            this.txtgender.Enabled = false;
            this.txtgender.Location = new System.Drawing.Point(443, 255);
            this.txtgender.Name = "txtgender";
            this.txtgender.Size = new System.Drawing.Size(115, 20);
            this.txtgender.TabIndex = 20;
            // 
            // txtrelationship
            // 
            this.txtrelationship.Enabled = false;
            this.txtrelationship.Location = new System.Drawing.Point(574, 255);
            this.txtrelationship.Name = "txtrelationship";
            this.txtrelationship.Size = new System.Drawing.Size(173, 20);
            this.txtrelationship.TabIndex = 21;
            // 
            // txtcity
            // 
            this.txtcity.Enabled = false;
            this.txtcity.Location = new System.Drawing.Point(443, 337);
            this.txtcity.Name = "txtcity";
            this.txtcity.Size = new System.Drawing.Size(304, 20);
            this.txtcity.TabIndex = 22;
            // 
            // txthometown
            // 
            this.txthometown.Enabled = false;
            this.txthometown.Location = new System.Drawing.Point(443, 295);
            this.txthometown.Name = "txthometown";
            this.txthometown.Size = new System.Drawing.Size(304, 20);
            this.txthometown.TabIndex = 27;
            // 
            // dataGridViewWorkplaces
            // 
            this.dataGridViewWorkplaces.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewWorkplaces.Location = new System.Drawing.Point(443, 516);
            this.dataGridViewWorkplaces.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewWorkplaces.Name = "dataGridViewWorkplaces";
            this.dataGridViewWorkplaces.RowHeadersWidth = 51;
            this.dataGridViewWorkplaces.RowTemplate.Height = 24;
            this.dataGridViewWorkplaces.Size = new System.Drawing.Size(370, 87);
            this.dataGridViewWorkplaces.TabIndex = 5;
            // 
            // dataGridViewUniversities
            // 
            this.dataGridViewUniversities.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUniversities.Location = new System.Drawing.Point(443, 384);
            this.dataGridViewUniversities.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewUniversities.Name = "dataGridViewUniversities";
            this.dataGridViewUniversities.RowHeadersWidth = 51;
            this.dataGridViewUniversities.RowTemplate.Height = 24;
            this.dataGridViewUniversities.Size = new System.Drawing.Size(370, 95);
            this.dataGridViewUniversities.TabIndex = 6;
            // 
            // lstfriends
            // 
            this.lstfriends.FormattingEnabled = true;
            this.lstfriends.Location = new System.Drawing.Point(17, 635);
            this.lstfriends.Name = "lstfriends";
            this.lstfriends.Size = new System.Drawing.Size(399, 82);
            this.lstfriends.TabIndex = 28;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(440, 369);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(160, 13);
            this.label11.TabIndex = 29;
            this.label11.Text = "Universities or colleges attended";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(440, 501);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 13);
            this.label12.TabIndex = 30;
            this.label12.Text = "Workplaces";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(440, 620);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(55, 13);
            this.label13.TabIndex = 31;
            this.label13.Text = "Messages";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(14, 619);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(41, 13);
            this.label14.TabIndex = 32;
            this.label14.Text = "Friends";
            // 
            // lstmessages
            // 
            this.lstmessages.FormattingEnabled = true;
            this.lstmessages.Location = new System.Drawing.Point(443, 636);
            this.lstmessages.Name = "lstmessages";
            this.lstmessages.Size = new System.Drawing.Size(370, 82);
            this.lstmessages.TabIndex = 33;
            // 
            // DatabaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 732);
            this.Controls.Add(this.lstmessages);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lstfriends);
            this.Controls.Add(this.dataGridViewWorkplaces);
            this.Controls.Add(this.dataGridViewUniversities);
            this.Controls.Add(this.txthometown);
            this.Controls.Add(this.txtcity);
            this.Controls.Add(this.txtrelationship);
            this.Controls.Add(this.txtgender);
            this.Controls.Add(this.txtlastname);
            this.Controls.Add(this.txtfirstname);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtIDSearch);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "DatabaseForm";
            this.Text = "Database Form Test";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdministrator)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWorkplaces)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUniversities)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewAdministrator;
        private System.Windows.Forms.ComboBox comboBoxQueryChoice;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIDSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtfirstname;
        private System.Windows.Forms.TextBox txtlastname;
        private System.Windows.Forms.TextBox txtgender;
        private System.Windows.Forms.TextBox txtrelationship;
        private System.Windows.Forms.TextBox txtcity;
        private System.Windows.Forms.TextBox txthometown;
        private System.Windows.Forms.DataGridView dataGridViewWorkplaces;
        private System.Windows.Forms.DataGridView dataGridViewUniversities;
        private System.Windows.Forms.ListBox lstfriends;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ListBox lstmessages;
    }
}

