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
    public partial class Admission : Form
    {
        public Admission()
        {
            InitializeComponent();
        }

        private void Admission_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.StartPosition = FormStartPosition.CenterScreen;
            Display();
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

        private void btnadd_Click(object sender, EventArgs e)
        {
            AddStudent addstudent = new AddStudent();
            addstudent.ShowDialog();
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
                    SqlDataAdapter da = new SqlDataAdapter("select * from student where " + temp.ToString() + " like '%" + Search.Text + "%'", con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    tableData.DataSource = dt;

                }
            }
        }//btn

        private void All_Click(object sender, EventArgs e)
        {
            Display();
            Search.Clear();
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

        private void btnHoose_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = ConnectionClass.connect())
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from student where class>0 and class<5", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                tableData.DataSource = dt;
            }
        }//btn


    }
}
