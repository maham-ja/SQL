using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace MidDb26_25GA49
{
    public class ManageProjectsForm : Form
    {
        DatabaseHelper db = new DatabaseHelper();

        private TextBox txtTitle, txtDescription;
        private Button btnAdd, btnUpdate, btnDelete, btnRefresh;
        private DataGridView dgvProjects;

        public ManageProjectsForm()
        {
            InitializeForm();
            LoadProjects();
        }

        private void InitializeForm()
        {
            this.Text = "Manage Projects";
            this.Size = new Size(900, 600);
            this.StartPosition = FormStartPosition.CenterScreen;

            Label lblTitle = new Label() { Text = "Title:", Location = new Point(20, 20), Size = new Size(80, 25) };
            txtTitle = new TextBox() { Location = new Point(110, 20), Size = new Size(300, 25) };
            this.Controls.Add(lblTitle);
            this.Controls.Add(txtTitle);

            Label lblDescription = new Label() { Text = "Description:", Location = new Point(20, 60), Size = new Size(80, 25) };
            txtDescription = new TextBox() { Location = new Point(110, 60), Size = new Size(500, 60), Multiline = true, Height = 60 };
            this.Controls.Add(lblDescription);
            this.Controls.Add(txtDescription);

            btnAdd = new Button() { Text = "ADD", Location = new Point(650, 20), Size = new Size(100, 35), BackColor = Color.LightGreen };
            btnAdd.Click += BtnAdd_Click;
            this.Controls.Add(btnAdd);

            btnUpdate = new Button() { Text = "UPDATE", Location = new Point(650, 60), Size = new Size(100, 35), BackColor = Color.LightYellow };
            btnUpdate.Click += BtnUpdate_Click;
            this.Controls.Add(btnUpdate);

            btnDelete = new Button() { Text = "DELETE", Location = new Point(650, 100), Size = new Size(100, 35), BackColor = Color.LightCoral };
            btnDelete.Click += BtnDelete_Click;
            this.Controls.Add(btnDelete);

            btnRefresh = new Button() { Text = "REFRESH", Location = new Point(650, 140), Size = new Size(100, 30), BackColor = Color.LightGray };
            btnRefresh.Click += BtnRefresh_Click;
            this.Controls.Add(btnRefresh);

            dgvProjects = new DataGridView() { Location = new Point(20, 140), Size = new Size(850, 420), AllowUserToAddRows = false, ReadOnly = true, SelectionMode = DataGridViewSelectionMode.FullRowSelect };
            dgvProjects.RowHeaderMouseClick += DgvProjects_RowHeaderMouseClick;
            this.Controls.Add(dgvProjects);
        }

        private void LoadProjects()
        {
            DataTable dt = db.ExecuteQuery("SELECT Id, Title, Description FROM project ORDER BY Id DESC");
            dgvProjects.DataSource = dt;
            if (dgvProjects.Columns["Id"] != null) dgvProjects.Columns["Id"].Visible = false;
        }

        private void ClearFields()
        {
            txtTitle.Text = "";
            txtDescription.Text = "";
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtTitle.Text)) { MessageBox.Show("Enter Title"); return; }
                db.ExecuteNonQuery($"INSERT INTO project (Title, Description) VALUES ('{txtTitle.Text.Trim()}', '{txtDescription.Text.Trim()}')");
                MessageBox.Show("✅ Project Added!");
                ClearFields();
                LoadProjects();
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        private void DgvProjects_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgvProjects.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvProjects.SelectedRows[0];
                txtTitle.Text = row.Cells["Title"].Value.ToString();
                txtDescription.Text = row.Cells["Description"].Value.ToString();
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvProjects.SelectedRows.Count == 0) { MessageBox.Show("Select a project to update"); return; }
                int projectId = Convert.ToInt32(dgvProjects.SelectedRows[0].Cells["Id"].Value);
                db.ExecuteNonQuery($"UPDATE project SET Title='{txtTitle.Text.Trim()}', Description='{txtDescription.Text.Trim()}' WHERE Id={projectId}");
                MessageBox.Show("✅ Project Updated!");
                LoadProjects();
                ClearFields();
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvProjects.SelectedRows.Count == 0) { MessageBox.Show("Select a project to delete"); return; }
                if (MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int projectId = Convert.ToInt32(dgvProjects.SelectedRows[0].Cells["Id"].Value);
                    db.ExecuteNonQuery($"DELETE FROM projectadvisor WHERE ProjectId={projectId}");
                    db.ExecuteNonQuery($"DELETE FROM groupproject WHERE ProjectId={projectId}");
                    db.ExecuteNonQuery($"DELETE FROM project WHERE Id={projectId}");
                    MessageBox.Show("✅ Project Deleted!");
                    LoadProjects();
                    ClearFields();
                }
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            LoadProjects();
            ClearFields();
        }
    }
}