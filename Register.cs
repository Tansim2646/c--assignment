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
    public partial class Register : Form
    {
        private string imagePath;
        private string fileName;
        public Register()
        {
            InitializeComponent();
            
        }

        private void UploadPhotoButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog op1 = new OpenFileDialog();
            op1.ShowDialog();
            if (op1.FileName != "")
            {
                this.imagePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "images");
                this.fileName = Path.GetFileName(op1.FileName);
                if (!Directory.Exists(imagePath))
                {
                    Directory.CreateDirectory(imagePath);
                }
                File.Copy(op1.FileName, Path.Combine(imagePath, fileName), true);
            }
            else
            {
                MessageBox.Show("No Profile Picture Selected");
            }
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            string firstName = firstNameBox.Text;
            string lastName = lastNameBox.Text;
            string email = emailBox.Text;
            string password = passwordBox.Text;
            string fullPath = Path.Join(this.imagePath, this.fileName);
            DatabaseConnection db = new DatabaseConnection();
            if (db.SearchUserByEmail(email,password))
            {
                MessageBox.Show("Already Registered");
            }
            else
            {
               bool registration = db.RegisterUser(firstName, lastName, email, password,fullPath);
                if (registration)
                {
                    MessageBox.Show("Successfully Registered!");
                }
            }
        }
    }
}
