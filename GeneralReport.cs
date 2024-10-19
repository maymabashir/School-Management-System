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
    public partial class GeneralReport : Form
    {
        public GeneralReport()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            
            pictureBox1.BackColor = Color.LightGray;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.CornflowerBlue;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox1.BackColor = Color.LightGray;
            using (SqlConnection con = ConnectionClass.connect())
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from SNotPaidfee", con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                Reports fr = new Reports();
                SNTF cr = new SNTF();
                cr.SetDataSource(dt);
                fr.crv.ReportSource = cr;
                fr.ShowDialog();
            }
        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            pictureBox2.BackColor = Color.LightGray;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.BackColor = Color.CornflowerBlue;
        }

        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox2.BackColor = Color.LightGray;
            using (SqlConnection con = ConnectionClass.connect())
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from TNPS", con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                Reports fr = new Reports();
                TNPS cr = new TNPS();
                cr.SetDataSource(dt);
                fr.crv.ReportSource = cr;
                fr.ShowDialog();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
