using System;
using System.Windows.Forms;
using System.Xml.Linq;

namespace UniversityManagementSystem
{
    public partial class frmStudentManagement : Form
    {
        public frmStudentManagement()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || txtRollNo.Text == "")
            {
                MessageBox.Show("Please enter Name and Roll No!", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string category = cmbCategory.SelectedItem.ToString();
            string roomStatus = (category == "Hostel Student") ? $"Room: {cmbRoomNumber.Text}" : "No Room Required";

            MessageBox.Show($"Student Saved Successfully!\n\nName: {txtName.Text}\nRoll No: {txtRollNo.Text}\nProgram: {cmbProgram.Text}\nCategory: {category}\n{roomStatus}\n\nMatric: {txtMatric.Text}/1100\nInter: {txtInter.Text}/1100\nEntry Test: {txtEntryTest.Text}/100",
                "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ClearForm();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Search Student\n\nEnter Roll No in search box to find student records.\n(This feature will connect to database in final version)",
                "Search", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCategory.SelectedItem.ToString() == "Hostel Student")
            {
                cmbRoomNumber.Enabled = true;
                lblRoom.Visible = true;
                cmbRoomNumber.Visible = true;
            }
            else
            {
                cmbRoomNumber.Enabled = false;
                lblRoom.Visible = false;
                cmbRoomNumber.Visible = false;
            }
        }

        private void ClearForm()
        {
            txtName.Text = "";
            txtRollNo.Text = "";
            txtCNIC.Text = "";
            txtPhone.Text = "";
            txtAddress.Text = "";
            txtMatric.Text = "";
            txtInter.Text = "";
            txtEntryTest.Text = "";
            cmbProgram.SelectedIndex = 0;
            cmbCategory.SelectedIndex = 0;
            cmbRoomNumber.SelectedIndex = 0;
            cmbRoomNumber.Enabled = false;
        }
    }
}