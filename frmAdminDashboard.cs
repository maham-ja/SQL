using System;
using System.Windows.Forms;
using UniversityManagementSystem;

namespace UMS
{
    public partial class frmAdminDashboard : Form
    {
        public frmAdminDashboard()
        {
            InitializeComponent();
        }

        private void btnStudentManagement_Click(object sender, EventArgs e)
        {
            frmStudentManagement studentForm = new frmStudentManagement();
            studentForm.ShowDialog();
        }

        private void btnProgramMerit_Click(object sender, EventArgs e)
        {
            frmProgramMerit meritForm = new frmProgramMerit();
            meritForm.ShowDialog();
        }

        private void btnHostelSetup_Click(object sender, EventArgs e)
        {
            frmHostelSetup hostelForm = new frmHostelSetup();
            hostelForm.ShowDialog();
        }

        private void btnFeeHeads_Click(object sender, EventArgs e)
        {
            frmFeeHeads feeHeadsForm = new frmFeeHeads();
            feeHeadsForm.ShowDialog();
        }

        private void btnFeeVoucher_Click(object sender, EventArgs e)
        {
            frmFeeVoucher voucherForm = new frmFeeVoucher();
            voucherForm.ShowDialog();
        }

        private void btnReports_Click(object sender, EventArgs e)
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