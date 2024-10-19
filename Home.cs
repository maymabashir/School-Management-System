using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace student
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Melson_Load(object sender, EventArgs e)
        {
            //pictureBox9.Visible = false;
            //pictureBox2.Visible = false;
            //pictureBox3.Visible = false;
            //pictureBox4.Visible = false;
            //pictureBox5.Visible = false;
            //pictureBox7.Visible = false;
            //pictureBox8.Visible = false;

            user.Text = LogIn.title;
            this.WindowState = FormWindowState.Normal;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            StudentFee fee = new StudentFee();
            fee.ShowDialog();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            TeacherSalary salary = new TeacherSalary();
            salary.ShowDialog();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            allstudent all = new allstudent();
            all.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Admission add = new Admission();
            add.ShowDialog();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Teacher t = new Teacher();
            t.ShowDialog();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Users u = new Users();
            u.ShowDialog();
        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            pictureBox2.BackColor = Color.Transparent;
            pictureBox1.Visible = false;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.BackColor = Color.LightBlue;
            pictureBox1.Visible = false;
        }

        private void pictureBox2_MouseEnter_1(object sender, EventArgs e)
        {
            pictureBox2.BackColor = Color.LightCyan;
        }

        private void pictureBox2_MouseLeave_1(object sender, EventArgs e)
        {
            pictureBox2.BackColor = Color.Transparent;
        }

        private void pictureBox5_MouseEnter(object sender, EventArgs e)
        {
            pictureBox5.BackColor = Color.LightCyan;
        }

        private void pictureBox5_MouseLeave(object sender, EventArgs e)
        {
            pictureBox5.BackColor = Color.Transparent;
        }

        private void pictureBox3_MouseEnter(object sender, EventArgs e)
        {
            pictureBox3.BackColor = Color.LightCyan;
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.BackColor = Color.Transparent;
        }

        private void pictureBox4_MouseEnter(object sender, EventArgs e)
        {
            pictureBox4.BackColor = Color.LightCyan;
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            pictureBox4.BackColor = Color.Transparent;
        }

        private void pictureBox7_MouseEnter(object sender, EventArgs e)
        {
            pictureBox7.BackColor = Color.LightCyan;
        }

        private void pictureBox7_MouseLeave(object sender, EventArgs e)
        {
            pictureBox7.BackColor = Color.Transparent;
        }

        private void pictureBox8_MouseEnter(object sender, EventArgs e)
        {
            pictureBox8.BackColor = Color.LightCyan;
        }

        private void pictureBox8_MouseLeave(object sender, EventArgs e)
        {
            pictureBox8.BackColor = Color.Transparent;
        }

        private void pictureBox9_MouseEnter(object sender, EventArgs e)
        {
            pictureBox9.BackColor = Color.LightCyan;
        }

        private void pictureBox9_MouseLeave(object sender, EventArgs e)
        {
            pictureBox9.BackColor = Color.Transparent;
        }

        private void user_Click(object sender, EventArgs e)
        {

        }

        private void label2_MouseEnter(object sender, EventArgs e)
        {
            label2.BackColor = Color.LightGray;
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            label2.BackColor = Color.MidnightBlue;
        }

        private void label2_MouseDown(object sender, MouseEventArgs e)
        {
            label2.BackColor = Color.LightGray;
            pictureBox9.Visible = true;
            pictureBox2.Visible = true;
            pictureBox3.Visible = true;
            pictureBox4.Visible = true;
            pictureBox5.Visible = true;
            pictureBox7.Visible = true;
            pictureBox8.Visible = true;
        }

        private void label3_MouseEnter(object sender, EventArgs e)
        {
            label3.BackColor = Color.LightGray;
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            label3.BackColor = Color.MidnightBlue;
        }

        private void label3_MouseDown(object sender, MouseEventArgs e)
        {
            label3.BackColor = Color.LightGray;
            pictureBox5.Visible = true;
            pictureBox3.Visible = true;
            pictureBox2.Visible = true;

            pictureBox9.Visible = false;
            pictureBox7.Visible = false;
            pictureBox8.Visible = false;
            pictureBox4.Visible = false;
        }

        private void user_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void label7_MouseEnter(object sender, EventArgs e)
        {
            label7.BackColor = Color.LightGray;
        }

        private void label7_MouseLeave(object sender, EventArgs e)
        {
            label7.BackColor = Color.MidnightBlue;
        }

        private void label7_MouseDown(object sender, MouseEventArgs e)
        {
            label7.BackColor = Color.LightGray;
            this.Close();
        }

        private void label5_MouseEnter(object sender, EventArgs e)
        {
            label5.BackColor = Color.LightGray;
        }

        private void label5_MouseLeave(object sender, EventArgs e)
        {
            label5.BackColor = Color.MidnightBlue;
        }

        private void label5_MouseDown(object sender, MouseEventArgs e)
        {
            label5.BackColor = Color.LightGray;
            Users user = new Users();
            user.ShowDialog();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox9_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox9.BackColor = Color.LightGray;
            GeneralReport general = new GeneralReport();
            general.ShowDialog();
        }

        private void label6_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void label6_MouseLeave(object sender, EventArgs e)
        {
        }

        private void label6_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label9_MouseEnter(object sender, EventArgs e)
        {
            label9.BackColor = Color.LightGray;
        }

        private void label9_MouseLeave(object sender, EventArgs e)
        {
            label9.BackColor = Color.MidnightBlue;
        }

        private void label9_MouseDown(object sender, MouseEventArgs e)
        {
            GeneralReport report = new GeneralReport();
            report.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {

        }
    }
}
