using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace MidDb26_25GA49
{
    public class ManageAdvisorsForm : Form
    {
        DatabaseHelper db = new DatabaseHelper();

        private TextBox txtFirstName, txtLastName, txtEmail, txtContact, txtSalary;
        private ComboBox cmbDesignation;
        private Button btnAdd, btnUpdate, btnDelete, btnRefresh;
        private DataGridView dgvAdvisors;

        public ManageAdvisorsForm()
        {
            InitializeForm();
            LoadDesignations();
            LoadAdvisors();
        }

        private void InitializeForm()
        {
            this.Text = "Manage Advisors";
            this.Size = new Size(900, 600);
            this.StartPosition = FormStartPosition.CenterScreen;

            int y = 20;

            Label lblFirstName = new Label() { Text = "First Name:", Location = new Point(20, y), Size = new Size(80, 25) };
            txtFirstName = new TextBox() { Location = new Point(110, y), Size = new Size(150, 25) };
            this.Controls.Add(lblFirstName);
            this.Controls.Add(txtFirstName);

            y += 35;
            Label lblLastName = new Label() { Text = "Last Name:", Location = new Point(20, y), Size = new Size(80, 25) };
            txtLastName = new TextBox() { Location = new Point(110, y), Size = new Size(150, 25) };
            this.Controls.Add(lblLastName);
            this.Controls.Add(txtLastName);

            y += 35;
            Label lblEmail = new Label() { Text = "Email:", Location = new Point(20, y), Size = new Size(80, 25) };
            txtEmail = new TextBox() { Location = new Point(110, y), Size = new Size(150, 25) };
            this.Controls.Add(lblEmail);
            this.Controls.Add(txtEmail);

            y += 35;
            Label lblContact = new Label() { Text = "Contact:", Location = new Point(20, y), Size = new Size(80, 25) };
            txtContact = new TextBox() { Location = new Point(110, y), Size = new Size(150, 25) };
            this.Controls.Add(lblContact);
            this.Controls.Add(txtContact);

            y = 20;
            Label lblDesignation = new Label() { Text = "Designation:", Location = new Point(300, y), Size = new Size(90, 25) };
            cmbDesignation = new ComboBox() { Location = new Point(400, y), Size = new Size(150, 25), DropDownStyle = ComboBoxStyle.DropDownList };
            this.Controls.Add(lblDesignation);
            this.Controls.Add(cmbDesignation);

            y += 35;
            Label lblSalary = new Label() { Text = "Salary:", Location = new Point(300, y), Size = new Size(80, 25) };
            txtSalary = new TextBox() { Location = new Point(400, y), Size = new Size(150, 25) };
            this.Controls.Add(lblSalary);
            this.Controls.Add(txtSalary);

            btnAdd = new Button() { Text = "ADD", Location = new Point(600, 30), Size = new Size(100, 35), BackColor = Color.LightGreen };
            btnAdd.Click += BtnAdd_Click;
            this.Controls.Add(btnAdd);

            btnUpdate = new Button() { Text = "UPDATE", Location = new Point(600, 80), Size = new Size(100, 35), BackColor = Color.LightYellow };
            btnUpdate.Click += BtnUpdate_Click;
            this.Controls.Add(btnUpdate);

            btnDelete = new Button() { Text = "DELETE", Location = new Point(600, 130), Size = new Size(100, 35), BackColor = Color.LightCoral };
            btnDelete.Click += BtnDelete_Click;
            this.Controls.Add(btnDelete);

            btnRefresh = new Button() { Text = "REFRESH", Location = new Point(600, 180), Size = new Size(100, 30), BackColor = Color.LightGray };
            btnRefresh.Click += BtnRefresh_Click;
            this.Controls.Add(btnRefresh);

            dgvAdvisors = new DataGridView() { Location = new Point(20, 220), Size = new Size(850, 340), AllowUserToAddRows = false, ReadOnly = true, SelectionMode = DataGridViewSelectionMode.FullRowSelect };
            dgvAdvisors.RowHeaderMouseClick += DgvAdvisors_RowHeaderMouseClick;
            this.Controls.Add(dgvAdvisors);
        }

        private void LoadDesignations()
        {
            DataTable dt = db.ExecuteQuery("SELECT Id, Value FROM lookup WHERE Category = 'DESIGNATION'");
            if (dt != null && dt.Rows.Count > 0)
            {
                cmbDesignation.DataSource = dt;
                cmbDesignation.DisplayMember = "Value";
                cmbDesignation.ValueMember = "Id";
            }
        }

        private void LoadAdvisors()
        {
            string query = @"SELECT p.Id, p.FirstName, p.LastName, p.Email, p.Contact, l.Value AS Designation, a.Salary 
                FROM person p INNER JOIN advisor a ON p.Id = a.Id INNER JOIN lookup l ON a.Designation = l.Id ORDER BY p.Id DESC";
            DataTable dt = db.ExecuteQuery(query);
            dgvAdvisors.DataSource = dt;
            if (dgvAdvisors.Columns["Id"] != null) dgvAdvisors.Columns["Id"].Visible = false;
        }

        private void ClearFields()
        {
            txtFirstName.Text = ""; txtLastName.Text = ""; txtEmail.Text = ""; txtContact.Text = ""; txtSalary.Text = "";
            if (cmbDesignation.Items.Count > 0) cmbDesignation.SelectedIndex = 0;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtFirstName.Text)) { MessageBox.Show("Enter First Name"); return; }
                if (string.IsNullOrWhiteSpace(txtEmail.Text)) { MessageBox.Show("Enter Email"); return; }

                string personQuery = $"INSERT INTO person (FirstName, LastName, Contact, Email) VALUES ('{txtFirstName.Text.Trim()}', '{txtLastName.Text.Trim()}', '{txtContact.Text.Trim()}', '{txtEmail.Text.Trim()}')";
                db.ExecuteNonQuery(personQuery);

                object personId = db.ExecuteScalar("SELECT LAST_INSERT_ID()");
                db.ExecuteNonQuery($"INSERT INTO advisor (Id, Designation, Salary) VALUES ({personId}, {cmbDesignation.SelectedValue}, {txtSalary.Text})");

                MessageBox.Show("✅ Advisor Added!");
                ClearFields();
                LoadAdvisors();
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        private void DgvAdvisors_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgvAdvisors.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvAdvisors.SelectedRows[0];
                txtFirstName.Text = row.Cells["FirstName"].Value.ToString();
                txtLastName.Text = row.Cells["LastName"].Value.ToString();
                txtEmail.Text = row.Cells["Email"].Value.ToString();
                txtContact.Text = row.Cells["Contact"].Value.ToString();
                txtSalary.Text = row.Cells["Salary"].Value.ToString();
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvAdvisors.SelectedRows.Count == 0) { MessageBox.Show("Select an advisor to update"); return; }
                int advisorId = Convert.ToInt32(dgvAdvisors.SelectedRows[0].Cells["Id"].Value);
                db.ExecuteNonQuery($"UPDATE person SET FirstName='{txtFirstName.Text}', LastName='{txtLastName.Text}', Contact='{txtContact.Text}', Email='{txtEmail.Text}' WHERE Id={advisorId}");
                db.ExecuteNonQuery($"UPDATE advisor SET Designation={cmbDesignation.SelectedValue}, Salary={txtSalary.Text} WHERE Id={advisorId}");
                MessageBox.Show("✅ Advisor Updated!");
                LoadAdvisors();
                ClearFields();
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvAdvisors.SelectedRows.Count == 0) { MessageBox.Show("Select an advisor to delete"); return; }
                if (MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int advisorId = Convert.ToInt32(dgvAdvisors.SelectedRows[0].Cells["Id"].Value);
                    db.ExecuteNonQuery($"DELETE FROM projectadvisor WHERE AdvisorId={advisorId}");
                    db.ExecuteNonQuery($"DELETE FROM advisor WHERE Id={advisorId}");
                    db.ExecuteNonQuery($"DELETE FROM person WHERE Id={advisorId}");
                    MessageBox.Show("✅ Advisor Deleted!");
                    LoadAdvisors();
                    ClearFields();
                }
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            LoadAdvisors();
            ClearFields();
        }
    }
}