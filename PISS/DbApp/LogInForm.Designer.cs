namespace DbApp
{
    partial class LogInForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            tbUsername = new TextBox();
            tbPassword = new TextBox();
            label5 = new Label();
            btnLogIn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 53);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 4;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 81);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 5;
            label2.Text = "Password";
            // 
            // tbUsername
            // 
            tbUsername.Location = new Point(89, 50);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(200, 23);
            tbUsername.TabIndex = 0;
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(89, 78);
            tbPassword.Name = "tbPassword";
            tbPassword.PasswordChar = '*';
            tbPassword.Size = new Size(200, 23);
            tbPassword.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(57, 9);
            label5.Name = "label5";
            label5.Size = new Size(215, 30);
            label5.TabIndex = 7;
            label5.Text = "Admin MongoDB app";
            // 
            // btnLogIn
            // 
            btnLogIn.Location = new Point(104, 107);
            btnLogIn.Name = "btnLogIn";
            btnLogIn.Size = new Size(107, 27);
            btnLogIn.TabIndex = 3;
            btnLogIn.Text = "Log in";
            btnLogIn.UseVisualStyleBackColor = true;
            btnLogIn.Click += btnLogIn_Click;
            // 
            // LogInForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(322, 140);
            Controls.Add(btnLogIn);
            Controls.Add(label5);
            Controls.Add(tbPassword);
            Controls.Add(tbUsername);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximumSize = new Size(338, 179);
            MinimumSize = new Size(338, 179);
            Name = "LogInForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Log in";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox tbUsername;
        private TextBox tbPassword;
        private Label label5;
        private Button btnLogIn;
    }
}
