using DbApp.Forms;
using MongoDB.Driver;
using System.Runtime.CompilerServices;

namespace DbApp
{

    public partial class LogInForm : Form
    {
        public LogInForm()
        {
            InitializeComponent();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            DataLayer.SetCredentials(tbUsername.Text, tbPassword.Text);

            if (!DataLayer.Instance.IsAdmin) return;

            this.Hide();
            var dashboardForm = new DashboardForm();
            dashboardForm.FormClosed += (s, args) => this.Close();
            dashboardForm.Show();
        }
    }
}
