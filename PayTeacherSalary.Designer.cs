namespace student
{
    partial class PayTeacherSalary
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
            this.All = new System.Windows.Forms.Button();
            this.btnpayallbonus = new System.Windows.Forms.Button();
            this.btnpayspecificsalary = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // All
            // 
            this.All.BackColor = System.Drawing.Color.SteelBlue;
            this.All.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.All.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.All.ForeColor = System.Drawing.Color.White;
            this.All.Location = new System.Drawing.Point(12, 100);
            this.All.Name = "All";
            this.All.Size = new System.Drawing.Size(146, 38);
            this.All.TabIndex = 28;
            this.All.Text = "Pay All Salaries";
            this.All.UseVisualStyleBackColor = false;
            this.All.Click += new System.EventHandler(this.All_Click);
            // 
            // btnpayallbonus
            // 
            this.btnpayallbonus.BackColor = System.Drawing.Color.SteelBlue;
            this.btnpayallbonus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnpayallbonus.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpayallbonus.ForeColor = System.Drawing.Color.White;
            this.btnpayallbonus.Location = new System.Drawing.Point(367, 100);
            this.btnpayallbonus.Name = "btnpayallbonus";
            this.btnpayallbonus.Size = new System.Drawing.Size(148, 38);
            this.btnpayallbonus.TabIndex = 28;
            this.btnpayallbonus.Text = "Pay All Bonus";
            this.btnpayallbonus.UseVisualStyleBackColor = false;
            this.btnpayallbonus.Click += new System.EventHandler(this.btnpayallbonus_Click);
            // 
            // btnpayspecificsalary
            // 
            this.btnpayspecificsalary.BackColor = System.Drawing.Color.SteelBlue;
            this.btnpayspecificsalary.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnpayspecificsalary.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpayspecificsalary.ForeColor = System.Drawing.Color.White;
            this.btnpayspecificsalary.Location = new System.Drawing.Point(175, 100);
            this.btnpayspecificsalary.Name = "btnpayspecificsalary";
            this.btnpayspecificsalary.Size = new System.Drawing.Size(171, 38);
            this.btnpayspecificsalary.TabIndex = 28;
            this.btnpayspecificsalary.Text = "pay Specific Salary";
            this.btnpayspecificsalary.UseVisualStyleBackColor = false;
            this.btnpayspecificsalary.Click += new System.EventHandler(this.btnpayspecificsalary_Click);
            // 
            // PayTeacherSalary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 211);
            this.Controls.Add(this.btnpayspecificsalary);
            this.Controls.Add(this.btnpayallbonus);
            this.Controls.Add(this.All);
            this.Name = "PayTeacherSalary";
            this.Text = "PayTeacherSalary";
            this.Load += new System.EventHandler(this.PayTeacherSalary_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button All;
        public System.Windows.Forms.Button btnpayallbonus;
        public System.Windows.Forms.Button btnpayspecificsalary;

    }
}