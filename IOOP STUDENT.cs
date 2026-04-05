using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IOOP
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
 
        {
            string u = txtUsername.Text;
            string p = txtPassword.Text;

            if (u == "student" && p == "123")
            {
                StudentDashboard s = new StudentDashboard();
                s.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Login failed");
            }
        }
    }
    }
}
