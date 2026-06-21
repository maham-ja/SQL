using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace MidDb26_25GA49
{
    public class ManageGroupsForm : Form
    {
        DatabaseHelper db = new DatabaseHelper();

        private Button btnCreateGroup, btnDeleteGroup, btnAssignStudents, btnAssignProject, btnRefresh;
        private DataGridView dgvGroups;

        public ManageGroupsForm()
        {
            InitializeForm();
            LoadGroups();
        }

        private void InitializeForm()
        {
            this.Text = "Manage Groups";
            this.Size = new Size(900, 600);
            this.StartPosition = FormStartPosition.CenterScreen;

            btnCreateGroup = new Button() { Text = "➕ CREATE NEW GROUP", Location = new Point(20, 20), Size = new Size(180, 40), BackColor = Color.LightGreen };
            btnCreateGroup.Click += BtnCreateGroup_Click;
            this.Controls.Add(btnCreateGroup);

            btnDeleteGroup = new Button() { Text = "🗑️ DELETE GROUP", Location = new Point(210, 20), Size = new Size(180, 40), BackColor = Color.LightCoral };
            btnDeleteGroup.Click += BtnDeleteGroup_Click;
            this.Controls.Add(btnDeleteGroup);

            btnAssignStudents = new Button() { Text = "👥 ASSIGN STUDENTS", Location = new Point(400, 20), Size = new Size(180, 40), BackColor = Color.LightBlue };
            btnAssignStudents.Click += BtnAssignStudents_Click;
            this.Controls.Add(btnAssignStudents);

            btnAssignProject = new Button() { Text = "📁 ASSIGN PROJECT", Location = new Point(590, 20), Size = new Size(180, 40), BackColor = Color.LightYellow };
            btnAssignProject.Click += BtnAssignProject_Click;
            this.Controls.Add(btnAssignProject);

            btnRefresh = new Button() { Text = "🔄 REFRESH", Location = new Point(780, 20), Size = new Size(100, 40), BackColor = Color.LightGray };
            btnRefresh.Click += BtnRefresh_Click;
            this.Controls.Add(btnRefresh);

            dgvGroups = new DataGridView() { Location = new Point(20, 80), Size = new Size(860, 480), AllowUserToAddRows = false, ReadOnly = true, SelectionMode = DataGridViewSelectionMode.FullRowSelect };
            this.Controls.Add(dgvGroups);
        }

        private void LoadGroups()
        {
            string query = @"SELECT g.Id, g.Created_On, COUNT(gs.StudentId) AS TotalStudents FROM `group` g LEFT JOIN groupstudent gs ON g.Id = gs.GroupId GROUP BY g.Id, g.Created_On ORDER BY g.Id DESC";
            DataTable dt = db.ExecuteQuery(query);
            dgvGroups.DataSource = dt;
        }

        private void BtnCreateGroup_Click(object sender, EventArgs e)
        {
            try
            {
                db.ExecuteNonQuery($"INSERT INTO `group` (Created_On) VALUES ('{DateTime.Now:yyyy-MM-dd}')");
                MessageBox.Show("✅ New Group Created!");
                LoadGroups();
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        private void BtnDeleteGroup_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvGroups.SelectedRows.Count == 0) { MessageBox.Show("Select a group to delete"); return; }
                if (MessageBox.Show("Delete group and all data?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int groupId = Convert.ToInt32(dgvGroups.SelectedRows[0].Cells["Id"].Value);
                    db.ExecuteNonQuery($"DELETE FROM groupevaluation WHERE GroupId={groupId}");
                    db.ExecuteNonQuery($"DELETE FROM groupproject WHERE GroupId={groupId}");
                    db.ExecuteNonQuery($"DELETE FROM groupstudent WHERE GroupId={groupId}");
                    db.ExecuteNonQuery($"DELETE FROM `group` WHERE Id={groupId}");
                    MessageBox.Show("✅ Group Deleted!");
                    LoadGroups();
                }
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        private void BtnAssignStudents_Click(object sender, EventArgs e)
        {
            if (dgvGroups.SelectedRows.Count == 0) { MessageBox.Show("Select a group first"); return; }
            int groupId = Convert.ToInt32(dgvGroups.SelectedRows[0].Cells["Id"].Value);
            AssignStudentsToGroupForm form = new AssignStudentsToGroupForm(groupId);
            form.ShowDialog();
            LoadGroups();
        }

        private void BtnAssignProject_Click(object sender, EventArgs e)
        {
            if (dgvGroups.SelectedRows.Count == 0) { MessageBox.Show("Select a group first"); return; }
            int groupId = Convert.ToInt32(dgvGroups.SelectedRows[0].Cells["Id"].Value);
            AssignProjectToGroupForm form = new AssignProjectToGroupForm(groupId);
            form.ShowDialog();
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            LoadGroups();
        }
    }
}