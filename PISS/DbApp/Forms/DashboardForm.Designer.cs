namespace DbApp.Forms
{
    partial class DashboardForm
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
            btnDeleteCollection = new Button();
            btnDeleteDatabase = new Button();
            lvCollections = new ListView();
            columnHeader1 = new ColumnHeader();
            btnUsers = new Button();
            btnRoles = new Button();
            lvDatabases = new ListView();
            chName = new ColumnHeader();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnDeleteCollection);
            groupBox1.Controls.Add(btnDeleteDatabase);
            groupBox1.Controls.Add(lvCollections);
            groupBox1.Controls.Add(btnUsers);
            groupBox1.Controls.Add(btnRoles);
            groupBox1.Controls.Add(lvDatabases);
            groupBox1.Location = new Point(7, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(382, 230);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Database and collections";
            // 
            // btnDeleteCollection
            // 
            btnDeleteCollection.Location = new Point(123, 22);
            btnDeleteCollection.Name = "btnDeleteCollection";
            btnDeleteCollection.Size = new Size(134, 23);
            btnDeleteCollection.TabIndex = 9;
            btnDeleteCollection.Text = "Delete collection";
            btnDeleteCollection.UseVisualStyleBackColor = true;
            btnDeleteCollection.Visible = false;
            btnDeleteCollection.Click += btnDeleteCollection_Click;
            // 
            // btnDeleteDatabase
            // 
            btnDeleteDatabase.Location = new Point(123, 51);
            btnDeleteDatabase.Name = "btnDeleteDatabase";
            btnDeleteDatabase.Size = new Size(134, 23);
            btnDeleteDatabase.TabIndex = 7;
            btnDeleteDatabase.Text = "Delete Database";
            btnDeleteDatabase.UseVisualStyleBackColor = true;
            btnDeleteDatabase.Visible = false;
            btnDeleteDatabase.Click += btnDeleteDatabase_Click;
            // 
            // lvCollections
            // 
            lvCollections.Columns.AddRange(new ColumnHeader[] { columnHeader1 });
            lvCollections.Location = new Point(263, 22);
            lvCollections.Name = "lvCollections";
            lvCollections.Size = new Size(111, 201);
            lvCollections.TabIndex = 3;
            lvCollections.UseCompatibleStateImageBehavior = false;
            lvCollections.View = View.Details;
            lvCollections.SelectedIndexChanged += lvCollections_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Collection name";
            columnHeader1.Width = 100;
            // 
            // btnUsers
            // 
            btnUsers.Location = new Point(123, 171);
            btnUsers.Name = "btnUsers";
            btnUsers.Size = new Size(129, 23);
            btnUsers.TabIndex = 2;
            btnUsers.Text = "Users";
            btnUsers.UseVisualStyleBackColor = true;
            btnUsers.Click += btnUsers_Click;
            // 
            // btnRoles
            // 
            btnRoles.Location = new Point(123, 200);
            btnRoles.Name = "btnRoles";
            btnRoles.Size = new Size(129, 23);
            btnRoles.TabIndex = 1;
            btnRoles.Text = "Roles";
            btnRoles.UseVisualStyleBackColor = true;
            btnRoles.Click += btnRoles_Click;
            // 
            // lvDatabases
            // 
            lvDatabases.Columns.AddRange(new ColumnHeader[] { chName });
            lvDatabases.Location = new Point(6, 22);
            lvDatabases.Name = "lvDatabases";
            lvDatabases.Size = new Size(111, 201);
            lvDatabases.TabIndex = 0;
            lvDatabases.UseCompatibleStateImageBehavior = false;
            lvDatabases.View = View.Details;
            lvDatabases.SelectedIndexChanged += lvDatabases_SelectedIndexChanged;
            // 
            // chName
            // 
            chName.Text = "Database name";
            chName.Width = 100;
            // 
            // DashboardForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(394, 248);
            Controls.Add(groupBox1);
            MaximumSize = new Size(410, 287);
            MinimumSize = new Size(410, 287);
            Name = "DashboardForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            Load += DashboardForm_Load;
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private ListView lvDatabases;
        private ColumnHeader chName;
        private Button btnAddDatabase;
        private Button btnDeleteDatabase;
        private Button btnUsers;
        private Button btnRoles;
        private ListView lvCollections;
        private ColumnHeader columnHeader1;
        private Button btnDeleteCollection;
    }
}