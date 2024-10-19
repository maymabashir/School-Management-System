namespace student
{
    partial class PayAllTeacherSalary
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
            this.lbdtxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.paidbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbdtxt
            // 
            this.lbdtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbdtxt.Location = new System.Drawing.Point(131, 81);
            this.lbdtxt.Multiline = true;
            this.lbdtxt.Name = "lbdtxt";
            this.lbdtxt.Size = new System.Drawing.Size(185, 32);
            this.lbdtxt.TabIndex = 60;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(163)))));
            this.label2.Location = new System.Drawing.Point(16, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 19);
            this.label2.TabIndex = 59;
            this.label2.Text = "LastPaidDate";
            // 
            // paidbtn
            // 
            this.paidbtn.BackColor = System.Drawing.Color.SteelBlue;
            this.paidbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.paidbtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paidbtn.ForeColor = System.Drawing.Color.White;
            this.paidbtn.Location = new System.Drawing.Point(87, 153);
            this.paidbtn.Name = "paidbtn";
            this.paidbtn.Size = new System.Drawing.Size(200, 52);
            this.paidbtn.TabIndex = 61;
            this.paidbtn.Text = "Paid";
            this.paidbtn.UseVisualStyleBackColor = false;
            this.paidbtn.Click += new System.EventHandler(this.paidbtn_Click);
            // 
            // PayAllTeacherSalary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 261);
            this.Controls.Add(this.paidbtn);
            this.Controls.Add(this.lbdtxt);
            this.Controls.Add(this.label2);
            this.Name = "PayAllTeacherSalary";
            this.Text = "PayAllTeacherSalary";
            this.Load += new System.EventHandler(this.PayAllTeacherSalary_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox lbdtxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button paidbtn;

    }
}