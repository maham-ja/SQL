using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace MidDb26_25GA49
{
    public class ManageEvaluationsForm : Form
    {
        DatabaseHelper db = new DatabaseHelper();

        private TextBox txtName, txtTotalMarks, txtWeightage;
        private Button btnAdd, btnUpdate, btnDelete, btnRefresh, btnAssignMarks;
        private DataGridView dgvEvaluations;

        public ManageEvaluationsForm()
        {
            InitializeForm();
            LoadEvaluations();
        }

        private void InitializeForm()
        {
            this.Text = "Manage Evaluations";
            this.Size = new Size(900, 600);
            this.StartPosition = FormStartPosition.CenterScreen;

            int y = 20;

            Label lblName = new Label() { Text = "Evaluation Name:", Location = new Point(20, y), Size = new Size(110, 25) };
            txtName = new TextBox() { Location = new Point(140, y), Size = new Size(200, 25) };
            this.Controls.Add(lblName);
            this.Controls.Add(txtName);

            Label lblTotalMarks = new Label() { Text = "Total Marks:", Location = new Point(370, y), Size = new Size(80, 25) };
            txtTotalMarks = new TextBox() { Location = new Point(460, y), Size = new Size(80, 25) };
            this.Controls.Add(lblTotalMarks);
            this.Controls.Add(txtTotalMarks);

            Label lblWeightage = new Label() { Text = "Weightage:", Location = new Point(560, y), Size = new Size(80, 25) };
            txtWeightage = new TextBox() { Location = new Point(640, y), Size = new Size(80, 25) };
            this.Controls.Add(lblWeightage);
            this.Controls.Add(txtWeightage);

            y = 60;
            btnAdd = new Button() { Text = "➕ ADD", Location = new Point(140, y), Size = new Size(100, 35), BackColor = Color.LightGreen };
            btnAdd.Click += BtnAdd_Click;
            this.Controls.Add(btnAdd);

            btnUpdate = new Button() { Text = "✏️ UPDATE", Location = new Point(260, y), Size = new Size(100, 35), BackColor = Color.LightYellow };
            btnUpdate.Click += BtnUpdate_Click;
            this.Controls.Add(btnUpdate);

            btnDelete = new Button() { Text = "🗑️ DELETE", Location = new Point(380, y), Size = new Size(100, 35), BackColor = Color.LightCoral };
            btnDelete.Click += BtnDelete_Click;
            this.Controls.Add(btnDelete);

            btnRefresh = new Button() { Text = "🔄 REFRESH", Location = new Point(500, y), Size = new Size(100, 35), BackColor = Color.LightGray };
            btnRefresh.Click += BtnRefresh_Click;
            this.Controls.Add(btnRefresh);

            btnAssignMarks = new Button() { Text = "📊 ASSIGN MARKS", Location = new Point(620, y), Size = new Size(150, 35), BackColor = Color.LightBlue };
            btnAssignMarks.Click += BtnAssignMarks_Click;
            this.Controls.Add(btnAssignMarks);

            dgvEvaluations = new DataGridView() { Location = new Point(20, 110), Size = new Size(850, 440), AllowUserToAddRows = false, ReadOnly = true, SelectionMode = DataGridViewSelectionMode.FullRowSelect };
            dgvEvaluations.RowHeaderMouseClick += DgvEvaluations_RowHeaderMouseClick;
            this.Controls.Add(dgvEvaluations);
        }

        private void LoadEvaluations()
        {
            DataTable dt = db.ExecuteQuery("SELECT Id, Name, TotalMarks, TotalWeightage FROM evaluation ORDER BY Id DESC");
            dgvEvaluations.DataSource = dt;
            if (dgvEvaluations.Columns["Id"] != null) dgvEvaluations.Columns["Id"].Visible = false;
        }

        private void ClearFields()
        {
            txtName.Text = "";
            txtTotalMarks.Text = "";
            txtWeightage.Text = "";
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtName.Text)) { MessageBox.Show("Enter Evaluation Name"); return; }
                if (string.IsNullOrWhiteSpace(txtTotalMarks.Text)) { MessageBox.Show("Enter Total Marks"); return; }
                if (string.IsNullOrWhiteSpace(txtWeightage.Text)) { MessageBox.Show("Enter Weightage"); return; }

                db.ExecuteNonQuery($"INSERT INTO evaluation (Name, TotalMarks, TotalWeightage) VALUES ('{txtName.Text.Trim()}', {txtTotalMarks.Text}, {txtWeightage.Text})");
                MessageBox.Show("✅ Evaluation Added!");
                ClearFields();
                LoadEvaluations();
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        private void DgvEvaluations_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgvEvaluations.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvEvaluations.SelectedRows[0];
                txtName.Text = row.Cells["Name"].Value.ToString();
                txtTotalMarks.Text = row.Cells["TotalMarks"].Value.ToString();
                txtWeightage.Text = row.Cells["TotalWeightage"].Value.ToString();
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvEvaluations.SelectedRows.Count == 0) { MessageBox.Show("Select an evaluation to update"); return; }
                int evalId = Convert.ToInt32(dgvEvaluations.SelectedRows[0].Cells["Id"].Value);
                db.ExecuteNonQuery($"UPDATE evaluation SET Name='{txtName.Text.Trim()}', TotalMarks={txtTotalMarks.Text}, TotalWeightage={txtWeightage.Text} WHERE Id={evalId}");
                MessageBox.Show("✅ Evaluation Updated!");
                LoadEvaluations();
                ClearFields();
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvEvaluations.SelectedRows.Count == 0) { MessageBox.Show("Select an evaluation to delete"); return; }
                if (MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int evalId = Convert.ToInt32(dgvEvaluations.SelectedRows[0].Cells["Id"].Value);
                    db.ExecuteNonQuery($"DELETE FROM groupevaluation WHERE EvaluationId={evalId}");
                    db.ExecuteNonQuery($"DELETE FROM evaluation WHERE Id={evalId}");
                    MessageBox.Show("✅ Evaluation Deleted!");
                    LoadEvaluations();
                    ClearFields();
                }
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            LoadEvaluations();
            ClearFields();
        }

        private void BtnAssignMarks_Click(object sender, EventArgs e)
        {
            if (dgvEvaluations.SelectedRows.Count == 0) { MessageBox.Show("Select an evaluation first"); return; }
            int evalId = Convert.ToInt32(dgvEvaluations.SelectedRows[0].Cells["Id"].Value);
            string evalName = dgvEvaluations.SelectedRows[0].Cells["Name"].Value.ToString();
            AssignMarksForm form = new AssignMarksForm(evalId, evalName);
            form.ShowDialog();
        }
    }
}