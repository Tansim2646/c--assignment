namespace assignment_app
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            profilepicturebox = new PictureBox();
            Name = new Label();
            email = new Label();
            logoutButton = new Button();
            ((System.ComponentModel.ISupportInitialize)profilepicturebox).BeginInit();
            SuspendLayout();
            // 
            // profilepicturebox
            // 
            profilepicturebox.Location = new Point(45, 107);
            profilepicturebox.Name = "profilepicturebox";
            profilepicturebox.Size = new Size(159, 181);
            profilepicturebox.TabIndex = 0;
            profilepicturebox.TabStop = false;
            // 
            // Name
            // 
            Name.AutoSize = true;
            Name.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            Name.Location = new Point(235, 118);
            Name.Name = "Name";
            Name.Size = new Size(71, 30);
            Name.TabIndex = 1;
            Name.Text = "label1";
            Name.Click += Name_Click;
            // 
            // email
            // 
            email.AutoSize = true;
            email.Location = new Point(235, 161);
            email.Name = "email";
            email.Size = new Size(38, 15);
            email.TabIndex = 2;
            email.Text = "label1";
            // 
            // logoutButton
            // 
            logoutButton.Location = new Point(239, 273);
            logoutButton.Name = "logoutButton";
            logoutButton.Size = new Size(172, 23);
            logoutButton.TabIndex = 3;
            logoutButton.Text = "logoutButton";
            logoutButton.UseVisualStyleBackColor = true;
            logoutButton.Click += logoutButton_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 192, 192);
            ClientSize = new Size(800, 450);
            Controls.Add(logoutButton);
            Controls.Add(email);
            Controls.Add(Name);
            Controls.Add(profilepicturebox);
            Text = "Profilepage";
            Load += Main_Load;
            ((System.ComponentModel.ISupportInitialize)profilepicturebox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox profilepicturebox;
        private Label Name;
        private Label email;
        private Button logoutButton;
    }
}