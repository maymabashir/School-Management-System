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
    public partial class AddTeacher : Form
    {
        public AddTeacher()
        {
            InitializeComponent();
        }

        private void momtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddTeacher_Load(object sender, EventArgs e)
        {
            subtxt.Enabled = false;
            certxt.Enabled = false;
            salarytxt.Enabled = false;
        }

        private void cercombobx_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            object temp =  cercombobx.SelectedItem;
            certxt.Text = temp.ToString();

            if(temp.ToString().Equals("MASTER")){
                salarytxt.Text = "1000";
            }
            else if (temp.ToString().Equals("PHD"))
            {
                salarytxt.Text = "2000";
            }
            else if (temp.ToString().Equals("BACHELOR"))
            {
                salarytxt.Text = "600";
            }
            else if (temp.ToString().Equals("DIPLOMA"))
            {
                salarytxt.Text = "300";
            }
            else
            {
                MessageBox.Show("Please choose certificate");
            }
        }

        private void sub1combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            object temp = sub1combobox.SelectedItem;
            subtxt.Text = temp.ToString();
            
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = ConnectionClass.connect())
                {
                    float salary = float.Parse(salarytxt.Text);
                    //String joindate = "8/"+Addmisintext.Text;
                    SqlCommand cmd = new SqlCommand("insert into teacher values('" + nametxt.Text.ToUpper() + "' , '" + telltxt.Text + "' , '" + emailtxt.Text.ToUpper() + "' , '" + addresstxt.Text.ToUpper() + "'  ,  " + salary + " , 0 , 0 , 0 , '" + certxt.Text.ToUpper() + "'  ,' " + subtxt.Text.ToUpper() + "' , '" + sextxt.Text.ToUpper() + "' , null)", con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Teacher Success");
                    clear();
                }
            }
            catch (SqlException ex)
            {
                foreach (SqlError error in ex.Errors)
                {
                    if (error.Number == 2627 || error.Number == 2601)
                    {
                        // Unique key violation
                        MessageBox.Show("Tell and email are unique");
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
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }

        private void clear()
        {
            nametxt.Clear();
            sextxt.Clear();
            telltxt.Clear();
            emailtxt.Clear();
            subtxt.Clear();
            certxt.Clear();
            addresstxt.Clear();
            sextxt.Clear();
            salarytxt.Clear();
        }
    }
}
