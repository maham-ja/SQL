using System;
using System.Windows.Forms;

namespace UniversityManagementSystem
{
    public partial class frmFeeHeads : Form
    {
        public frmFeeHeads()
        {
            InitializeComponent();
            LoadSavedData();
        }

        private void btnSaveHostel_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Hostel Fee Heads Saved Successfully!\n\n" +
                $"Room Rent: {txtRoomRent.Text}\n" +
                $"Mess Charges: {txtMessCharges.Text}\n" +
                $"Utilities: {txtUtilities.Text}\n" +
                $"Maintenance: {txtMaintenance.Text}\n" +
                $"Security Deposit: {txtSecurityDeposit.Text}",
                "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSaveDayScholar_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Day Scholar Fee Heads Saved Successfully!\n\n" +
                $"Transport Charges: {txtTransport.Text}\n" +
                $"Library Fee: {txtLibraryFee.Text}\n" +
                $"Sports Fee: {txtSportsFee.Text}\n" +
                $"Activity Fee: {txtActivityFee.Text}",
                "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSaveCommon_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Common Fee Heads Saved Successfully!\n\n" +
                $"Tuition Fee: {txtTuition.Text}\n" +
                $"Examination Fee: {txtExamination.Text}\n" +
                $"Late Fee (per day): {txtLateFee.Text}",
                "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnResetAll_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to reset ALL fee heads to default values?",
                "Confirm Reset", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                // Reset Hostel Fees
                txtRoomRent.Text = "8000";
                txtMessCharges.Text = "5000";
                txtUtilities.Text = "2000";
                txtMaintenance.Text = "1500";
                txtSecurityDeposit.Text = "10000";

                // Reset Day Scholar Fees
                txtTransport.Text = "4000";
                txtLibraryFee.Text = "2000";
                txtSportsFee.Text = "1500";
                txtActivityFee.Text = "1000";

                // Reset Common Fees
                txtTuition.Text = "45000";
                txtExamination.Text = "5000";
                txtLateFee.Text = "100";

                MessageBox.Show("All fee heads reset to default values!", "Reset Complete",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void LoadSavedData()
        {
            // Load default values (in real app, load from database)
            txtRoomRent.Text = "8000";
            txtMessCharges.Text = "5000";
            txtUtilities.Text = "2000";
            txtMaintenance.Text = "1500";
            txtSecurityDeposit.Text = "10000";

            txtTransport.Text = "4000";
            txtLibraryFee.Text = "2000";
            txtSportsFee.Text = "1500";
            txtActivityFee.Text = "1000";

            txtTuition.Text = "45000";
            txtExamination.Text = "5000";
            txtLateFee.Text = "100";
        }
    }
}