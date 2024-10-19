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
    public partial class PayTeacherSalary : Form
    {
        int bonus=0;
        public PayTeacherSalary()
        {
            InitializeComponent();
        }

        private void All_Click(object sender, EventArgs e)
        {
            PayAllTeacherSalary all = new PayAllTeacherSalary();
            all.ShowDialog();
        }

        private void btnpayallbonus_Click(object sender, EventArgs e)
        {

            if (bonus != 0)
            {
                using (SqlConnection con = ConnectionClass.connect())
                {
                    SqlCommand cmd = new SqlCommand("update teacher set bonus=(bonus-bonus)", con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("teachers Bonus paid");
                    btnpayallbonus.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("All Bonus are paid Sir");
                btnpayallbonus.Enabled = false;
            }

        }//btn

        private void PayTeacherSalary_Load(object sender, EventArgs e)
        {
            using (SqlConnection con = ConnectionClass.connect())
            {

                SqlCommand cmd1 = new SqlCommand("select * from teacher", con);
                SqlDataReader reader1 = cmd1.ExecuteReader();
                if (reader1.HasRows)
                {
                    while (reader1.Read())
                    {
                        //amount =int.Parse( reader1.GetString(reader1.GetOrdinal("amount")));
                        bonus+= reader1.GetInt32(reader1.GetOrdinal("bonus"));
                        

                    }
                }
            }//using

        }

        private void btnpayspecificsalary_Click(object sender, EventArgs e)
        {
            PaySpecificTeacherSalary pay = new PaySpecificTeacherSalary();
            pay.ShowDialog();
        }
    }
}
