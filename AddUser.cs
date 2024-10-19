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
    public partial class AddUser : Form
    {
        public AddUser()
        {
            InitializeComponent();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            try
            {

                using (SqlConnection con = ConnectionClass.connect())
                {
                    SqlCommand cmd = new SqlCommand("insert into dominator values('" + usernametxt.Text + "' , '" + passtxt.Text + "' , '" + Titletxt.Text + "')", con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Welcome");


                    usernametxt.Clear();
                    passtxt.Clear();
                    Titletxt.Clear();
                    usernametxt.Focus();
                }


            }//try

            catch (SqlException ex)
            {
                foreach (SqlError error in ex.Errors)
                {
                    if (error.Number == 2627 || error.Number == 2601)
                    {
                        // Unique key violation
                        MessageBox.Show("username and password are unique");
                        // You might want to log the error, display a user-friendly message, or take other actions.
                    }
                    else
                    {
                        // Handle other SQL exceptions or rethrow the exception
                        MessageBox.Show("SQL Error: " + error.Message);
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle other non-SQL exceptions
                MessageBox.Show("An error occurred: " + ex.Message);
            }


        }
    }
}
