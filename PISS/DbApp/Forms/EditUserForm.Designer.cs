namespace DbApp.Forms
{
    partial class EditUserForm
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
            groupBox1 = new GroupBox();
            btnChangePassword = new Button();
            tbNewPassword = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            btnUpdateRoles = new Button();
            clbRoles = new CheckedListBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnChangePassword);
            groupBox1.Controls.Add(tbNewPassword);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(14, 16);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(279, 113);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Change password";
            // 
            // btnChangePassword
            // 
            btnChangePassword.Location = new Point(77, 68);
            btnChangePassword.Margin = new Padding(3, 4, 3, 4);
            btnChangePassword.Name = "btnChangePassword";
            btnChangePassword.Size = new Size(129, 31);
            btnChangePassword.TabIndex = 2;
            btnChangePassword.Text = "Change password";
            btnChangePassword.UseVisualStyleBackColor = true;
            btnChangePassword.Click += btnChangePassword_Click;
            // 
            // tbNewPassword
            // 
            tbNewPassword.Location = new Point(110, 29);
            tbNewPassword.Margin = new Padding(3, 4, 3, 4);
            tbNewPassword.Name = "tbNewPassword";
            tbNewPassword.PasswordChar = '*';
            tbNewPassword.Size = new Size(162, 27);
            tbNewPassword.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 33);
            label1.Name = "label1";
            label1.Size = new Size(106, 20);
            label1.TabIndex = 0;
            label1.Text = "New password";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnUpdateRoles);
            groupBox2.Controls.Add(clbRoles);
            groupBox2.Location = new Point(14, 137);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(279, 265);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Update roles";
            // 
            // btnUpdateRoles
            // 
            btnUpdateRoles.Location = new Point(77, 217);
            btnUpdateRoles.Margin = new Padding(3, 4, 3, 4);
            btnUpdateRoles.Name = "btnUpdateRoles";
            btnUpdateRoles.Size = new Size(129, 31);
            btnUpdateRoles.TabIndex = 3;
            btnUpdateRoles.Text = "Update roles";
            btnUpdateRoles.UseVisualStyleBackColor = true;
            btnUpdateRoles.Click += btnUpdateRoles_Click;
            // 
            // clbRoles
            // 
            clbRoles.FormattingEnabled = true;
            clbRoles.Location = new Point(7, 29);
            clbRoles.Margin = new Padding(3, 4, 3, 4);
            clbRoles.Name = "clbRoles";
            clbRoles.Size = new Size(265, 180);
            clbRoles.TabIndex = 2;
            // 
            // EditUserForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(310, 415);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 4, 3, 4);
            MaximumSize = new Size(328, 462);
            MinimumSize = new Size(328, 462);
            Name = "EditUserForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EditUserForm";
            Load += EditUserForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnChangePassword;
        private TextBox tbNewPassword;
        private Label label1;
        private GroupBox groupBox2;
        private Button btnUpdateRoles;
        private CheckedListBox clbRoles;
    }
}