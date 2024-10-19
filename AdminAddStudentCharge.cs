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
    public partial class AdminAddStudentCharge : Form
    {
        public AdminAddStudentCharge()
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
                           charging charge = new charging();
                           charge.ShowDialog();
                           usertxt.Clear();
                           passwordtxt.Clear();
                           break;
                       }
                       else
                       {
                           MessageBox.Show("Sorry I cant help you");
                       }
                       
                   }
               }
              
                

            }

           
        }

        private void AdminAddStudentCharge_Load(object sender, EventArgs e)
        {
            using (SqlConnection con = ConnectionClass.connect())
            {

                SqlCommand cmd1 = new SqlCommand("select * from chargingStudent", con);
                SqlDataReader reader1 = cmd1.ExecuteReader();
                if (reader1.HasRows)
                {
                    while (reader1.Read())
                    {
                        String lcdtemp = reader1.GetString(reader1.GetOrdinal("lcd"));
                        lcd.Text = lcdtemp;
                        lcd.Enabled = false;
                    }
                }
            }
        }
    }
}
