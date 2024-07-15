using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.Design.AxImporter;

namespace DbApp.Forms
{
    public partial class RolesForm : Form
    {
        private string _baseDatabase;
        private BsonArray _roles;
        private string _selectedRole;

        public RolesForm(string baseDatabase)
        {
            InitializeComponent();
            _baseDatabase = baseDatabase;
            this.Text = $"Roles of {_baseDatabase} db";
        }

        private void GetAndFillRoles()
        {
            _roles = DataLayer.Instance.GetUserDefinedRolesWithPrivilegesOfDatabase(_baseDatabase);

            foreach (var role in _roles)
            {
                lvRoles.Items.Add(role["role"].ToString());
            }
        }

        private void RemoveRoles()
        {
            lvRoles.Items.Clear();
        }

        private void RemovePrivileges()
        {
            lvPrivileges.Items.Clear();
        }

        private void FillPrivileges()
        {
            foreach (var role in _roles)
            {
                if (role["role"] != _selectedRole) continue;

                var privileges = role["privileges"].AsBsonArray;

                foreach (var p in privileges)
                {
                    lvPrivileges.Items.Add(new ListViewItem(new string[] { $"{p["resource"]["collection"]}", p["actions"].ToString().Replace("[", "").Replace("]", "") }));
                }
            }
        }

        private void GetAndFillResources()
        {
            var collections = DataLayer.Instance.GetAllCollectionsOfDatabase(_baseDatabase);

            cbResources.Items.Add("All collections");
            foreach (var c in collections)
            {
                cbResources.Items.Add(c);
            }


            cbResources.SelectedIndex = 0;
        }

        private void RemoveActions()
        {
            clbActions.Items.Clear();
        }

        private void FillActions()
        {
            if (_selectedRole == null) return;

            IList<string> collectionActions = new List<string>()
                { "find", "insert", "remove", "update", "bypassDocumentValidation", "useUUID" };
            IList<string> databaseActions = new List<string>()
            { "changeCustomData", "changeOwnCustomData", "changeOwnPassword", "changePassword", "createCollection", "createIndex",
                "createRole", "createUser", "dropCollection", "dropRole", "dropUser", "grantRole", "killCursors",
                "killAnyCursor", "revokeRole", "setAuthenticationRestriction", "unlock", "viewRole", "viewUser" };

            IList<string> actions = cbResources.SelectedIndex == 0 ? databaseActions : collectionActions;

            foreach (var action in actions)
            {
                clbActions.Items.Add(action, false);
            }
        }

        private void UncheckActions()
        {
            for (int i = 0; i < clbActions.Items.Count; i++)
            {
                clbActions.SetItemCheckState(i, CheckState.Unchecked);
            }
        }

        private void RolesForm_Load(object sender, EventArgs e)
        {
            GetAndFillRoles();
            GetAndFillResources();
            FillActions();
        }

        private void lvRoles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvRoles.SelectedItems.Count == 0) return;

            _selectedRole = lvRoles.SelectedItems[0].SubItems[0].Text;

            RemovePrivileges();
            FillPrivileges();
            RemoveActions();
            FillActions();
        }

        private void btnAddRole_Click(object sender, EventArgs e)
        {
            try
            {
                DataLayer.Instance.AddRoleToDatabase(tbRoleName.Text, _baseDatabase);

                MessageBox.Show("Role created successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            RemoveRoles();
            GetAndFillRoles();
            RemovePrivileges();
        }

        private void btnDeleteRole_Click(object sender, EventArgs e)
        {
            if (_selectedRole is null)
            {
                MessageBox.Show("Please select role to delete.");
                return;
            }

            try
            {

                DataLayer.Instance.DeleteRoleFromDatabase(_selectedRole, _baseDatabase);

                MessageBox.Show("Role successfully deleted.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            RemoveRoles();
            GetAndFillRoles();
            RemovePrivileges();
        }

        private void btnAddPrivilege_Click(object sender, EventArgs e)
        {
            var actions = new List<String>();

            foreach (var clb in clbActions.CheckedItems)
            {
                actions.Add(clb.ToString());
            }

            try
            {
                DataLayer.Instance.AddPrivilegeToRole(_selectedRole, _baseDatabase, cbResources.Text, actions);

                MessageBox.Show("Privilege added successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            RemoveRoles();
            UncheckActions();
            RemovePrivileges();
            GetAndFillRoles();
        }

        private void btnDeleteSelectedPrivilege_Click(object sender, EventArgs e)
        {
            if (lvPrivileges.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select privilege to delete.");
                return;
            }

            string collection = lvPrivileges.SelectedItems[0].SubItems[0].Text;
            IList<string> actions = lvPrivileges.SelectedItems[0].SubItems[1].Text.Split(", ").ToList();

            try
            {
                DataLayer.Instance.DeletePrivilegeFromRole(_selectedRole, collection, actions, _baseDatabase);

                MessageBox.Show("Privilege deleted successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            RemoveRoles();
            UncheckActions();
            RemovePrivileges();
            GetAndFillRoles();
        }

        private void cbResources_SelectedIndexChanged(object sender, EventArgs e)
        {
            RemoveActions();
            FillActions();
        }
    }
}