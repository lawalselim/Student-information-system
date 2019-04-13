using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Student_Application
{
    public partial class Student_Information_Application : Form
    {
        public Student_Information_Application()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Student_Information_Application_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

            Login_Page f = new Login_Page();
            f.Show();
        }

        private void btnadmin_Click(object sender, EventArgs e)
        {
            Admin f = new Admin();
            f.Show();
        }

        private void btnregstd_Click(object sender, EventArgs e)
        {
            Register_New_Student f = new Register_New_Student();
            f.Show();
        }
    }
}
