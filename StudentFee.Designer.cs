namespace student
{
    partial class StudentFee
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
            this.tableData = new System.Windows.Forms.DataGridView();
            this.searchComboBox = new System.Windows.Forms.ComboBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Search = new System.Windows.Forms.TextBox();
            this.btnHoose = new System.Windows.Forms.Button();
            this.btnDhexe = new System.Windows.Forms.Button();
            this.btnSare = new System.Windows.Forms.Button();
            this.All = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tableData)).BeginInit();
            this.SuspendLayout();
            // 
            // tableData
            // 
            this.tableData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tableData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableData.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableData.Location = new System.Drawing.Point(0, 144);
            this.tableData.Name = "tableData";
            this.tableData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tableData.Size = new System.Drawing.Size(982, 324);
            this.tableData.TabIndex = 19;
            // 
            // searchComboBox
            // 
            this.searchComboBox.FormattingEnabled = true;
            this.searchComboBox.Items.AddRange(new object[] {
            "Fee",
            "month",
            "ID",
            "lbt",
            "charge"});
            this.searchComboBox.Location = new System.Drawing.Point(508, 29);
            this.searchComboBox.Name = "searchComboBox";
            this.searchComboBox.Size = new System.Drawing.Size(149, 21);
            this.searchComboBox.TabIndex = 23;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.SteelBlue;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(834, 20);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(137, 38);
            this.button4.TabIndex = 22;
            this.button4.Text = "Search";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(425, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 21;
            this.label1.Text = "Search By:";
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(663, 29);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(158, 20);
            this.Search.TabIndex = 20;
            this.Search.TextChanged += new System.EventHandler(this.Search_TextChanged);
            // 
            // btnHoose
            // 
            this.btnHoose.BackColor = System.Drawing.Color.SteelBlue;
            this.btnHoose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHoose.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHoose.ForeColor = System.Drawing.Color.White;
            this.btnHoose.Location = new System.Drawing.Point(878, 90);
            this.btnHoose.Name = "btnHoose";
            this.btnHoose.Size = new System.Drawing.Size(90, 38);
            this.btnHoose.TabIndex = 24;
            this.btnHoose.Text = "D/Hoose";
            this.btnHoose.UseVisualStyleBackColor = false;
            this.btnHoose.Click += new System.EventHandler(this.btnHoose_Click);
            // 
            // btnDhexe
            // 
            this.btnDhexe.BackColor = System.Drawing.Color.SteelBlue;
            this.btnDhexe.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDhexe.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDhexe.ForeColor = System.Drawing.Color.White;
            this.btnDhexe.Location = new System.Drawing.Point(782, 90);
            this.btnDhexe.Name = "btnDhexe";
            this.btnDhexe.Size = new System.Drawing.Size(90, 38);
            this.btnDhexe.TabIndex = 25;
            this.btnDhexe.Text = "D/Dhexe";
            this.btnDhexe.UseVisualStyleBackColor = false;
            this.btnDhexe.Click += new System.EventHandler(this.btnDhexe_Click);
            // 
            // btnSare
            // 
            this.btnSare.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSare.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSare.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSare.ForeColor = System.Drawing.Color.White;
            this.btnSare.Location = new System.Drawing.Point(686, 90);
            this.btnSare.Name = "btnSare";
            this.btnSare.Size = new System.Drawing.Size(90, 38);
            this.btnSare.TabIndex = 26;
            this.btnSare.Text = "D/Sare";
            this.btnSare.UseVisualStyleBackColor = false;
            this.btnSare.Click += new System.EventHandler(this.btnSare_Click);
            // 
            // All
            // 
            this.All.BackColor = System.Drawing.Color.SteelBlue;
            this.All.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.All.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.All.ForeColor = System.Drawing.Color.White;
            this.All.Location = new System.Drawing.Point(590, 90);
            this.All.Name = "All";
            this.All.Size = new System.Drawing.Size(90, 38);
            this.All.TabIndex = 27;
            this.All.Text = "All";
            this.All.UseVisualStyleBackColor = false;
            this.All.Click += new System.EventHandler(this.All_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.Color.SteelBlue;
            this.btnupdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnupdate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.ForeColor = System.Drawing.Color.White;
            this.btnupdate.Location = new System.Drawing.Point(178, 76);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(107, 52);
            this.btnupdate.TabIndex = 28;
            this.btnupdate.Text = "PaidFee";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.Color.SteelBlue;
            this.btnadd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnadd.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.ForeColor = System.Drawing.Color.White;
            this.btnadd.Location = new System.Drawing.Point(12, 76);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(149, 52);
            this.btnadd.TabIndex = 29;
            this.btnadd.Text = "MonthCharge+";
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.SteelBlue;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(118, 20);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(167, 38);
            this.button2.TabIndex = 30;
            this.button2.Text = "DeleteSFee";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SteelBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(8, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 38);
            this.button1.TabIndex = 31;
            this.button1.Text = "RegSFee";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.SteelBlue;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(451, 90);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(133, 38);
            this.button3.TabIndex = 27;
            this.button3.Text = "NewStudents";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // StudentFee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 468);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.btnHoose);
            this.Controls.Add(this.btnDhexe);
            this.Controls.Add(this.btnSare);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.All);
            this.Controls.Add(this.searchComboBox);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.tableData);
            this.Name = "StudentFee";
            this.Text = "StudentSalary";
            this.Load += new System.EventHandler(this.StudentSalary_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tableData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView tableData;
        private System.Windows.Forms.ComboBox searchComboBox;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Search;
        private System.Windows.Forms.Button btnHoose;
        private System.Windows.Forms.Button btnDhexe;
        private System.Windows.Forms.Button btnSare;
        private System.Windows.Forms.Button All;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
    }
}