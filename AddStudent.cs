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
using System.Security.Claims;

namespace student
{
    public partial class AddStudent : Form
    {
        
        public AddStudent()
        {
            InitializeComponent();
        }
       
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            

            try
            {
                int classtemp = int.Parse(classtxt.Text);

                if (classtemp > 0 && classtemp < 13)
                {
                   // write
                    if (!(classtxt.Text.Equals("")))
                    {
                        

                        if (classtemp > 0 && classtemp < 5)
                        {
                            //idtxt.Text= idtxt.Text.Insert(0, "H1");
                            idtxt.Text = "H1";
                        }
                        else if (classtemp > 4 && classtemp < 9)
                        {
                           // idtxt.Text = idtxt.Text.Insert(0, "D1");
                            idtxt.Text = "D1";
                        }
                        else if (classtemp > 8 && classtemp < 13)
                        {
                            // idtxt.Text = idtxt.Text.Insert(0, "S1");
                            idtxt.Text = "S1";
                        }
                        else
                        {
                            idtxt.Clear();
                            //idtxt.Text = id;
                        }
                        
                    }
                    if (classtxt.Text.Equals(""))
                        idtxt.Clear();

                }//class
                

                else
                {
                    MessageBox.Show("Class is invalid");
                    idtxt.Clear();
                    
                }
               

            }
            catch (FormatException ex)
            {
                Console.WriteLine("no");
            }


        }


        private void btnadd_Click(object sender, EventArgs e)
        {
            
            if (idtxt.Text.Equals("") && nametxt.Text.Equals("") && telltxt.Text.Equals("") && resTelltxt.Text.Equals("") && addresstxt.Text.Equals("") && DOBtext.Text.Equals("") && Addmisintext.Text.Equals("") && sextxt.Text.Equals("") && classtxt.Text.Equals(""))
            {
                MessageBox.Show("Please all");
            }

            else
            {
                String id = idtxt.Text;
                int classtemp = int.Parse(classtxt.Text);



                int temp = int.Parse(Addmisintext.Text);
                int year = temp % 100;
                String idtemp = idtxt.Text;

                



                if (classtemp == 1 || classtemp == 9 || classtemp == 5)
                    idtemp = idtemp.Insert(2, "" + year + "");

                else if (classtemp == 2 || classtemp == 6 || classtemp == 10)
                    idtemp = idtemp.Insert(2, "" + (year - 1) + "");

                else if (classtemp == 3 || classtemp == 7 || classtemp == 11)
                    idtemp = idtemp.Insert(2, "" + (year - 2) + "");

                else if (classtemp == 4 || classtemp == 8 || classtemp == 12)
                    idtemp = idtemp.Insert(2, "" + (year - 3) + "");



                //h1 d1 s1

                //if (classtemp > 0 && classtemp < 5)
                //{
                //    idtemp = idtemp.Insert(0, "H1");
                //}
                //else if (classtemp > 4 && classtemp < 9)
                //{
                //    idtemp = idtemp.Insert(0, "D1");
                //}
                //else if (classtemp > 8 && classtemp < 13)
                //{
                //    idtemp = idtemp.Insert(0, "S1");
                //}





                try
                {
                    using (SqlConnection con = ConnectionClass.connect())
                    {
                        //String joindate = "8/"+Addmisintext.Text;
                        SqlCommand cmd = new SqlCommand("insert into student values('" + idtemp.ToUpper() + "','" + nametxt.Text.ToUpper() + "' , '" + momtxt.Text.ToUpper() + "' , '" + telltxt.Text + "','" + resTelltxt.Text + "' , '" + addresstxt.Text.ToUpper() + "' , '" + DOBtext.Text + "' , '" + Addmisintext.Text + "' , '" + sextxt.Text.ToUpper() + "' , '" + classtxt.Text + "')", con);
                        cmd.ExecuteNonQuery();
                        SqlCommand cmd1 = new SqlCommand("insert into newstudent values('" + idtemp.ToUpper() + "','" + nametxt.Text.ToUpper() + "' , '" + momtxt.Text.ToUpper() + "' , '" + telltxt.Text + "','" + resTelltxt.Text + "' , '" + addresstxt.Text.ToUpper() + "' , '" + DOBtext.Text + "' , '" + Addmisintext.Text + "' , '" + sextxt.Text.ToUpper() + "' , '" + classtxt.Text + "')", con);
                        cmd1.ExecuteNonQuery();
                        MessageBox.Show("Data Saved Success");

                        nametxt.Clear();
                        idtxt.Clear();
                        momtxt.Clear();
                        telltxt.Clear();
                        resTelltxt.Clear();
                        addresstxt.Clear();
                        DOBtext.Clear();
                        Addmisintext.Clear();
                        classtxt.Clear();
                        sextxt.Clear();
                        nametxt.Focus();

                        MessageBox.Show("Please Add the student into the RegSFee");
                        MessageBox.Show("Search his ID or Tell And RegSFee");

                    }//using

                    
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
                }

            }

            
        }//btn

        private void AddStudent_Load(object sender, EventArgs e)
        {
            nametxt.Focus();
            Addmisintext.Enabled = false;
            Addmisintext.Text = "2023";

            allstudent all= new allstudent();
        }

        private void nametxt_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void idtxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
