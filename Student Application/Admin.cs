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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Admin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sISDataSet.Student_Basic_Information' table. You can move, or remove it, as needed.
            this.student_Basic_InformationTableAdapter.Fill(this.sISDataSet.Student_Basic_Information);

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
