using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace MidDb26_25GA49
{
    public class AssignStudentsToGroupForm : Form
    {
        DatabaseHelper db = new DatabaseHelper();
        int currentGroupId;

        private DataGridView dgvAvailableStudents, dgvAssignedStudents;
        private Button btnAssign, btnRemove, btnClose;
        private Label lblGroupInfo;

        public AssignStudentsToGroupForm(int groupId)
        {
            currentGroupId = groupId;
            InitializeForm();
            LoadAvailableStudents();
            LoadAssignedStudents();
        }

        private void InitializeForm()
        {
            this.Text = "Assign Students to Group";
            this.Size = new Size(1000, 550);
            this.StartPosition = FormStartPosition.CenterScreen;

            lblGroupInfo = new Label() { Text = $"Group ID: {currentGroupId}", Location = new Point(20, 20), Size = new Size(200, 30), Font = new Font("Segoe UI", 12, FontStyle.Bold) };
            this.Controls.Add(lblGroupInfo);

            Label lblAvailable = new Label() { Text = "Available Students", Location = new Point(20, 60), Size = new Size(200, 25), Font = new Font("Segoe UI", 10, FontStyle.Bold) };
            this.Controls.Add(lblAvailable);

            dgvAvailableStudents = new DataGridView() { Location = new Point(20, 90), Size = new Size(450, 380), AllowUserToAddRows = false, ReadOnly = true, SelectionMode = DataGridViewSelectionMode.FullRowSelect };
            this.Controls.Add(dgvAvailableStudents);

            Label lblAssigned = new Label() { Text = "Assigned Students", Location = new Point(530, 60), Size = new Size(200, 25), Font = new Font("Segoe UI", 10, FontStyle.Bold) };
            this.Controls.Add(lblAssigned);

            dgvAssignedStudents = new DataGridView() { Location = new Point(530, 90), Size = new Size(450, 380), AllowUserToAddRows = false, ReadOnly = true, SelectionMode = DataGridViewSelectionMode.FullRowSelect };
            this.Controls.Add(dgvAssignedStudents);

            btnAssign = new Button() { Text = "→ ASSIGN →", Location = new Point(20, 480), Size = new Size(120, 35), BackColor = Color.LightGreen };
            btnAssign.Click += BtnAssign_Click;
            this.Controls.Add(btnAssign);

            btnRemove = new Button() { Text = "← REMOVE ←", Location = new Point(160, 480), Size = new Size(120, 35), BackColor = Color.LightCoral };
            btnRemove.Click += BtnRemove_Click;
            this.Controls.Add(btnRemove);

            btnClose = new Button() { Text = "CLOSE", Location = new Point(860, 480), Size = new Size(100, 35), BackColor = Color.LightGray };
            btnClose.Click += (s, e) => this.Close();
            this.Controls.Add(btnClose);
        }

        private void LoadAvailableStudents()
        {
            string query = @"SELECT p.Id, p.FirstName, p.LastName, s.RegistrationNo FROM person p INNER JOIN student s ON p.Id = s.Id WHERE s.Id NOT IN (SELECT StudentId FROM groupstudent) ORDER BY p.FirstName";
            DataTable dt = db.ExecuteQuery(query);
            dgvAvailableStudents.DataSource = dt;
            if (dgvAvailableStudents.Columns["Id"] != null) dgvAvailableStudents.Columns["Id"].Visible = false;
        }

        private void LoadAssignedStudents()
        {
            string query = $"SELECT p.Id, p.FirstName, p.LastName, s.RegistrationNo FROM person p INNER JOIN student s ON p.Id = s.Id INNER JOIN groupstudent gs ON s.Id = gs.StudentId WHERE gs.GroupId = {currentGroupId}";
            DataTable dt = db.ExecuteQuery(query);
            dgvAssignedStudents.DataSource = dt;
            if (dgvAssignedStudents.Columns["Id"] != null) dgvAssignedStudents.Columns["Id"].Visible = false;
        }

        private void BtnAssign_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvAvailableStudents.SelectedRows.Count == 0) { MessageBox.Show("Select a student to assign"); return; }
                int studentId = Convert.ToInt32(dgvAvailableStudents.SelectedRows[0].Cells["Id"].Value);
                db.ExecuteNonQuery($"INSERT INTO groupstudent (GroupId, StudentId, Status, AssignmentDate) VALUES ({currentGroupId}, {studentId}, 3, '{DateTime.Now:yyyy-MM-dd HH:mm:ss}')");
                LoadAvailableStudents();
                LoadAssignedStudents();
                MessageBox.Show("✅ Student Assigned!");
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvAssignedStudents.SelectedRows.Count == 0) { MessageBox.Show("Select a student to remove"); return; }
                int studentId = Convert.ToInt32(dgvAssignedStudents.SelectedRows[0].Cells["Id"].Value);
                db.ExecuteNonQuery($"DELETE FROM groupstudent WHERE GroupId={currentGroupId} AND StudentId={studentId}");
                LoadAvailableStudents();
                LoadAssignedStudents();
                MessageBox.Show("✅ Student Removed!");
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }
    }
}