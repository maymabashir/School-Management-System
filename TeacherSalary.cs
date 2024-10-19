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
    public partial class TeacherSalary : Form
    {
        public TeacherSalary()
        {
            InitializeComponent();
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

        private void TeacherSalary_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            Display();
        }

        public void Display()
        {
            using (SqlConnection con = ConnectionClass.connect())
            {
                SqlDataAdapter da = new SqlDataAdapter("select name, tell,salary,month,amount,bonus,certificate,sex,lbt from teacher", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                tableData.DataSource = dt;

            }
        }

        private void All_Click(object sender, EventArgs e)
        {
            Display();
        }
    }
}
