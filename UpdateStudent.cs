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
    public partial class UpdateStudent : Form
    {
        String restell;
        String name;
       
        public UpdateStudent()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
             int classtemp = int.Parse(classtxt.Text);

             if (classtemp > 0 && classtemp < 13)
             {
                 try
                 {

                     using (SqlConnection con = ConnectionClass.connect())
                     {
                         SqlCommand cmd = new SqlCommand("update student set name='" + nametxt.Text.ToUpper() + "' , id='" +idtxt.Text+ "' , mothername='" + momtxt.Text.ToUpper() + "' , tell='" + telltxt.Text + "', restell='" + restelltxt.Text + "' ,  address='" + addresstxt.Text.ToUpper() + "' , dob='" + DOBtxt.Text + "' , join_date='" + addmisiontxt.Text + "' , sex='" + sextxt.Text.ToUpper() + "' , class='" + classtxt.Text + "' where restell='" + restell + "' and name='" + name + "' ", con);
                         cmd.ExecuteNonQuery();
                         MessageBox.Show("Data Update Saved");
                     }

                 }//try
                 catch (SqlException ex)
                 {
                     foreach (SqlError error in ex.Errors)
                     {
                         if (error.Number == 2627 || error.Number == 2601)
                         {
                             // Unique key violation
                             MessageBox.Show("Tell and ID are unique");
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
                 }//catch
            }
            else
                {
                  MessageBox.Show("Class is invalid");
                }
           
           
        }


        private void UpdateStudent_Load(object sender, EventArgs e)
        {
            restell = restelltxt.Text;
            name = nametxt.Text;
            nametxt.Enabled = false;
            //classtxt.Enabled = false;
            //idtxt.Enabled = false;
            restelltxt.Enabled = false;
            label9.Enabled = false;
            telltxt.Enabled = false;
            label2.Enabled = false;
            sextxt.Enabled = false;
            
        }

        private void classtxt_TextChanged(object sender, EventArgs e)
        {

        }

      

    }
}
