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
    public partial class AddPrivateTeacherBonus : Form
    {
        public AddPrivateTeacherBonus()
        {
            InitializeComponent();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = ConnectionClass.connect())
            {
                int bonus=int.Parse(bonustxt.Text);
                SqlCommand cmd = new SqlCommand("update teacher set bonus=(bonus+'"+bonus+"') where tell='"+telltxt.Text+"'", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("bonus added Saved");
                bonustxt.Enabled = false;
                btnadd.Enabled = false;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AddPrivateTeacherBonus_Load(object sender, EventArgs e)
        {

        }
    }
}
