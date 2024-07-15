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
    public partial class AddUserForm : Form
    {
        private string _baseDatabase;
        private IList<BsonValue> _users;

        public AddUserForm(string baseDatabase)
        {
            InitializeComponent();
            _baseDatabase = baseDatabase;
            this.Text = $"Add user to {_baseDatabase} db";
        }

        private void GetAndFillRoles()
        {
            var roles = DataLayer.Instance.GetAllRolesOfDatabase(_baseDatabase);

            foreach (var role in roles)
            {
                clbRoles.Items.Add(role, false);
            }
        }

        private void AddUserForm_Load(object sender, EventArgs e)
        {
            GetAndFillRoles();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var roles = new List<String>();

            foreach (var clb in clbRoles.CheckedItems)
            {
                roles.Add(clb.ToString());
            }

            try
            {
                DataLayer.Instance.AddUserToDatabase(tbUsername.Text, mtbPassword.Text, roles, _baseDatabase);

                MessageBox.Show("User successfully created.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
