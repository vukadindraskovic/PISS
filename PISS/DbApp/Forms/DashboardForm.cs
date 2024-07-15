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
    public partial class DashboardForm : Form
    {
        private IList<string> _databases;
        private IList<string> _roles;
        private IList<BsonValue> _users;
        private string _selectedDatabase;
        private string _selectedCollection = null;

        public DashboardForm()
        {
            InitializeComponent();
        }

        #region MY_METHODS

        private void GetAndFillDatabases()
        {
            _databases = DataLayer.Instance.GetAllDatabases();

            foreach (var d in _databases)
            {
                var item = new ListViewItem(d);
                lvDatabases.Items.Add(item);
            }
        }

        private void GetAndFillCollections()
        {
            var collections = DataLayer.Instance.GetAllCollectionsOfDatabase(_selectedDatabase);

            foreach (var c in collections)
            {
                lvCollections.Items.Add(new ListViewItem(c));
            }
        }

        private void RemoveCollections()
        {
            lvCollections.Items.Clear();
        }

        private void RemoveDatabases()
        {
            lvDatabases.Items.Clear();
        }

        private void UpdateButtons()
        {
            btnDeleteDatabase.Enabled = !(_selectedDatabase == null || _selectedDatabase == "local" || _selectedDatabase == "config");
        }

        #endregion

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            GetAndFillDatabases();
        }

        private void lvDatabases_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvDatabases.SelectedItems.Count == 0) return;

            _selectedDatabase = lvDatabases.SelectedItems[0].SubItems[0].Text;
            _selectedCollection = null;

            RemoveCollections();
            GetAndFillCollections();
            UpdateButtons();
        }

        private void lvCollections_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvCollections.SelectedItems.Count == 0) return;

            _selectedCollection = lvCollections.SelectedItems[0].SubItems[0].Text;
        }

        private void btnDeleteCollection_Click(object sender, EventArgs e)
        {
            if (_selectedCollection == null)
            {
                MessageBox.Show("Please select collection to delete.");
                return;
            }

            DataLayer.Instance.DeleteCollectionOfDatabase(_selectedCollection, _selectedDatabase);

            MessageBox.Show("Collection successfully deleted.");

            RemoveCollections();
            GetAndFillCollections();
            UpdateButtons();
        }

        private void btnDeleteDatabase_Click(object sender, EventArgs e)
        {
            if (_selectedDatabase == null)
            {
                MessageBox.Show("Please select database to delete.");
                return;
            }

            DataLayer.Instance.DeleteDatabase(_selectedDatabase);

            MessageBox.Show("Database successfully deleted.");

            RemoveDatabases();
            GetAndFillDatabases();
            RemoveCollections();
            GetAndFillCollections();
            UpdateButtons();
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            if (_selectedDatabase == null)
            {
                MessageBox.Show("Please select database.");
                return;
            }

            var usersForm = new UsersForm(_selectedDatabase);
            usersForm.Show();
        }

        private void btnRoles_Click(object sender, EventArgs e)
        {
            if (_selectedDatabase == null)
            {
                MessageBox.Show("Please select database.");
                return;
            }

            var rolesForm = new RolesForm(_selectedDatabase);
            rolesForm.Show();
        }
    }
}
