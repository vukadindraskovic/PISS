namespace DbApp.Forms
{
    partial class UsersForm
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
            lvUsers = new ListView();
            columnHeader1 = new ColumnHeader();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            lvRoles = new ListView();
            columnHeader2 = new ColumnHeader();
            btnAddUser = new Button();
            btnDeleteUser = new Button();
            btnEditSelectedUser = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // lvUsers
            // 
            lvUsers.Columns.AddRange(new ColumnHeader[] { columnHeader1 });
            lvUsers.Location = new Point(6, 22);
            lvUsers.Name = "lvUsers";
            lvUsers.Size = new Size(154, 205);
            lvUsers.TabIndex = 0;
            lvUsers.UseCompatibleStateImageBehavior = false;
            lvUsers.View = View.Details;
            lvUsers.SelectedIndexChanged += lvUsers_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Username";
            columnHeader1.Width = 150;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lvUsers);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(166, 233);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Users";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lvRoles);
            groupBox2.Location = new Point(184, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(179, 233);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Roles";
            // 
            // lvRoles
            // 
            lvRoles.Columns.AddRange(new ColumnHeader[] { columnHeader2 });
            lvRoles.Location = new Point(6, 22);
            lvRoles.Name = "lvRoles";
            lvRoles.Size = new Size(167, 205);
            lvRoles.TabIndex = 0;
            lvRoles.UseCompatibleStateImageBehavior = false;
            lvRoles.View = View.Details;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Role name";
            columnHeader2.Width = 150;
            // 
            // btnAddUser
            // 
            btnAddUser.Location = new Point(147, 251);
            btnAddUser.Name = "btnAddUser";
            btnAddUser.Size = new Size(75, 23);
            btnAddUser.TabIndex = 3;
            btnAddUser.Text = "Add user";
            btnAddUser.UseVisualStyleBackColor = true;
            btnAddUser.Click += btnAddUser_Click;
            // 
            // btnDeleteUser
            // 
            btnDeleteUser.Location = new Point(12, 251);
            btnDeleteUser.Name = "btnDeleteUser";
            btnDeleteUser.Size = new Size(125, 23);
            btnDeleteUser.TabIndex = 4;
            btnDeleteUser.Text = "Delete selected user";
            btnDeleteUser.UseVisualStyleBackColor = true;
            btnDeleteUser.Click += btnDeleteUser_Click;
            // 
            // btnEditSelectedUser
            // 
            btnEditSelectedUser.Location = new Point(228, 251);
            btnEditSelectedUser.Name = "btnEditSelectedUser";
            btnEditSelectedUser.Size = new Size(135, 23);
            btnEditSelectedUser.TabIndex = 5;
            btnEditSelectedUser.Text = "Edit selected user";
            btnEditSelectedUser.UseVisualStyleBackColor = true;
            btnEditSelectedUser.Click += btnEditSelectedUser_Click;
            // 
            // UsersForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(370, 280);
            Controls.Add(btnEditSelectedUser);
            Controls.Add(btnDeleteUser);
            Controls.Add(btnAddUser);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            MaximumSize = new Size(386, 319);
            MinimumSize = new Size(386, 319);
            Name = "UsersForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UserForm";
            Load += UsersForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ListView lvUsers;
        private ColumnHeader columnHeader1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private ListView lvRoles;
        private ColumnHeader columnHeader2;
        private Button btnAddUser;
        private Button btnDeleteUser;
        private Button btnEditSelectedUser;
    }
}