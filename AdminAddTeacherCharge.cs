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
    public partial class AdminAddTeacherCharge : Form
    {
        public AdminAddTeacherCharge()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = ConnectionClass.connect())
            {
                SqlCommand cmd = new SqlCommand("select username ,password from dominator", con);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        String user = reader.GetString(reader.GetOrdinal("username"));
                        String pass = reader.GetString(reader.GetOrdinal("password"));



                        if (user.ToUpper().Equals(usertxt.Text.ToUpper()) && pass.ToUpper().Equals(passwordtxt.Text.ToUpper()))
                        {
                            AddTeacherCharging charge = new AddTeacherCharging();
                            usertxt.Clear();
                            passwordtxt.Clear();
                            charge.ShowDialog();
                            break;
                        }
                        else
                        {
                            MessageBox.Show("Sorry I cant help you");
                        }

                    }//while
                }//if
            }//using

        }

        private void AdminAddTeacherCharge_Load(object sender, EventArgs e)
        {
            lcd.Enabled = false;
            using (SqlConnection con = ConnectionClass.connect())
            {

                SqlCommand cmd1 = new SqlCommand("select * from chargingTeacher", con);
                SqlDataReader reader1 = cmd1.ExecuteReader();
                if (reader1.HasRows)
                {
                    while (reader1.Read())
                    {
                        String lcdtemp = reader1.GetString(reader1.GetOrdinal("lcd"));
                        lcd.Text = lcdtemp;
                        
                    }
                }
            }//using
        }
    }
}
