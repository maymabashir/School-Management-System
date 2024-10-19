using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace student
{
    public partial class AddTeacherCharging : Form
    {
        public AddTeacherCharging()
        {
            InitializeComponent();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = ConnectionClass.connect())
            {
                if (bonustxt.Text.Equals("") && radioButton1.Checked)
                {
                    SqlCommand cmd = new SqlCommand("update teacher set month=(month+1), amount=(amount+salary) ", con);
                    SqlCommand cmd3 = new SqlCommand("update chargingTeacher set lcd='" + lcdtxt.Text + "'", con);

                    cmd.ExecuteNonQuery();
                    cmd3.ExecuteNonQuery();
                    MessageBox.Show("month added Saved");
                    btnadd.Enabled = false;
                }//if

                else if ((!bonustxt.Text.Equals("")) && radioButton1.Checked)
                {
                    int bonus = int.Parse(bonustxt.Text);
                    SqlCommand cmd = new SqlCommand("update teacher set month=(month+1), amount=(amount+salary), bonus=(bonus+" + bonus + ") ", con);
                    SqlCommand cmd3 = new SqlCommand("update chargingTeacher set lcd='" + lcdtxt.Text + "'", con);

                    cmd.ExecuteNonQuery();
                    cmd3.ExecuteNonQuery();
                    MessageBox.Show("month and bonus added Saved");
                    btnadd.Enabled = false;
                }//else if

                else if ((!bonustxt.Text.Equals("")) && (!radioButton1.Checked))
                {
                    int bonus = int.Parse(bonustxt.Text);
                    SqlCommand cmd2 = new SqlCommand("update teacher set bonus=(bonus+" + bonus + ") ", con);
                    SqlCommand cmd3 = new SqlCommand("update chargingTeacher set lcd='" + lcdtxt.Text + "'", con);


                    cmd3.ExecuteNonQuery();
                    cmd2.ExecuteNonQuery();
                    MessageBox.Show("Data Update Saved");
                    btnadd.Enabled = false;
                }
                
            }//using 
        }

        private void AddTeacherCharging_Load(object sender, EventArgs e)
        {

        }
    }
}
