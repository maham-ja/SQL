using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace MidDb26_25GA49
{
    public class AssignMarksForm : Form
    {
        DatabaseHelper db = new DatabaseHelper();
        int currentEvaluationId;
        string evaluationName;

        private ComboBox cmbGroups;
        private TextBox txtObtainedMarks;
        private Button btnSaveMarks, btnClose;
        private Label lblMaxMarks, lblStatus;

        public AssignMarksForm(int evalId, string evalName)
        {
            currentEvaluationId = evalId;
            evaluationName = evalName;
            InitializeForm();
            LoadGroups();
        }

        private void InitializeForm()
        {
            this.Text = $"Assign Marks - {evaluationName}";
            this.Size = new Size(500, 300);
            this.StartPosition = FormStartPosition.CenterScreen;

            Label lblTitle = new Label() { Text = $"Evaluation: {evaluationName}", Location = new Point(20, 20), Size = new Size(450, 30), Font = new Font("Segoe UI", 12, FontStyle.Bold), ForeColor = Color.DarkBlue };
            this.Controls.Add(lblTitle);

            Label lblGroup = new Label() { Text = "Select Group:", Location = new Point(20, 70), Size = new Size(100, 25) };
            this.Controls.Add(lblGroup);

            cmbGroups = new ComboBox() { Location = new Point(130, 70), Size = new Size(300, 25), DropDownStyle = ComboBoxStyle.DropDownList };
            cmbGroups.SelectedIndexChanged += CmbGroups_SelectedIndexChanged;
            this.Controls.Add(cmbGroups);

            Label lblMarks = new Label() { Text = "Obtained Marks:", Location = new Point(20, 120), Size = new Size(100, 25) };
            this.Controls.Add(lblMarks);

            txtObtainedMarks = new TextBox() { Location = new Point(130, 120), Size = new Size(100, 25) };
            this.Controls.Add(txtObtainedMarks);

            lblMaxMarks = new Label() { Text = "", Location = new Point(240, 120), Size = new Size(150, 25), ForeColor = Color.Gray };
            this.Controls.Add(lblMaxMarks);

            lblStatus = new Label() { Text = "", Location = new Point(20, 160), Size = new Size(450, 30), ForeColor = Color.Blue };
            this.Controls.Add(lblStatus);

            btnSaveMarks = new Button() { Text = "💾 SAVE MARKS", Location = new Point(130, 210), Size = new Size(120, 35), BackColor = Color.LightGreen };
            btnSaveMarks.Click += BtnSaveMarks_Click;
            this.Controls.Add(btnSaveMarks);

            btnClose = new Button() { Text = "CLOSE", Location = new Point(270, 210), Size = new Size(100, 35), BackColor = Color.LightGray };
            btnClose.Click += (s, e) => this.Close();
            this.Controls.Add(btnClose);
        }

        private void LoadGroups()
        {
            DataTable dt = db.ExecuteQuery("SELECT g.Id, CONCAT('Group ', g.Id, ' (Created: ', g.Created_On, ')') AS GroupName FROM `group` g ORDER BY g.Id DESC");
            cmbGroups.DataSource = dt;
            cmbGroups.DisplayMember = "GroupName";
            cmbGroups.ValueMember = "Id";
        }

        private void CmbGroups_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbGroups.SelectedValue == null) return;
                int groupId = Convert.ToInt32(cmbGroups.SelectedValue);

                // Get max marks for this evaluation
                object maxMarks = db.ExecuteScalar($"SELECT TotalMarks FROM evaluation WHERE Id={currentEvaluationId}");
                lblMaxMarks.Text = $"Max Marks: {maxMarks}";

                // Check if marks already assigned
                object existingMarks = db.ExecuteScalar($"SELECT ObtainedMarks FROM groupevaluation WHERE GroupId={groupId} AND EvaluationId={currentEvaluationId}");

                if (existingMarks != null && existingMarks.ToString() != "")
                {
                    txtObtainedMarks.Text = existingMarks.ToString();
                    lblStatus.Text = "⚠️ Marks already assigned. You can update them.";
                    lblStatus.ForeColor = Color.Orange;
                }
                else
                {
                    txtObtainedMarks.Text = "";
                    lblStatus.Text = "✅ No marks assigned yet. Enter marks and save.";
                    lblStatus.ForeColor = Color.Green;
                }
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        private void BtnSaveMarks_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbGroups.SelectedValue == null) { MessageBox.Show("Select a group"); return; }
                if (string.IsNullOrWhiteSpace(txtObtainedMarks.Text)) { MessageBox.Show("Enter obtained marks"); return; }

                int groupId = Convert.ToInt32(cmbGroups.SelectedValue);
                int obtainedMarks = Convert.ToInt32(txtObtainedMarks.Text);
                object maxMarksObj = db.ExecuteScalar($"SELECT TotalMarks FROM evaluation WHERE Id={currentEvaluationId}");
                int maxMarks = Convert.ToInt32(maxMarksObj);

                if (obtainedMarks > maxMarks)
                {
                    MessageBox.Show($"Marks cannot exceed {maxMarks}!");
                    return;
                }

                // Check if already exists
                object existing = db.ExecuteScalar($"SELECT COUNT(*) FROM groupevaluation WHERE GroupId={groupId} AND EvaluationId={currentEvaluationId}");
                int exists = Convert.ToInt32(existing);

                if (exists > 0)
                {
                    db.ExecuteNonQuery($"UPDATE groupevaluation SET ObtainedMarks={obtainedMarks}, EvaluationDate='{DateTime.Now:yyyy-MM-dd HH:mm:ss}' WHERE GroupId={groupId} AND EvaluationId={currentEvaluationId}");
                    MessageBox.Show("✅ Marks Updated!");
                }
                else
                {
                    db.ExecuteNonQuery($"INSERT INTO groupevaluation (GroupId, EvaluationId, ObtainedMarks, EvaluationDate) VALUES ({groupId}, {currentEvaluationId}, {obtainedMarks}, '{DateTime.Now:yyyy-MM-dd HH:mm:ss}')");
                    MessageBox.Show("✅ Marks Saved!");
                }

                lblStatus.Text = "✅ Marks saved successfully!";
                lblStatus.ForeColor = Color.Green;
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }
    }
}