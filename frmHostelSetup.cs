using System;
using System.Windows.Forms;

namespace UniversityManagementSystem
{
    public partial class frmHostelSetup : Form
    {
        public frmHostelSetup()
        {
            InitializeComponent();
        }

        private void btnAddHostel_Click(object sender, EventArgs e)
        {
            if (txtHostelName.Text == "" || txtWarden.Text == "")
            {
                MessageBox.Show("Please fill hostel name and warden name!", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            dgvHostels.Rows.Add(txtHostelName.Text, txtAddress.Text, txtWarden.Text, "10");

            MessageBox.Show($"Hostel '{txtHostelName.Text}' added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtHostelName.Text = "";
            txtAddress.Text = "";
            txtWarden.Text = "";
        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            if (cmbHostel.SelectedIndex == 0 || txtRoomNumber.Text == "" || txtRent.Text == "")
            {
                MessageBox.Show("Please select hostel and fill room details!", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            dgvRooms.Rows.Add(cmbHostel.Text, txtRoomNumber.Text, txtCapacity.Text, txtRent.Text, "Available");

            MessageBox.Show($"Room {txtRoomNumber.Text} added to {cmbHostel.Text} successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtRoomNumber.Text = "";
            txtCapacity.Text = "";
            txtRent.Text = "";
        }

        private void btnViewOccupancy_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hostel Occupancy Report\n\nTotal Rooms: 8\nOccupied Rooms: 5\nVacant Rooms: 3\n\nOccupancy Rate: 62.5%",
                "Occupancy Report", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}