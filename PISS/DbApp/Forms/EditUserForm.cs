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
    public partial class EditUserForm : Form
    {
        private string _username;
        private string _baseDatabase;
        private IList<string> _usersRoles;

        public EditUserForm(string username, string baseDatabase, IList<string> usersRoles)
        {
            _username = username;
            _baseDatabase = baseDatabase;
            _usersRoles = usersRoles;
            InitializeComponent();
        }

        private void GetAndFillDatabaseRoles()
        {
            var roles = DataLayer.Instance.GetAllRolesOfDatabase(_baseDatabase);

            foreach (var role in roles)
            {
                clbRoles.Items.Add(role, _usersRoles.Contains(role));
            }
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            try
            {
                DataLayer.Instance.ChangeUsersPassword(_username, tbNewPassword.Text, _baseDatabase);
                tbNewPassword.Text = "";
                MessageBox.Show("User's password changed successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void EditUserForm_Load(object sender, EventArgs e)
        {
            GetAndFillDatabaseRoles();
            this.Text = $"Edit user {_username}";
        }

        private void btnUpdateRoles_Click(object sender, EventArgs e)
        {
            var roles = new List<String>();

            foreach (var clb in clbRoles.CheckedItems)
            {
                roles.Add(clb.ToString());
            }

            try
            {
                DataLayer.Instance.UpdateUsersRoles(_username, roles, _baseDatabase);
                MessageBox.Show("User's roles updated successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
