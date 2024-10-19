namespace student
{
    partial class Admission
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
            this.btnHoose = new System.Windows.Forms.Button();
            this.btnDhexe = new System.Windows.Forms.Button();
            this.btnSare = new System.Windows.Forms.Button();
            this.All = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Search = new System.Windows.Forms.TextBox();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tableData)).BeginInit();
            this.SuspendLayout();
            // 
            // tableData
            // 
            this.tableData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tableData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableData.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableData.Location = new System.Drawing.Point(0, 200);
            this.tableData.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableData.Name = "tableData";
            this.tableData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tableData.Size = new System.Drawing.Size(1765, 498);
            this.tableData.TabIndex = 30;
            // 
            // searchComboBox
            // 
            this.searchComboBox.FormattingEnabled = true;
            this.searchComboBox.Items.AddRange(new object[] {
            "Tell",
            "Name",
            "ResTell",
            "ID"});
            this.searchComboBox.Location = new System.Drawing.Point(1269, 29);
            this.searchComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.searchComboBox.Name = "searchComboBox";
            this.searchComboBox.Size = new System.Drawing.Size(222, 28);
            this.searchComboBox.TabIndex = 29;
            // 
            // btnHoose
            // 
            this.btnHoose.BackColor = System.Drawing.Color.SteelBlue;
            this.btnHoose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHoose.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHoose.ForeColor = System.Drawing.Color.White;
            this.btnHoose.Location = new System.Drawing.Point(1618, 109);
            this.btnHoose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnHoose.Name = "btnHoose";
            this.btnHoose.Size = new System.Drawing.Size(135, 58);
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
            this.btnDhexe.Location = new System.Drawing.Point(1473, 109);
            this.btnDhexe.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDhexe.Name = "btnDhexe";
            this.btnDhexe.Size = new System.Drawing.Size(135, 58);
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
            this.btnSare.Location = new System.Drawing.Point(1327, 109);
            this.btnSare.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSare.Name = "btnSare";
            this.btnSare.Size = new System.Drawing.Size(135, 58);
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
            this.All.Location = new System.Drawing.Point(1178, 109);
            this.All.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.All.Name = "All";
            this.All.Size = new System.Drawing.Size(135, 58);
            this.All.TabIndex = 27;
            this.All.Text = "All";
            this.All.UseVisualStyleBackColor = false;
            this.All.Click += new System.EventHandler(this.All_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1138, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 25);
            this.label1.TabIndex = 23;
            this.label1.Text = "Search By:";
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(1518, 29);
            this.Search.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(235, 26);
            this.Search.TabIndex = 22;
            this.Search.TextChanged += new System.EventHandler(this.Search_TextChanged);
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.Color.SteelBlue;
            this.btnupdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnupdate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.ForeColor = System.Drawing.Color.White;
            this.btnupdate.Location = new System.Drawing.Point(338, 3);
            this.btnupdate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(300, 80);
            this.btnupdate.TabIndex = 20;
            this.btnupdate.Text = "Update Student";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.Color.SteelBlue;
            this.btnadd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnadd.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.ForeColor = System.Drawing.Color.White;
            this.btnadd.Location = new System.Drawing.Point(13, 3);
            this.btnadd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(300, 80);
            this.btnadd.TabIndex = 21;
            this.btnadd.Text = "Add Student";
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // Admission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1765, 698);
            this.Controls.Add(this.tableData);
            this.Controls.Add(this.searchComboBox);
            this.Controls.Add(this.btnHoose);
            this.Controls.Add(this.btnDhexe);
            this.Controls.Add(this.btnSare);
            this.Controls.Add(this.All);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btnadd);
            this.MaximumSize = new System.Drawing.Size(1787, 754);
            this.Name = "Admission";
            this.Text = "Admission";
            this.Load += new System.EventHandler(this.Admission_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tableData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView tableData;
        private System.Windows.Forms.ComboBox searchComboBox;
        private System.Windows.Forms.Button btnHoose;
        private System.Windows.Forms.Button btnDhexe;
        private System.Windows.Forms.Button btnSare;
        private System.Windows.Forms.Button All;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Search;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btnadd;
    }
}