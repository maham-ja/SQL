using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace MidDb26_25GA49
{
    public class AssignProjectToGroupForm : Form
    {
        DatabaseHelper db = new DatabaseHelper();
        int currentGroupId;

        private ComboBox cmbProjects;
        private Button btnAssign, btnClose;
        private Label lblCurrentProject;

        public AssignProjectToGroupForm(int groupId)
        {
            currentGroupId = groupId;
            InitializeForm();
            LoadProjects();
            LoadCurrentProject();
        }

        private void InitializeForm()
        {
            this.Text = "Assign Project to Group";
            this.Size = new Size(500, 250);
            this.StartPosition = FormStartPosition.CenterScreen;

            Label lblGroup = new Label() { Text = $"Group ID: {currentGroupId}", Location = new Point(20, 20), Size = new Size(200, 30), Font = new Font("Segoe UI", 12, FontStyle.Bold) };
            this.Controls.Add(lblGroup);

            Label lblProject = new Label() { Text = "Select Project:", Location = new Point(20, 70), Size = new Size(100, 25) };
            this.Controls.Add(lblProject);

            cmbProjects = new ComboBox() { Location = new Point(130, 70), Size = new Size(300, 25), DropDownStyle = ComboBoxStyle.DropDownList };
            this.Controls.Add(cmbProjects);

            lblCurrentProject = new Label() { Text = "Current Project: None", Location = new Point(20, 110), Size = new Size(400, 25), ForeColor = Color.Blue };
            this.Controls.Add(lblCurrentProject);

            btnAssign = new Button() { Text = "ASSIGN PROJECT", Location = new Point(130, 150), Size = new Size(150, 35), BackColor = Color.LightGreen };
            btnAssign.Click += BtnAssign_Click;
            this.Controls.Add(btnAssign);

            btnClose = new Button() { Text = "CLOSE", Location = new Point(300, 150), Size = new Size(100, 35), BackColor = Color.LightGray };
            btnClose.Click += (s, e) => this.Close();
            this.Controls.Add(btnClose);
        }

        private void LoadProjects()
        {
            DataTable dt = db.ExecuteQuery("SELECT Id, Title FROM project ORDER BY Title");
            cmbProjects.DataSource = dt;
            cmbProjects.DisplayMember = "Title";
            cmbProjects.ValueMember = "Id";
        }

        private void LoadCurrentProject()
        {
            object result = db.ExecuteScalar($"SELECT p.Title FROM project p INNER JOIN groupproject gp ON p.Id = gp.ProjectId WHERE gp.GroupId = {currentGroupId}");
            lblCurrentProject.Text = result != null ? $"Current Project: {result}" : "Current Project: None";
        }

        private void BtnAssign_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbProjects.SelectedValue == null) { MessageBox.Show("Select a project"); return; }

                db.ExecuteNonQuery($"DELETE FROM groupproject WHERE GroupId={currentGroupId}");
                db.ExecuteNonQuery($"INSERT INTO groupproject (ProjectId, GroupId, AssignmentDate) VALUES ({cmbProjects.SelectedValue}, {currentGroupId}, '{DateTime.Now:yyyy-MM-dd HH:mm:ss}')");

                MessageBox.Show("✅ Project Assigned to Group!");
                LoadCurrentProject();
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }
    }
}