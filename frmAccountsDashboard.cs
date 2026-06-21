using System;
using System.Windows.Forms;
using UniversityManagementSystem;

namespace UMS
{
    public partial class frmAccountsDashboard : Form
    {
        public frmAccountsDashboard()
        {
            InitializeComponent();
        }

        private void btnViewVouchers_Click(object sender, EventArgs e)
        {
            frmFeeVoucher voucherForm = new frmFeeVoucher();
            voucherForm.ShowDialog();
        }

        private void btnPendingFees_Click(object sender, EventArgs e)
        {
            frmReports reportsForm = new frmReports();
            reportsForm.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to logout?", "Logout",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
                frmLogin login = new frmLogin();
                login.Show();
            }
        }
    }
}