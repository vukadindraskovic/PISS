namespace DbApp.Forms
{
    partial class RolesForm
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
            groupBox2 = new GroupBox();
            lvPrivileges = new ListView();
            columnHeader2 = new ColumnHeader();
            chd1 = new ColumnHeader();
            groupBox1 = new GroupBox();
            lvRoles = new ListView();
            columnHeader1 = new ColumnHeader();
            btnDeleteRole = new Button();
            groupBox5 = new GroupBox();
            btnAddPrivilege = new Button();
            clbActions = new CheckedListBox();
            label3 = new Label();
            cbResources = new ComboBox();
            label2 = new Label();
            groupBox6 = new GroupBox();
            label1 = new Label();
            btnAddRole = new Button();
            tbRoleName = new TextBox();
            btnDeleteSelectedPrivilege = new Button();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox6.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lvPrivileges);
            groupBox2.Location = new Point(216, 16);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(358, 311);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Privileges";
            // 
            // lvPrivileges
            // 
            lvPrivileges.Columns.AddRange(new ColumnHeader[] { columnHeader2, chd1 });
            lvPrivileges.Location = new Point(7, 29);
            lvPrivileges.Margin = new Padding(3, 4, 3, 4);
            lvPrivileges.Name = "lvPrivileges";
            lvPrivileges.Size = new Size(341, 272);
            lvPrivileges.TabIndex = 0;
            lvPrivileges.UseCompatibleStateImageBehavior = false;
            lvPrivileges.View = View.Details;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Collection";
            columnHeader2.Width = 100;
            // 
            // chd1
            // 
            chd1.Text = "Actions";
            chd1.Width = 190;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lvRoles);
            groupBox1.Location = new Point(14, 16);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(195, 311);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Roles";
            // 
            // lvRoles
            // 
            lvRoles.Columns.AddRange(new ColumnHeader[] { columnHeader1 });
            lvRoles.Location = new Point(7, 29);
            lvRoles.Margin = new Padding(3, 4, 3, 4);
            lvRoles.Name = "lvRoles";
            lvRoles.Size = new Size(181, 272);
            lvRoles.TabIndex = 0;
            lvRoles.UseCompatibleStateImageBehavior = false;
            lvRoles.View = View.Details;
            lvRoles.SelectedIndexChanged += lvRoles_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Name";
            columnHeader1.Width = 150;
            // 
            // btnDeleteRole
            // 
            btnDeleteRole.Location = new Point(14, 487);
            btnDeleteRole.Margin = new Padding(3, 4, 3, 4);
            btnDeleteRole.Name = "btnDeleteRole";
            btnDeleteRole.Size = new Size(195, 31);
            btnDeleteRole.TabIndex = 4;
            btnDeleteRole.Text = "Delete selected role";
            btnDeleteRole.UseVisualStyleBackColor = true;
            btnDeleteRole.Click += btnDeleteRole_Click;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(btnAddPrivilege);
            groupBox5.Controls.Add(clbActions);
            groupBox5.Controls.Add(label3);
            groupBox5.Controls.Add(cbResources);
            groupBox5.Controls.Add(label2);
            groupBox5.Location = new Point(216, 335);
            groupBox5.Margin = new Padding(3, 4, 3, 4);
            groupBox5.Name = "groupBox5";
            groupBox5.Padding = new Padding(3, 4, 3, 4);
            groupBox5.Size = new Size(358, 260);
            groupBox5.TabIndex = 6;
            groupBox5.TabStop = false;
            groupBox5.Text = "Add privilege to role";
            // 
            // btnAddPrivilege
            // 
            btnAddPrivilege.Location = new Point(227, 43);
            btnAddPrivilege.Margin = new Padding(3, 4, 3, 4);
            btnAddPrivilege.Name = "btnAddPrivilege";
            btnAddPrivilege.Size = new Size(121, 31);
            btnAddPrivilege.TabIndex = 4;
            btnAddPrivilege.Text = "Add privilege";
            btnAddPrivilege.UseVisualStyleBackColor = true;
            btnAddPrivilege.Click += btnAddPrivilege_Click;
            // 
            // clbActions
            // 
            clbActions.FormattingEnabled = true;
            clbActions.Location = new Point(7, 107);
            clbActions.Margin = new Padding(3, 4, 3, 4);
            clbActions.Name = "clbActions";
            clbActions.Size = new Size(213, 136);
            clbActions.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(7, 83);
            label3.Name = "label3";
            label3.Size = new Size(58, 20);
            label3.TabIndex = 2;
            label3.Text = "Actions";
            // 
            // cbResources
            // 
            cbResources.DropDownStyle = ComboBoxStyle.DropDownList;
            cbResources.FormattingEnabled = true;
            cbResources.Location = new Point(83, 43);
            cbResources.Margin = new Padding(3, 4, 3, 4);
            cbResources.Name = "cbResources";
            cbResources.Size = new Size(137, 28);
            cbResources.TabIndex = 1;
            cbResources.SelectedIndexChanged += cbResources_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 47);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 0;
            label2.Text = "Resource";
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(label1);
            groupBox6.Controls.Add(btnAddRole);
            groupBox6.Controls.Add(tbRoleName);
            groupBox6.Location = new Point(14, 335);
            groupBox6.Margin = new Padding(3, 4, 3, 4);
            groupBox6.Name = "groupBox6";
            groupBox6.Padding = new Padding(3, 4, 3, 4);
            groupBox6.Size = new Size(195, 124);
            groupBox6.TabIndex = 7;
            groupBox6.TabStop = false;
            groupBox6.Text = "Add role";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 43);
            label1.Name = "label1";
            label1.Size = new Size(80, 20);
            label1.TabIndex = 0;
            label1.Text = "Role name";
            // 
            // btnAddRole
            // 
            btnAddRole.Location = new Point(40, 83);
            btnAddRole.Margin = new Padding(3, 4, 3, 4);
            btnAddRole.Name = "btnAddRole";
            btnAddRole.Size = new Size(117, 31);
            btnAddRole.TabIndex = 2;
            btnAddRole.Text = "Add role";
            btnAddRole.UseVisualStyleBackColor = true;
            btnAddRole.Click += btnAddRole_Click;
            // 
            // tbRoleName
            // 
            tbRoleName.Location = new Point(85, 39);
            tbRoleName.Margin = new Padding(3, 4, 3, 4);
            tbRoleName.Name = "tbRoleName";
            tbRoleName.Size = new Size(103, 27);
            tbRoleName.TabIndex = 1;
            // 
            // btnDeleteSelectedPrivilege
            // 
            btnDeleteSelectedPrivilege.Location = new Point(14, 525);
            btnDeleteSelectedPrivilege.Margin = new Padding(3, 4, 3, 4);
            btnDeleteSelectedPrivilege.Name = "btnDeleteSelectedPrivilege";
            btnDeleteSelectedPrivilege.Size = new Size(195, 31);
            btnDeleteSelectedPrivilege.TabIndex = 8;
            btnDeleteSelectedPrivilege.Text = "Delete selected privilege";
            btnDeleteSelectedPrivilege.UseVisualStyleBackColor = true;
            btnDeleteSelectedPrivilege.Click += btnDeleteSelectedPrivilege_Click;
            // 
            // RolesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(578, 597);
            Controls.Add(btnDeleteSelectedPrivilege);
            Controls.Add(groupBox6);
            Controls.Add(btnDeleteRole);
            Controls.Add(groupBox5);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 4, 3, 4);
            MaximumSize = new Size(596, 644);
            MinimumSize = new Size(596, 644);
            Name = "RolesForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RolesForm";
            Load += RolesForm_Load;
            groupBox2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox2;
        private ListView lvPrivileges;
        private ColumnHeader columnHeader2;
        private ColumnHeader chd1;
        private GroupBox groupBox1;
        private ListView lvRoles;
        private ColumnHeader columnHeader1;
        private Button btnDeleteRole;
        private GroupBox groupBox5;
        private Button btnAddPrivilege;
        private CheckedListBox clbActions;
        private Label label3;
        private ComboBox cbResources;
        private Label label2;
        private GroupBox groupBox6;
        private Label label1;
        private Button btnAddRole;
        private TextBox tbRoleName;
        private Button btnDeleteSelectedPrivilege;
    }
}