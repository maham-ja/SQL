using System;
using System.Windows.Forms;

namespace UniversityManagementSystem
{
    public partial class frmProgramMerit : Form
    {
        public frmProgramMerit()
        {
            InitializeComponent();
        }

        private void btnCalculateMerit_Click(object sender, EventArgs e)
        {
            if (cmbProgram.SelectedIndex == 0)
            {
                MessageBox.Show("Please select a program!", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Sample merit data
            string[] students = { "Ali Khan", "Sara Ahmed", "Bilal Hassan", "Fatima Ali", "Usman Chaudhry" };
            int[] merits = { 85, 78, 92, 88, 76 };

            dgvMeritList.Rows.Clear();
            for (int i = 0; i < students.Length; i++)
            {
                dgvMeritList.Rows.Add(i + 1, students[i], merits[i], merits[i] >= 70 ? "Eligible" : "Not Eligible");
            }

            MessageBox.Show($"Merit List Generated for {cmbProgram.Text}!\nTotal Students: {students.Length}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnAddProgram_Click(object sender, EventArgs e)
        {
            if (txtProgramName.Text == "" || txtDuration.Text == "" || txtSeats.Text == "" || txtClosingMerit.Text == "")
            {
                MessageBox.Show("Please fill all program fields!", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            dgvPrograms.Rows.Add(txtProgramName.Text, txtDuration.Text, txtSeats.Text, txtClosingMerit.Text);

            MessageBox.Show($"Program '{txtProgramName.Text}' added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtProgramName.Text = "";
            txtDuration.Text = "";
            txtSeats.Text = "";
            txtClosingMerit.Text = "";
        }

        private void btnDeleteProgram_Click(object sender, EventArgs e)
        {
            if (dgvPrograms.SelectedRows.Count > 0)
            {
                dgvPrograms.Rows.RemoveAt(dgvPrograms.SelectedRows[0].Index);
                MessageBox.Show("Program deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Please select a program to delete!", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}