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
    public partial class AdminAddPrivateTeacherBonus : Form
    {
        public  String name;
        public  String tell;

        public AdminAddPrivateTeacherBonus()
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
                            AddPrivateTeacherBonus charge = new AddPrivateTeacherBonus();
                            charge.nametxt.Text = name;
                            charge.telltxt.Text = tell;
                            charge.nametxt.Enabled = false;
                            charge.telltxt.Enabled = false;
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

        private void AdminAddPrivateTeacherBonus_Load(object sender, EventArgs e)
        {

        }
    }
}
