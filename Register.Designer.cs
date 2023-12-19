namespace assignment_app
{
    partial class Register
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
            label1 = new Label();
            firstNameBox = new TextBox();
            label2 = new Label();
            lastNameBox = new TextBox();
            Email = new Label();
            emailBox = new TextBox();
            label3 = new Label();
            passwordBox = new TextBox();
            UploadPhotoButton = new Button();
            registerButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(175, 72);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 0;
            label1.Text = "First Name";
            // 
            // firstNameBox
            // 
            firstNameBox.Location = new Point(260, 69);
            firstNameBox.Name = "firstNameBox";
            firstNameBox.Size = new Size(170, 23);
            firstNameBox.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(176, 108);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 2;
            label2.Text = "Last Name";
            // 
            // lastNameBox
            // 
            lastNameBox.Location = new Point(259, 105);
            lastNameBox.Name = "lastNameBox";
            lastNameBox.Size = new Size(171, 23);
            lastNameBox.TabIndex = 3;
            // 
            // Email
            // 
            Email.AutoSize = true;
            Email.Location = new Point(176, 145);
            Email.Name = "Email";
            Email.Size = new Size(36, 15);
            Email.TabIndex = 4;
            Email.Text = "Email";
            // 
            // emailBox
            // 
            emailBox.Location = new Point(258, 142);
            emailBox.Name = "emailBox";
            emailBox.Size = new Size(172, 23);
            emailBox.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(179, 181);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 6;
            label3.Text = "Passowrd";
            // 
            // passwordBox
            // 
            passwordBox.Location = new Point(256, 178);
            passwordBox.Name = "passwordBox";
            passwordBox.Size = new Size(174, 23);
            passwordBox.TabIndex = 7;
            // 
            // UploadPhotoButton
            // 
            UploadPhotoButton.Location = new Point(254, 214);
            UploadPhotoButton.Name = "UploadPhotoButton";
            UploadPhotoButton.Size = new Size(176, 23);
            UploadPhotoButton.TabIndex = 8;
            UploadPhotoButton.Text = "Upload Photo";
            UploadPhotoButton.UseVisualStyleBackColor = true;
            UploadPhotoButton.Click += UploadPhotoButton_Click;
            // 
            // registerButton
            // 
            registerButton.BackColor = Color.Lime;
            registerButton.Location = new Point(663, 385);
            registerButton.Name = "registerButton";
            registerButton.Size = new Size(94, 23);
            registerButton.TabIndex = 9;
            registerButton.Text = "Register";
            registerButton.UseVisualStyleBackColor = false;
            registerButton.Click += registerButton_Click;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 128, 255);
            ClientSize = new Size(800, 450);
            Controls.Add(registerButton);
            Controls.Add(UploadPhotoButton);
            Controls.Add(passwordBox);
            Controls.Add(label3);
            Controls.Add(emailBox);
            Controls.Add(Email);
            Controls.Add(lastNameBox);
            Controls.Add(label2);
            Controls.Add(firstNameBox);
            Controls.Add(label1);
            Name = "Register";
            Text = "Register";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox firstNameBox;
        private Label label2;
        private TextBox lastNameBox;
        private Label Email;
        private TextBox emailBox;
        private Label label3;
        private TextBox passwordBox;
        private Button UploadPhotoButton;
        private Button registerButton;
    }
}