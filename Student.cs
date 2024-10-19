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
    public partial class allstudent : Form
    {
        public static String id="";
        //public List<String> telllist = new List<string>();
        public allstudent()
        {
            InitializeComponent();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            AddStudent addstudent = new AddStudent();
            addstudent.ShowDialog();
        }

        private void allstudent_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.StartPosition = FormStartPosition.CenterScreen;
            Display();
            //MessageBox.Show(string.Join(Environment.NewLine, telllist), "Tell List");

        }

        private void btnDhexe_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = ConnectionClass.connect())
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from student where class>4 and class<9", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                tableData.DataSource = dt;
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            UpdateStudent update = new UpdateStudent();


            update.nametxt.Text = tableData.CurrentRow.Cells[1].Value.ToString();
            update.momtxt.Text = tableData.CurrentRow.Cells[2].Value.ToString();
            update.telltxt.Text = tableData.CurrentRow.Cells[3].Value.ToString();
            update.restelltxt.Text = tableData.CurrentRow.Cells[4].Value.ToString();
            update.addresstxt.Text = tableData.CurrentRow.Cells[5].Value.ToString();
            update.DOBtxt.Text = tableData.CurrentRow.Cells[6].Value.ToString();
            update.addmisiontxt.Text = tableData.CurrentRow.Cells[7].Value.ToString();
            update.sextxt.Text = tableData.CurrentRow.Cells[8].Value.ToString();
            update.classtxt.Text = tableData.CurrentRow.Cells[9].Value.ToString();
            update.idtxt.Text = tableData.CurrentRow.Cells[0].Value.ToString();

            update.Show();
        }

        public void Display()
        {
            using (SqlConnection con = ConnectionClass.connect())
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from student", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                tableData.DataSource = dt;

            }
        }

        private void All_Click(object sender, EventArgs e)
        {
            Display();
            Search.Clear();
        }

        private void tableData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void searchComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            object temp = searchComboBox.SelectedItem;

            using (SqlConnection con = ConnectionClass.connect())
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from student where " + temp.ToString() + " = '" + Search.Text + "' ", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                tableData.DataSource = dt;

            }
            Search.Clear();

        }

        private void button3_Click(object sender, EventArgs e)
        {

            String name = tableData.CurrentRow.Cells[1].Value.ToString();
            String restell = tableData.CurrentRow.Cells[4].Value.ToString();

            try
            {
                using (SqlConnection con = ConnectionClass.connect())
                {
                    SqlCommand cmd = new SqlCommand("delete from student where restell='" + restell + "' and name='" + name + "' ", con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data deleted success");
                }

                Display();
            }
            catch (SqlException ex)
            {
                foreach (SqlError error in ex.Errors)
                {
                    if (error.Number == 547)
                    {
                        // Foreign key constraint violation (cannot be deleted)
                        MessageBox.Show("Please first delete StudentFee then you can delete student ");
                        // You might want to log the error, display a user-friendly message, or take other actions.
                    }
                    else
                    {
                        // Handle other SQL exceptions or rethrow the exception
                        Console.WriteLine("SQL Error: " + error.Message);
                    }
                }
            }
        }


        private void btnHoose_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = ConnectionClass.connect())
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from student where class>0 and class<5", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                tableData.DataSource = dt;
            }
        }

        private void btnSare_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = ConnectionClass.connect())
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from student where class>8 and class<13", con);
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
            else{
             using (SqlConnection con = ConnectionClass.connect())
             {
                SqlDataAdapter da = new SqlDataAdapter("select * from student where " + temp.ToString() + " like '%"+Search.Text+"%'", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                tableData.DataSource = dt;

             }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            



        }

        private void button2_Click(object sender, EventArgs e)
        {
           

        }
    }
}
