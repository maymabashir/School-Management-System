using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace student
{
    public partial class charging : Form
    {
        public charging()
        {
            InitializeComponent();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = ConnectionClass.connect())
            {
                if (otherchargetxt.Text.Equals("") && radioButton1.Checked)
                {
                    SqlCommand cmd = new SqlCommand("update student_salary set month=(month+1), charge=(charge+20) where id like 'S%'", con);
                    SqlCommand cmd1 = new SqlCommand("update student_salary set month=(month+1), charge=(charge+17) where id like 'D%'", con);
                    SqlCommand cmd2 = new SqlCommand("update student_salary set month=(month+1), charge=(charge+15) where id like 'H%'", con);
                    SqlCommand cmd3 = new SqlCommand("update chargingStudent set lcd='" + lcdtxt.Text + "'", con);

                    cmd.ExecuteNonQuery();
                    cmd1.ExecuteNonQuery();
                    cmd2.ExecuteNonQuery();
                    cmd3.ExecuteNonQuery();
                    MessageBox.Show("Data Update Saved");
                    btnadd.Enabled = false;
                }
                else if ((!otherchargetxt.Text.Equals("")) && radioButton1.Checked)
                {
                    int other = int.Parse(otherchargetxt.Text);
                    SqlCommand cmd = new SqlCommand("update student_salary set month=(month+1), charge=(charge+20),othercharge=(othercharge+" + other + ") where id like 'S%'", con);
                    SqlCommand cmd1 = new SqlCommand("update student_salary set month=(month+1), charge=(charge+17),othercharge=(othercharge+" + other + ") where id like 'D%'", con);
                    SqlCommand cmd2 = new SqlCommand("update student_salary set month=(month+1), charge=(charge+15),othercharge=(othercharge+" + other + ") where id like 'H%'", con);
                    SqlCommand cmd3 = new SqlCommand("update chargingStudent set lcd='" + lcdtxt.Text + "'", con);

                    cmd.ExecuteNonQuery();
                    cmd1.ExecuteNonQuery();
                    cmd2.ExecuteNonQuery();
                    cmd3.ExecuteNonQuery();
                    MessageBox.Show("Data Update Saved");
                    btnadd.Enabled = false;
                }
                else if ((!otherchargetxt.Text.Equals("")) && (!radioButton1.Checked))
                {
                    int other = int.Parse(otherchargetxt.Text);
                    SqlCommand cmd2 = new SqlCommand("update student_salary set othercharge=(othercharge+" + other + ") ", con);
                    SqlCommand cmd3 = new SqlCommand("update chargingStudent set lcd='" + lcdtxt.Text + "'", con);

                   
                    cmd3.ExecuteNonQuery();
                    cmd2.ExecuteNonQuery();
                    MessageBox.Show("Data Update Saved");
                    btnadd.Enabled = false;
                }
                
            }
        }

        private void charging_Load(object sender, EventArgs e)
        {

        }
    }
}
