using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace MidDb26_25GA49
{
    public class ManageStudentsForm : Form
    {
        DatabaseHelper db = new DatabaseHelper();

        private GroupBox gbStudentInfo;
        private Label lblFirstName, lblLastName, lblEmail, lblContact, lblDOB, lblGender, lblRegNo;
        private TextBox txtFirstName, txtLastName, txtEmail, txtContact, txtRegNo;
        private DateTimePicker dtpDOB;
        private ComboBox cmbGender;
        private Button btnAdd, btnUpdate, btnDelete, btnRefresh;
        private DataGridView dgvStudents;

        public ManageStudentsForm()
        {
            InitializeForm();
            LoadGenders();
            LoadStudents();
        }

        private void InitializeForm()
        {
            this.Text = "Manage Students";
            this.Size = new Size(900, 600);
            this.StartPosition = FormStartPosition.CenterScreen;

            // GroupBox
            gbStudentInfo = new GroupBox();
            gbStudentInfo.Text = "Student Information";
            gbStudentInfo.Size = new Size(880, 180);
            gbStudentInfo.Location = new Point(10, 10);
            gbStudentInfo.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            this.Controls.Add(gbStudentInfo);

            // First Name
            lblFirstName = new Label();
            lblFirstName.Text = "First Name:";
            lblFirstName.Location = new Point(20, 30);
            lblFirstName.Size = new Size(80, 25);
            gbStudentInfo.Controls.Add(lblFirstName);

            txtFirstName = new TextBox();
            txtFirstName.Location = new Point(110, 27);
            txtFirstName.Size = new Size(150, 25);
            gbStudentInfo.Controls.Add(txtFirstName);

            // Last Name
            lblLastName = new Label();
            lblLastName.Text = "Last Name:";
            lblLastName.Location = new Point(20, 60);
            lblLastName.Size = new Size(80, 25);
            gbStudentInfo.Controls.Add(lblLastName);

            txtLastName = new TextBox();
            txtLastName.Location = new Point(110, 57);
            txtLastName.Size = new Size(150, 25);
            gbStudentInfo.Controls.Add(txtLastName);

            // Email
            lblEmail = new Label();
            lblEmail.Text = "Email:";
            lblEmail.Location = new Point(20, 90);
            lblEmail.Size = new Size(80, 25);
            gbStudentInfo.Controls.Add(lblEmail);

            txtEmail = new TextBox();
            txtEmail.Location = new Point(110, 87);
            txtEmail.Size = new Size(150, 25);
            gbStudentInfo.Controls.Add(txtEmail);

            // Contact
            lblContact = new Label();
            lblContact.Text = "Contact:";
            lblContact.Location = new Point(20, 120);
            lblContact.Size = new Size(80, 25);
            gbStudentInfo.Controls.Add(lblContact);

            txtContact = new TextBox();
            txtContact.Location = new Point(110, 117);
            txtContact.Size = new Size(150, 25);
            gbStudentInfo.Controls.Add(txtContact);

            // Date of Birth
            lblDOB = new Label();
            lblDOB.Text = "Date of Birth:";
            lblDOB.Location = new Point(300, 30);
            lblDOB.Size = new Size(100, 25);
            gbStudentInfo.Controls.Add(lblDOB);

            dtpDOB = new DateTimePicker();
            dtpDOB.Location = new Point(410, 27);
            dtpDOB.Size = new Size(150, 25);
            dtpDOB.Format = DateTimePickerFormat.Short;
            gbStudentInfo.Controls.Add(dtpDOB);

            // Gender
            lblGender = new Label();
            lblGender.Text = "Gender:";
            lblGender.Location = new Point(300, 60);
            lblGender.Size = new Size(80, 25);
            gbStudentInfo.Controls.Add(lblGender);

            cmbGender = new ComboBox();
            cmbGender.Location = new Point(410, 57);
            cmbGender.Size = new Size(150, 25);
            cmbGender.DropDownStyle = ComboBoxStyle.DropDownList;
            gbStudentInfo.Controls.Add(cmbGender);

            // Registration No
            lblRegNo = new Label();
            lblRegNo.Text = "Registration No:";
            lblRegNo.Location = new Point(300, 90);
            lblRegNo.Size = new Size(110, 25);
            gbStudentInfo.Controls.Add(lblRegNo);

            txtRegNo = new TextBox();
            txtRegNo.Location = new Point(410, 87);
            txtRegNo.Size = new Size(150, 25);
            gbStudentInfo.Controls.Add(txtRegNo);

            // Buttons
            btnAdd = new Button();
            btnAdd.Text = "➕ ADD";
            btnAdd.BackColor = Color.LightGreen;
            btnAdd.Size = new Size(100, 35);
            btnAdd.Location = new Point(620, 27);
            btnAdd.Click += BtnAdd_Click;
            gbStudentInfo.Controls.Add(btnAdd);

            btnUpdate = new Button();
            btnUpdate.Text = "✏️ UPDATE";
            btnUpdate.BackColor = Color.LightYellow;
            btnUpdate.Size = new Size(100, 35);
            btnUpdate.Location = new Point(620, 68);
            btnUpdate.Click += BtnUpdate_Click;
            gbStudentInfo.Controls.Add(btnUpdate);

            btnDelete = new Button();
            btnDelete.Text = "🗑️ DELETE";
            btnDelete.BackColor = Color.LightCoral;
            btnDelete.Size = new Size(100, 35);
            btnDelete.Location = new Point(620, 109);
            btnDelete.Click += BtnDelete_Click;
            gbStudentInfo.Controls.Add(btnDelete);

            btnRefresh = new Button();
            btnRefresh.Text = "🔄 REFRESH";
            btnRefresh.BackColor = Color.LightGray;
            btnRefresh.Size = new Size(100, 30);
            btnRefresh.Location = new Point(620, 150);
            btnRefresh.Click += BtnRefresh_Click;
            gbStudentInfo.Controls.Add(btnRefresh);

            // DataGridView
            dgvStudents = new DataGridView();
            dgvStudents.Location = new Point(10, 200);
            dgvStudents.Size = new Size(880, 360);
            dgvStudents.AllowUserToAddRows = false;
            dgvStudents.ReadOnly = true;
            dgvStudents.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStudents.RowHeaderMouseClick += DgvStudents_RowHeaderMouseClick;
            this.Controls.Add(dgvStudents);
        }

        private void LoadGenders()
        {
            try
            {
                DataTable dt = db.ExecuteQuery("SELECT Id, Value FROM lookup WHERE Category = 'GENDER'");
                if (dt != null && dt.Rows.Count > 0)
                {
                    cmbGender.DataSource = dt;
                    cmbGender.DisplayMember = "Value";
                    cmbGender.ValueMember = "Id";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading genders: " + ex.Message);
            }
        }

        private void LoadStudents()
        {
            try
            {
                string query = @"
                    SELECT 
                        p.Id,
                        p.FirstName,
                        p.LastName,
                        p.Email,
                        p.Contact,
                        p.DateOfBirth,
                        l.Value AS Gender,
                        s.RegistrationNo
                    FROM person p
                    INNER JOIN student s ON p.Id = s.Id
                    INNER JOIN lookup l ON p.Gender = l.Id
                    ORDER BY p.Id DESC";

                DataTable dt = db.ExecuteQuery(query);
                dgvStudents.DataSource = dt;

                if (dgvStudents.Columns["Id"] != null)
                    dgvStudents.Columns["Id"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading students: " + ex.Message);
            }
        }

        private void ClearFields()
        {
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtEmail.Text = "";
            txtContact.Text = "";
            dtpDOB.Value = DateTime.Now.AddYears(-20);
            txtRegNo.Text = "";
            if (cmbGender.Items.Count > 0)
                cmbGender.SelectedIndex = 0;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtFirstName.Text))
                {
                    MessageBox.Show("Please enter First Name");
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtEmail.Text))
                {
                    MessageBox.Show("Please enter Email");
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtRegNo.Text))
                {
                    MessageBox.Show("Please enter Registration Number");
                    return;
                }

                string checkQuery = $"SELECT COUNT(*) FROM student WHERE RegistrationNo = '{txtRegNo.Text.Trim()}'";
                object result = db.ExecuteScalar(checkQuery);
                int count = result != null ? Convert.ToInt32(result) : 0;

                if (count > 0)
                {
                    MessageBox.Show("Registration Number already exists!");
                    return;
                }

                string personQuery = $@"
                    INSERT INTO person (FirstName, LastName, Contact, Email, DateOfBirth, Gender)
                    VALUES (
                        '{txtFirstName.Text.Trim().Replace("'", "''")}',
                        '{txtLastName.Text.Trim().Replace("'", "''")}',
                        '{txtContact.Text.Trim().Replace("'", "''")}',
                        '{txtEmail.Text.Trim().Replace("'", "''")}',
                        '{dtpDOB.Value.ToString("yyyy-MM-dd")}',
                        {cmbGender.SelectedValue}
                    )";
                db.ExecuteNonQuery(personQuery);

                string getIdQuery = "SELECT LAST_INSERT_ID()";
                object idResult = db.ExecuteScalar(getIdQuery);
                int personId = idResult != null ? Convert.ToInt32(idResult) : 0;

                string studentQuery = $@"
                    INSERT INTO student (Id, RegistrationNo)
                    VALUES ({personId}, '{txtRegNo.Text.Trim().Replace("'", "''")}')";
                db.ExecuteNonQuery(studentQuery);

                MessageBox.Show("✅ Student added successfully!");
                ClearFields();
                LoadStudents();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void DgvStudents_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgvStudents.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvStudents.SelectedRows[0];
                txtFirstName.Text = row.Cells["FirstName"].Value.ToString();
                txtLastName.Text = row.Cells["LastName"].Value.ToString();
                txtEmail.Text = row.Cells["Email"].Value.ToString();
                txtContact.Text = row.Cells["Contact"].Value.ToString();
                dtpDOB.Value = Convert.ToDateTime(row.Cells["DateOfBirth"].Value);
                txtRegNo.Text = row.Cells["RegistrationNo"].Value.ToString();
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvStudents.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select a student to update");
                    return;
                }

                int studentId = Convert.ToInt32(dgvStudents.SelectedRows[0].Cells["Id"].Value);

                string updateQuery = $@"
                    UPDATE person SET 
                        FirstName = '{txtFirstName.Text.Trim().Replace("'", "''")}',
                        LastName = '{txtLastName.Text.Trim().Replace("'", "''")}',
                        Contact = '{txtContact.Text.Trim().Replace("'", "''")}',
                        Email = '{txtEmail.Text.Trim().Replace("'", "''")}',
                        DateOfBirth = '{dtpDOB.Value.ToString("yyyy-MM-dd")}',
                        Gender = {cmbGender.SelectedValue}
                    WHERE Id = {studentId}";
                db.ExecuteNonQuery(updateQuery);

                string updateStudentQuery = $@"
                    UPDATE student SET 
                        RegistrationNo = '{txtRegNo.Text.Trim().Replace("'", "''")}'
                    WHERE Id = {studentId}";
                db.ExecuteNonQuery(updateStudentQuery);

                MessageBox.Show("✅ Student updated successfully!");
                LoadStudents();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvStudents.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select a student to delete");
                    return;
                }

                DialogResult result = MessageBox.Show("Are you sure?", "Confirm",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    int studentId = Convert.ToInt32(dgvStudents.SelectedRows[0].Cells["Id"].Value);

                    db.ExecuteNonQuery($"DELETE FROM groupstudent WHERE StudentId = {studentId}");
                    db.ExecuteNonQuery($"DELETE FROM student WHERE Id = {studentId}");
                    db.ExecuteNonQuery($"DELETE FROM person WHERE Id = {studentId}");

                    MessageBox.Show("✅ Student deleted successfully!");
                    LoadStudents();
                    ClearFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            LoadStudents();
            ClearFields();
        }
    }
}