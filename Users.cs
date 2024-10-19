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
    public partial class Users : Form
    {
        public Users()
        {
            InitializeComponent();
        }

        private void Users_Load(object sender, EventArgs e)
        {
            Display();
        }

        public void Display()
        {
            using (SqlConnection con = ConnectionClass.connect())
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from dominator", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                tableData.DataSource = dt;

            }
        }

        private void All_Click(object sender, EventArgs e)
        {
            Display();
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
                    SqlDataAdapter da = new SqlDataAdapter("select * from dominator where " + temp.ToString() + " like '%" + Search.Text + "%'", con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    tableData.DataSource = dt;

                }
            }


        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            Update_Users update = new Update_Users();

            update.usernametxt.Text = tableData.CurrentRow.Cells[0].Value.ToString();
            update.Titletxt.Text = tableData.CurrentRow.Cells[2].Value.ToString();
            update.passtxt.Text = tableData.CurrentRow.Cells[1].Value.ToString();
           
            update.ShowDialog();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            AddUser add = new AddUser();
            add.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            String username = tableData.CurrentRow.Cells[0].Value.ToString();
            String pass = tableData.CurrentRow.Cells[1].Value.ToString();

            using (SqlConnection con = ConnectionClass.connect())
            {
                SqlCommand cmd = new SqlCommand("delete from dominator where username='" + username + "' and password='" + pass + "' ", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data deleted success");
            }

            Display();
        }
    }
}
