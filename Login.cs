using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment_app
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string email = emailBox.Text;
            string password = passwordBox.Text;
            DatabaseConnection conn = new DatabaseConnection();
            String[] user = conn.LoginUser(email, password);
            if (user.Length > 0)
            {
                new Main(user).Show();
            }

        }
    }
}
