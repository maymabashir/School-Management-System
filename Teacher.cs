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
    public partial class Teacher : Form
    {
        public Teacher()
        {
            InitializeComponent();
        }

        private void Teacher_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.StartPosition = FormStartPosition.CenterScreen;
            Display();
        }

        public void Display()
        {
            using (SqlConnection con = ConnectionClass.connect())
            {
                SqlDataAdapter da = new SqlDataAdapter("select name, tell ,email,address,salary,certificate,subject,sex from teacher", con);
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
                    SqlDataAdapter da = new SqlDataAdapter("select * from teacher where " + temp.ToString() + " like '%" + Search.Text + "%'", con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    tableData.DataSource = dt;

                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            String name = tableData.CurrentRow.Cells[0].Value.ToString();
            String tell = tableData.CurrentRow.Cells[1].Value.ToString();

                using (SqlConnection con = ConnectionClass.connect())
                {
                    SqlCommand cmd = new SqlCommand("delete from teacher where tell='" + tell + "' and name='" + name + "' ", con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data deleted success");
                }

                Display();
                }
          

        private void btnadd_Click(object sender, EventArgs e)
        {
            AddTeacher teacher = new AddTeacher();
            teacher.ShowDialog();
        }

        private void All_Click(object sender, EventArgs e)
        {
            Display();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            UpdateTeacher update = new UpdateTeacher();

            update.nametxt.Text = tableData.CurrentRow.Cells[0].Value.ToString();
            update.emailtxt.Text = tableData.CurrentRow.Cells[2].Value.ToString();
            update.telltxt.Text = tableData.CurrentRow.Cells[1].Value.ToString();
            update.certxt.Text = tableData.CurrentRow.Cells[5].Value.ToString();
            update.addresstxt.Text = tableData.CurrentRow.Cells[3].Value.ToString();
            update.subtxt.Text = tableData.CurrentRow.Cells[6].Value.ToString();
            update.salarytxt.Text = tableData.CurrentRow.Cells[4].Value.ToString();
            update.sextxt.Text = tableData.CurrentRow.Cells[7].Value.ToString();

            update.ShowDialog();
           

        }

        private void button4_Click(object sender, EventArgs e)
        {
            AdminAddTeacherCharge teacher = new AdminAddTeacherCharge();
            teacher.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminAddPrivateTeacherBonus admin = new AdminAddPrivateTeacherBonus();
            admin.name = tableData.CurrentRow.Cells[0].Value.ToString();
            admin.tell = tableData.CurrentRow.Cells[1].Value.ToString();

            admin.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdminPayTeacherSalary adminpay = new AdminPayTeacherSalary();
            adminpay.ShowDialog();
        }

    }
}
