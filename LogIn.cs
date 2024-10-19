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
    public partial class LogIn : Form
    {
        public static String title;
        public LogIn()
        {
            InitializeComponent();
        }

        private void LogIn_Load(object sender, EventArgs e)
        {
               
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void passwordtxt_TextChanged(object sender, EventArgs e)
        {
            passwordtxt.UseSystemPasswordChar = true; 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Boolean found = false;
            using (SqlConnection con = ConnectionClass.connect())
            {
                SqlCommand cmd = new SqlCommand("select * from dominator", con);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        String user = reader.GetString(reader.GetOrdinal("username"));
                        String pass = reader.GetString(reader.GetOrdinal("password"));
                        title = reader.GetString(reader.GetOrdinal("title"));



                        if (user.ToUpper().Equals(usertxt.Text.ToUpper()) && pass.ToUpper().Equals(passwordtxt.Text.ToUpper()))
                        {

                            found = true;
                            Home charge = new Home();
                            usertxt.Clear();
                            passwordtxt.Clear();
                            charge.ShowDialog();
                            break;
                        }
                        


                    }//while
                }//if
                if (found == false)
                {
                    MessageBox.Show("Sorry I cant help you");
                }
            }//using
        }
    }
}
