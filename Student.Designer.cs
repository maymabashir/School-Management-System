namespace student
{
    partial class allstudent
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
            this.searchComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Search = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.tableData = new System.Windows.Forms.DataGridView();
            this.All = new System.Windows.Forms.Button();
            this.btnSare = new System.Windows.Forms.Button();
            this.btnDhexe = new System.Windows.Forms.Button();
            this.btnHoose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tableData)).BeginInit();
            this.SuspendLayout();
            // 
            // searchComboBox
            // 
            this.searchComboBox.FormattingEnabled = true;
            this.searchComboBox.Items.AddRange(new object[] {
            "Tell",
            "Name",
            "ResTell",
            "ID"});
            this.searchComboBox.Location = new System.Drawing.Point(173, 25);
            this.searchComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.searchComboBox.Name = "searchComboBox";
            this.searchComboBox.Size = new System.Drawing.Size(222, 28);
            this.searchComboBox.TabIndex = 17;
            this.searchComboBox.SelectedIndexChanged += new System.EventHandler(this.searchComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 25);
            this.label1.TabIndex = 15;
            this.label1.Text = "Search By:";
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(417, 25);
            this.Search.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(235, 26);
            this.Search.TabIndex = 14;
            this.Search.TextChanged += new System.EventHandler(this.Search_TextChanged);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.SteelBlue;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(1200, 14);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(300, 80);
            this.button3.TabIndex = 11;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
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
            this.tableData.Size = new System.Drawing.Size(1513, 663);
            this.tableData.TabIndex = 18;
            this.tableData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tableData_CellContentClick);
            // 
            // All
            // 
            this.All.BackColor = System.Drawing.Color.SteelBlue;
            this.All.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.All.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.All.ForeColor = System.Drawing.Color.White;
            this.All.Location = new System.Drawing.Point(917, 132);
            this.All.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.All.Name = "All";
            this.All.Size = new System.Drawing.Size(135, 58);
            this.All.TabIndex = 16;
            this.All.Text = "All";
            this.All.UseVisualStyleBackColor = false;
            this.All.Click += new System.EventHandler(this.All_Click);
            // 
            // btnSare
            // 
            this.btnSare.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSare.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSare.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSare.ForeColor = System.Drawing.Color.White;
            this.btnSare.Location = new System.Drawing.Point(1070, 132);
            this.btnSare.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSare.Name = "btnSare";
            this.btnSare.Size = new System.Drawing.Size(135, 58);
            this.btnSare.TabIndex = 16;
            this.btnSare.Text = "D/Sare";
            this.btnSare.UseVisualStyleBackColor = false;
            this.btnSare.Click += new System.EventHandler(this.btnSare_Click);
            // 
            // btnDhexe
            // 
            this.btnDhexe.BackColor = System.Drawing.Color.SteelBlue;
            this.btnDhexe.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDhexe.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDhexe.ForeColor = System.Drawing.Color.White;
            this.btnDhexe.Location = new System.Drawing.Point(1220, 132);
            this.btnDhexe.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDhexe.Name = "btnDhexe";
            this.btnDhexe.Size = new System.Drawing.Size(135, 58);
            this.btnDhexe.TabIndex = 16;
            this.btnDhexe.Text = "D/Dhexe";
            this.btnDhexe.UseVisualStyleBackColor = false;
            this.btnDhexe.Click += new System.EventHandler(this.btnDhexe_Click);
            // 
            // btnHoose
            // 
            this.btnHoose.BackColor = System.Drawing.Color.SteelBlue;
            this.btnHoose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHoose.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHoose.ForeColor = System.Drawing.Color.White;
            this.btnHoose.Location = new System.Drawing.Point(1372, 132);
            this.btnHoose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnHoose.Name = "btnHoose";
            this.btnHoose.Size = new System.Drawing.Size(135, 58);
            this.btnHoose.TabIndex = 16;
            this.btnHoose.Text = "D/Hoose";
            this.btnHoose.UseVisualStyleBackColor = false;
            this.btnHoose.Click += new System.EventHandler(this.btnHoose_Click);
            // 
            // allstudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1513, 863);
            this.Controls.Add(this.tableData);
            this.Controls.Add(this.searchComboBox);
            this.Controls.Add(this.btnHoose);
            this.Controls.Add(this.btnDhexe);
            this.Controls.Add(this.btnSare);
            this.Controls.Add(this.All);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.button3);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximumSize = new System.Drawing.Size(1535, 919);
            this.Name = "allstudent";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.allstudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tableData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox searchComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Search;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button All;
        private System.Windows.Forms.Button btnSare;
        private System.Windows.Forms.Button btnDhexe;
        private System.Windows.Forms.Button btnHoose;
        public System.Windows.Forms.DataGridView tableData;
    }
}

