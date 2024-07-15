namespace DbApp.Forms
{
    partial class AddUserForm
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
            tbUsername = new TextBox();
            label3 = new Label();
            clbRoles = new CheckedListBox();
            btnAdd = new Button();
            mtbPassword = new MaskedTextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 35);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 0;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 69);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // tbUsername
            // 
            tbUsername.Location = new Point(89, 31);
            tbUsername.Margin = new Padding(3, 4, 3, 4);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(265, 27);
            tbUsername.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 104);
            label3.Name = "label3";
            label3.Size = new Size(45, 20);
            label3.TabIndex = 5;
            label3.Text = "Roles";
            // 
            // clbRoles
            // 
            clbRoles.FormattingEnabled = true;
            clbRoles.Location = new Point(89, 104);
            clbRoles.Margin = new Padding(3, 4, 3, 4);
            clbRoles.Name = "clbRoles";
            clbRoles.Size = new Size(265, 180);
            clbRoles.TabIndex = 6;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(143, 292);
            btnAdd.Margin = new Padding(3, 4, 3, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(86, 31);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // mtbPassword
            // 
            mtbPassword.Location = new Point(89, 65);
            mtbPassword.Margin = new Padding(3, 4, 3, 4);
            mtbPassword.Name = "mtbPassword";
            mtbPassword.PasswordChar = '*';
            mtbPassword.Size = new Size(265, 27);
            mtbPassword.TabIndex = 8;
            // 
            // AddUserForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(366, 343);
            Controls.Add(mtbPassword);
            Controls.Add(btnAdd);
            Controls.Add(clbRoles);
            Controls.Add(label3);
            Controls.Add(tbUsername);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            MaximumSize = new Size(384, 390);
            MinimumSize = new Size(384, 390);
            Name = "AddUserForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add user";
            Load += AddUserForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox tbUsername;
        private Label label3;
        private CheckedListBox clbRoles;
        private Button btnAdd;
        private MaskedTextBox mtbPassword;
    }
}