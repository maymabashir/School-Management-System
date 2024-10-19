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
    public partial class StudentPaidFee : Form
    {
        public StudentPaidFee()
        {
            InitializeComponent();
        }

        private void classtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnadd_Click(object sender, EventArgs e)
        {

        }

        private void enablefalse()
        {
            paidAmounttxt.Enabled = false;
            paidmonthtxt.Enabled = false;
            otherchargetxt.Enabled = false;
            sendertelltxt.Enabled= false;
            lbt.Enabled = false;
            paidotherchargetxt.Enabled = false;
            typeofmtxt.Enabled = false;
            paidbtn.Enabled = false;
        }

        private void paidbtn_Click(object sender, EventArgs e)
        {
            
            if (paidotherchargetxt.Enabled == false && paidAmounttxt.Enabled==true)
            {
                try
                {
                    int amount = int.Parse(amountxt.Text);
                    int month = int.Parse(monthtxt.Text);
                    int paidmonth = int.Parse(paidmonthtxt.Text);
                    int paidamount = int.Parse(paidAmounttxt.Text);

                    if (paidamount<0 || paidmonth<0 || paidmonth > month || paidamount > amount)
                    {
                        MessageBox.Show("there is wrong amount and month");
                    }

                    else
                    {
                        using (SqlConnection con = ConnectionClass.connect())
                        {
                            SqlCommand cmd = new SqlCommand("update student_salary set charge=(" + (amount - paidamount) + ") , month=(" + (month - paidmonth) + ") , typemoney='" + typeofmtxt.Text.ToUpper() + "', sendertell='" + sendertelltxt.Text + "' ,  lbt='" + lbt.Text + "' where id='" + idtxt.Text + "'", con);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Student Paid month");
                        }
                        enablefalse();
                    }//else paid

                }
                catch (FormatException ex)
                {
                    // Handle the FormatException
                    MessageBox.Show("Empty not allowed" + ex.Message);
                    // You might want to log the error, display a user-friendly message, or take other actions.
                }
                
            }//enable



            else if (paidotherchargetxt.Enabled==true && paidAmounttxt.Enabled == true)
            {
                try
                {
                    int amount = int.Parse(amountxt.Text);
                    int month = int.Parse(monthtxt.Text);
                    int paidmonth = int.Parse(paidmonthtxt.Text);
                    int paidamount = int.Parse(paidAmounttxt.Text);
                    int other = int.Parse(otherchargetxt.Text);
                    int paidother = int.Parse(paidotherchargetxt.Text);

                    if (paidamount < 0 || paidmonth < 0 || paidmonth > month || paidamount > amount || paidother > other || paidother<0)
                    {
                        MessageBox.Show("there is wrong amount or month othercharge");
                    }

                    else
                    {
                        using (SqlConnection con = ConnectionClass.connect())
                        {
                            SqlCommand cmd = new SqlCommand("update student_salary set charge=(" + (amount - paidamount) + ") , month=(" + (month - paidmonth) + ") , othercharge=(" + (other - paidother) + "), typemoney='" + typeofmtxt.Text.ToUpper() + "', sendertell='" + sendertelltxt.Text + "' ,  lbt='" + lbt.Text + "' where id='" + idtxt.Text + "'", con);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Student Paid month and other charge");
                            enablefalse();
                        }
                    }//else paid
                    
                }
                catch (FormatException ex)
                {
                    // Handle the FormatException
                    MessageBox.Show("minus '-' not allowed" + ex.Message);
                    // You might want to log the error, display a user-friendly message, or take other actions.
                }
            }//Enabled


            else if (paidotherchargetxt.Enabled == true && paidAmounttxt.Enabled == false)
            {

                try
                {
                    int other = int.Parse(otherchargetxt.Text);
                    int paidother = int.Parse(paidotherchargetxt.Text);

                    if (paidother < 0 || paidother > other)
                    {
                        MessageBox.Show("there is wrong othercharge");
                    }

                    else
                    {
                        using (SqlConnection con = ConnectionClass.connect())
                        {
                            SqlCommand cmd = new SqlCommand("update student_salary set othercharge=(" + (other - paidother) + ") where id='" + idtxt.Text + "'", con);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Student Paid othercharge");
                        }
                        enablefalse();
                    }//else paid
                }

                catch (FormatException ex)
                {
                    // Handle the FormatException
                    MessageBox.Show("minus '-' not allowed" + ex.Message);
                    // You might want to log the error, display a user-friendly message, or take other actions.
                }
            }//Enabled
        }

        private void StudentPaidFee_Load(object sender, EventArgs e)
        {
            if (paidAmounttxt.Enabled == false && paidotherchargetxt.Enabled == false)
            {
                paidbtn.Enabled = false;
            }

          
           
            
        }
    }
}
