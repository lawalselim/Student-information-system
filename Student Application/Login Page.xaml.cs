using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Data.SqlClient;
using System.Data;

namespace Student_Application
{
    /// <summary>
    /// Interaction logic for Login_Page.xaml
    /// </summary>
    public partial class Login_Page : Window
    {
        public Login_Page()
        {
            InitializeComponent();
        }


        private void button_Click(object sender, RoutedEventArgs e)
        {
            if (textBox.Text == "" && passwordBox.Password == "")
            {
                MessageBox.Show(" Kindly please enter both username and password.");

            }
            else
            {
                Student_Information_Application f = new Student_Information_Application();
                f.Show();
            }
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            textBox.Clear();

            passwordBox.Clear();
               
        }

    }
}

   

