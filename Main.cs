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
    public partial class Main : Form

    {
        private string[] profileDetails;
        public Main(string[] profileDetails)
        {
            InitializeComponent();
            this.profileDetails = profileDetails;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            string imagePath = this.profileDetails[5];
            if (File.Exists(imagePath))
            {
                profilepicturebox.Image = Image.FromFile(imagePath);

            }
            else
            {
                MessageBox.Show("No Image Found ");
            };
            Name.Text = $"{this.profileDetails[1]} {this.profileDetails[2]}";
            email.Text = this.profileDetails[3];

        }

        private void Name_Click(object sender, EventArgs e)
        {

        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            this.Close();
            Login lf = new Login();
            lf.Close();

        }
    }
}
