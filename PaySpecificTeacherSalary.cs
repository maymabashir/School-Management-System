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
    public partial class PaySpecificTeacherSalary : Form
    {
        int amount;
        public PaySpecificTeacherSalary()
        {
            InitializeComponent();
        }

        private void nametxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void telltxt_TextChanged(object sender, EventArgs e)
        {
            using (SqlConnection con = ConnectionClass.connect())
            {

                SqlCommand cmd1 = new SqlCommand("select * from teacher where tell='"+telltxt.Text+"'", con);
                SqlDataReader reader1 = cmd1.ExecuteReader();
                if (reader1.HasRows)
                {
                    while (reader1.Read())
                    {
                        String lcdtemp = reader1.GetString(reader1.GetOrdinal("name"));
                        amount = reader1.GetInt32(reader1.GetOrdinal("amount"));
                        nametxt.Text = lcdtemp;

                    }
                }
            }//using
        }


        private void btnadd_Click(object sender, EventArgs e)
        {

            if (amount != 0)
            {
                using (SqlConnection con = ConnectionClass.connect())
                {
                    SqlCommand cmd = new SqlCommand("update teacher set amount=(amount-amount), month=(month-month) where tell='"+telltxt.Text+"' and name='"+nametxt.Text+"'", con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("teacher salary paid");
                    btnadd.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("Teacher salary are paid Sir");
                btnadd.Enabled = false;
            }
        }

        private void PaySpecificTeacherSalary_Load(object sender, EventArgs e)
        {
            nametxt.Enabled = false;
        }
    }
}
