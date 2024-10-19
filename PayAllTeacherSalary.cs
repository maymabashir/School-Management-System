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
    public partial class PayAllTeacherSalary : Form
    {
        int amount ;
         
        public PayAllTeacherSalary()
        {
            InitializeComponent();
        }

        private void paidbtn_Click(object sender, EventArgs e)
        {
            if (amount != 0)
            {
                using (SqlConnection con = ConnectionClass.connect())
                {
                    SqlCommand cmd = new SqlCommand("update teacher set amount=(amount-amount), month=(month-month) , lbt='"+lbdtxt.Text+"'",con);
                    SqlCommand cmd1 = new SqlCommand("update PayTeacherSalary set lpd='"+lbdtxt.Text+"'",con);
                    cmd.ExecuteNonQuery();
                    cmd1.ExecuteNonQuery();
                    MessageBox.Show("teachers salary paid");
                    lbdtxt.Enabled = false;
                    paidbtn.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("All salary are paid Sir");
                lbdtxt.Enabled = false;
                paidbtn.Enabled = false;
            }
                       
        }

        private void PayAllTeacherSalary_Load(object sender, EventArgs e)
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
                       amount = reader1.GetInt32(reader1.GetOrdinal("amount"));
                       break;

                    }
                }
            }//using

            
        }
    }
}
