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
    public partial class StudentFee : Form
    {
        public StudentFee()
        {
            InitializeComponent();
        }

        private void StudentSalary_Load(object sender, EventArgs e)
        {
            Display();
        }

        public void Display()
        {
            using (SqlConnection con = ConnectionClass.connect())
            {
                //SqlDataAdapter da = new SqlDataAdapter("select * from student_salary", con);
                SqlDataAdapter da = new SqlDataAdapter("select student.Name, student.tell, student.ResTell ,student.class, student_salary.* from student_salary inner join student on student_salary.ID=student.id",con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                tableData.DataSource = dt;

            }
        }

        private void Search_TextChanged(object sender, EventArgs e)
        {
            object temp = searchComboBox.SelectedItem;

            if (temp == null)
            {
                MessageBox.Show("please choose the way you want to search");
            }
            else
            {

               

                using (SqlConnection con = ConnectionClass.connect())
                {
                    SqlDataAdapter da = new SqlDataAdapter("select student.Name, student.tell, student.ResTell , student_salary.* from student_salary inner join student on student_salary.ID=student.id where " + temp.ToString() + " like '%" + Search.Text + "%'", con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    tableData.DataSource = dt;

                }
            }
        }

        private void All_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            Display();
            Search.Clear();
        }

        private void btnSare_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = ConnectionClass.connect())
            {
                //SqlDataAdapter da = new SqlDataAdapter("select * from student where class>8 and class<13", con);
                SqlDataAdapter da = new SqlDataAdapter("select student.Name, student.tell, student.ResTell , student.class, student_salary.* from student_salary inner join student on student_salary.ID=student.id where class>8 and class<13", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                tableData.DataSource = dt;
            }
        }

        private void btnDhexe_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = ConnectionClass.connect())
            {
                //SqlDataAdapter da = new SqlDataAdapter("select * from student where class>4 and class<9", con);
                SqlDataAdapter da = new SqlDataAdapter("select student.Name, student.tell, student.ResTell ,student.class, student_salary.* from student_salary inner join student on student_salary.ID=student.id where class>4 and class<9", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                tableData.DataSource = dt;
            }
        }

        private void btnHoose_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = ConnectionClass.connect())
            {
                //SqlDataAdapter da = new SqlDataAdapter("select * from student where class>0 and class<5", con);
                SqlDataAdapter da = new SqlDataAdapter("select student.Name, student.tell, student.ResTell , student.class, student_salary.* from student_salary inner join student on student_salary.ID=student.id where class>0 and class<5", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                tableData.DataSource = dt;
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            StudentPaidFee update = new StudentPaidFee();


            update.nametxt.Text = tableData.CurrentRow.Cells[0].Value.ToString();
            update.classtxt.Text = tableData.CurrentRow.Cells[3].Value.ToString();
            update.idtxt.Text = tableData.CurrentRow.Cells[4].Value.ToString();
            update.feetxt.Text = tableData.CurrentRow.Cells[5].Value.ToString();
            update.amountxt.Text = tableData.CurrentRow.Cells[7].Value.ToString();
            update.monthtxt.Text = tableData.CurrentRow.Cells[6].Value.ToString();
            update.otherchargetxt.Text = tableData.CurrentRow.Cells[8].Value.ToString();

            update.nametxt.Enabled = false;
            update.idtxt.Enabled = false;
            update.classtxt.Enabled = false;
            update.feetxt.Enabled = false;
            update.amountxt.Enabled = false;
            update.monthtxt.Enabled = false;
            update.otherchargetxt.Enabled = false;

            int amount=int.Parse(update.amountxt.Text);
            int other = int.Parse(update.otherchargetxt.Text);

            if (amount == 0)
            {
                update.paidAmounttxt.Enabled = false;
                update.paidmonthtxt.Enabled = false;
                update.sendertelltxt.Enabled = false;
                update.typeofmtxt.Enabled = false;
                //update.paidotherchargetxt.Enabled = false;
                update.lbt.Enabled = false;
            }


            if (other == 0)
            {
                //update.otherchargetxt.Enabled = false;
                update.paidotherchargetxt.Enabled = false;
            }




            update.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          

           

            try
            {

                String idtxt = tableData.CurrentRow.Cells[0].Value.ToString();
                int classtemp = int.Parse(tableData.CurrentRow.Cells[9].Value.ToString());

                if (classtemp > 0 && classtemp < 5)
                {
                    using (SqlConnection con = ConnectionClass.connect())
                    {
                        SqlCommand cmd1 = new SqlCommand("insert into student_salary values('" + idtxt.ToUpper() + "',15,0,0,0,null,null,null )", con);
                        cmd1.ExecuteNonQuery();
                        MessageBox.Show("Fee Table success");
                    }//
                }


                else if (classtemp > 4 && classtemp < 9)
                {
                    using (SqlConnection con = ConnectionClass.connect())
                    {
                        SqlCommand cmd2 = new SqlCommand("insert into student_salary values('" + idtxt.ToUpper() + "',17,0,0,0,null,null,null )", con);
                        cmd2.ExecuteNonQuery();
                        MessageBox.Show("Fee Table success");
                    }
                }


                else if (classtemp > 8 && classtemp < 13)
                {
                    using (SqlConnection con = ConnectionClass.connect())
                    {
                        SqlCommand cmd3 = new SqlCommand("insert into student_salary values('" + idtxt.ToUpper() + "',20,0,0,0,null,null,null )", con);
                        cmd3.ExecuteNonQuery();
                        MessageBox.Show("Fee Table success");
                    }
                }//else


                //delete
                using (SqlConnection con = ConnectionClass.connect())
                {
                    SqlCommand cmd = new SqlCommand("delete from newstudent where id='" + idtxt + "'", con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data updated");
                }

            }
            catch (SqlException ex)
            {
                foreach (SqlError error in ex.Errors)
                {
                    if (error.Number == 2627 || error.Number == 2601)
                    {
                        // Unique key violation
                        MessageBox.Show("Sorry Student Registered Before");
                        // You might want to log the error, display a user-friendly message, or take other actions.
                    }
                    else
                    {
                        // Handle other SQL exceptions or rethrow the exception
                        Console.WriteLine("SQL Error: " + error.Message);
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle other non-SQL exceptions
                MessageBox.Show("An error occurred: " + ex.Message);
            }


           

        }//button

        private void button3_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            using (SqlConnection con = ConnectionClass.connect())
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from newstudent", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                tableData.DataSource = dt;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String id = tableData.CurrentRow.Cells[4].Value.ToString();
            MessageBox.Show(id.ToString());
            using (SqlConnection con = ConnectionClass.connect())
            {
                SqlCommand cmd1 = new SqlCommand("delete from student_salary where id='" + id + "'", con);
                cmd1.ExecuteNonQuery();
                MessageBox.Show("Student fee Data deleted success");
                Display();

            }
        }

        private void btnadd_Click(object sender, EventArgs e)
        {

            AdminAddStudentCharge charging = new AdminAddStudentCharge();
            charging.ShowDialog();
        }
    }
}
