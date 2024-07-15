using Microsoft.VisualBasic.ApplicationServices;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DbApp.Forms
{
    public partial class UsersForm : Form
    {
        private string _baseDatabase;
        private IList<BsonValue> _users;
        private string _selectedUser;
        private string _selectedRole;
        private IList<string> _roles = new List<string>();

        public UsersForm(string baseDatabase)
        {
            InitializeComponent();
            _baseDatabase = baseDatabase;
            this.Text = $"Users of {_baseDatabase}";
        }

        private void UsersForm_Load(object sender, EventArgs e)
        {
            GetUsers();
            FillUsers();
        }

        private void RemoveUsers()
        {
            lvUsers.Items.Clear();
        }

        private void GetUsers()
        {
            _users = DataLayer.Instance.GetAllUsers();
        }

        private void FillUsers()
        {
            IList<string> usernames = new List<string>();

            foreach (var u in _users)
            {
                if (u["db"].ToString() == _baseDatabase)
                {
                    usernames.Add(u["user"].ToString());
                    continue;
                }

                foreach (var r in u["roles"].AsBsonArray)
                {
                    if (r["db"].ToString() == _baseDatabase)
                    {
                        usernames.Add(u["user"].ToString());
                        continue;
                    }
                }
            }

            foreach (var username in usernames)
            {
                var item = new ListViewItem(username);
                lvUsers.Items.Add(item);
            }
        }

        private void RemoveRoles()
        {
            lvRoles.Items.Clear();
        }

        private void FillRoles()
        {
            foreach (var u in _users)
            {
                if (u["user"].ToString() != _selectedUser) continue;

                foreach (var r in u["roles"].AsBsonArray)
                {
                    _roles.Add(r["role"].ToString());
                    lvRoles.Items.Add(new ListViewItem(new string[] { r["role"].ToString() }));
                }
            }
        }

        private void lvUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvUsers.SelectedItems.Count == 0) return;

            _selectedUser = lvUsers.SelectedItems[0].SubItems[0].Text;
            _selectedRole = null;

            RemoveRoles();
            FillRoles();
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            if (_selectedUser == null)
            {
                MessageBox.Show("Please select user to delete.");
                return;
            }

            try
            {
                DataLayer.Instance.DeleteUserFromDatabase(_selectedUser, _baseDatabase);

                MessageBox.Show("User successfully deleted.");

                RemoveUsers();
                GetUsers();
                FillUsers();
                RemoveRoles();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            var addUserForm = new AddUserForm(_baseDatabase);
            addUserForm.Show();
            addUserForm.FormClosed += (s, args) =>
            {
                this.RemoveUsers();
                this.GetUsers();
                this.FillUsers();
                this.RemoveRoles();
            };
        }

        private void btnEditSelectedUser_Click(object sender, EventArgs e)
        {
            if (_selectedUser == null)
            {
                MessageBox.Show("Please select user to edit.");
                return;
            }

            var editUserForm = new EditUserForm(_selectedUser, _baseDatabase, _roles);
            editUserForm.Show();
            editUserForm.FormClosed += (s, args) =>
            {
                this.RemoveUsers();
                this.GetUsers();
                this.FillUsers();
                this.RemoveRoles();
            };
        }
    }
}
