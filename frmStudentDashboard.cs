using System;
using System.Windows.Forms;

namespace UMS
{
    public partial class frmStudentDashboard : Form
    {
        public frmStudentDashboard()
        {
            InitializeComponent();
        }

        private void btnMyVoucher_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your Current Fee Voucher\n\nStudent: Demo Student\nRoll No: 2025-GA-49\nCategory: Hostel Student\n\nTotal Fee: PKR 85,000\nDue Date: 30-June-2026\n\n(This will open PDF in final version)",
                "Fee Voucher", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnPaymentHistory_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Payment History\n\nDate: 15-Apr-2026 | Amount: PKR 85,000 | Status: Paid\nDate: 15-Mar-2026 | Amount: PKR 85,000 | Status: Paid\nDate: 15-Feb-2026 | Amount: PKR 85,000 | Status: Paid",
                "Payment History", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnMyAllocation_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your Hostel Allocation\n\nHostel: Boys Hostel - A\nRoom Number: 204\nRoom Type: Double Seater\nRent: PKR 8,000/month\nAllotment Date: 01-Sep-2025",
                "Hostel Allocation", MessageBoxButtons.OK, MessageBoxIcon.Information);
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