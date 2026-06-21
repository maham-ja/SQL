using System;
using System.Windows.Forms;

namespace UMS
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            cmbRole.SelectedIndex = 0;
            txtPassword.Text = "";
            txtPassword.Focus();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (cmbRole.SelectedItem == null)
            {
                MessageBox.Show("Please select a role!", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string selectedRole = cmbRole.SelectedItem.ToString();
            string password = txtPassword.Text.Trim();

            bool isValid = false;

            if (selectedRole == "Admin" && password == "admin123")
                isValid = true;
            else if (selectedRole == "Accounts" && password == "acc123")
                isValid = true;
            else if (selectedRole == "Student" && password == "student123")
                isValid = true;

            if (isValid)
            {
                this.Hide();

                if (selectedRole == "Admin")
                {
                    frmAdminDashboard adminDash = new frmAdminDashboard();
                    adminDash.Show();
                }
                else if (selectedRole == "Accounts")
                {
                    frmAccountsDashboard accountsDash = new frmAccountsDashboard();
                    accountsDash.Show();
                }
                else if (selectedRole == "Student")
                {
                    frmStudentDashboard studentDash = new frmStudentDashboard();
                    studentDash.Show();
                }
            }
            else
            {
                MessageBox.Show("Invalid Password!\n\nAdmin: admin123\nAccounts: acc123\nStudent: student123",
                    "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Clear();
                txtPassword.Focus();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}