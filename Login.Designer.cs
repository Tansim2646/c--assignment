namespace assignment_app
{
    partial class Login
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
            label2 = new Label();
            emailBox = new TextBox();
            label3 = new Label();
            passwordBox = new TextBox();
            loginBtn = new Button();
            registerButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(219, 46);
            label1.Name = "label1";
            label1.Size = new Size(315, 45);
            label1.TabIndex = 0;
            label1.Text = "Welcome to the App";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(204, 128);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 1;
            label2.Text = "Email";
            // 
            // emailBox
            // 
            emailBox.Location = new Point(272, 125);
            emailBox.Name = "emailBox";
            emailBox.Size = new Size(250, 23);
            emailBox.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(204, 165);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 3;
            label3.Text = "Password";
            // 
            // passwordBox
            // 
            passwordBox.Location = new Point(272, 162);
            passwordBox.Name = "passwordBox";
            passwordBox.Size = new Size(250, 23);
            passwordBox.TabIndex = 4;
            // 
            // loginBtn
            // 
            loginBtn.Location = new Point(272, 208);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(75, 23);
            loginBtn.TabIndex = 5;
            loginBtn.Text = "Login";
            loginBtn.UseVisualStyleBackColor = true;
            loginBtn.Click += loginBtn_Click;
            // 
            // registerButton
            // 
            registerButton.Location = new Point(368, 208);
            registerButton.Name = "registerButton";
            registerButton.Size = new Size(75, 23);
            registerButton.TabIndex = 6;
            registerButton.Text = "Register";
            registerButton.UseVisualStyleBackColor = true;
            registerButton.Click += registerButton_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 128);
            ClientSize = new Size(800, 450);
            Controls.Add(registerButton);
            Controls.Add(loginBtn);
            Controls.Add(passwordBox);
            Controls.Add(label3);
            Controls.Add(emailBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox emailBox;
        private Label label3;
        private TextBox passwordBox;
        private Button loginBtn;
        private Button registerButton;
    }
}