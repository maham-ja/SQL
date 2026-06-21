using System;
using System.Drawing;
using System.Windows.Forms;

namespace MidDb26_25GA49
{
    public class DashboardForm : Form
    {
        DatabaseHelper db = new DatabaseHelper();

        private Label lblTitle;
        private Button btnStudents;
        private Button btnAdvisors;
        private Button btnProjects;
        private Button btnGroups;
        private Button btnEvaluations;
        private Button btnReports;
        private Label lblStudentCount;
        private Label lblAdvisorCount;
        private Label lblProjectCount;
        private Label lblGroupCount;

        public DashboardForm()
        {
            InitializeForm();
            LoadStatistics();
        }

        private void InitializeForm()
        {
            this.Text = "Student Evaluation System - Dashboard";
            this.Size = new Size(900, 550);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.White;

            // Title Label
            lblTitle = new Label();
            lblTitle.Text = "FYPManagementSystem";
            lblTitle.Font = new Font("Segoe UI", 24, FontStyle.Bold);
            lblTitle.ForeColor = Color.DarkBlue;
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            lblTitle.Dock = DockStyle.Top;
            lblTitle.Height = 80;
            this.Controls.Add(lblTitle);

            // Students Button
            btnStudents = new Button();
            btnStudents.Text = "👥 MANAGE STUDENTS";
            btnStudents.Size = new Size(200, 80);
            btnStudents.BackColor = Color.LightBlue;
            btnStudents.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            btnStudents.Location = new Point(50, 100);
            btnStudents.Click += BtnStudents_Click;
            this.Controls.Add(btnStudents);

            // Advisors Button
            btnAdvisors = new Button();
            btnAdvisors.Text = "👨‍🏫 MANAGE ADVISORS";
            btnAdvisors.Size = new Size(200, 80);
            btnAdvisors.BackColor = Color.LightGreen;
            btnAdvisors.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            btnAdvisors.Location = new Point(300, 100);
            btnAdvisors.Click += BtnAdvisors_Click;
            this.Controls.Add(btnAdvisors);

            // Projects Button
            btnProjects = new Button();
            btnProjects.Text = "📁 MANAGE PROJECTS";
            btnProjects.Size = new Size(200, 80);
            btnProjects.BackColor = Color.LightYellow;
            btnProjects.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            btnProjects.Location = new Point(550, 100);
            btnProjects.Click += BtnProjects_Click;
            this.Controls.Add(btnProjects);

            // Groups Button
            btnGroups = new Button();
            btnGroups.Text = "👥 MANAGE GROUPS";
            btnGroups.Size = new Size(200, 80);
            btnGroups.BackColor = Color.LightPink;
            btnGroups.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            btnGroups.Location = new Point(50, 220);
            btnGroups.Click += BtnGroups_Click;
            this.Controls.Add(btnGroups);

            // Evaluations Button
            btnEvaluations = new Button();
            btnEvaluations.Text = "📊 EVALUATIONS";
            btnEvaluations.Size = new Size(200, 80);
            btnEvaluations.BackColor = Color.LightSalmon;
            btnEvaluations.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            btnEvaluations.Location = new Point(300, 220);
            btnEvaluations.Click += BtnEvaluations_Click;
            this.Controls.Add(btnEvaluations);

            // Reports Button
            btnReports = new Button();
            btnReports.Text = "📄 REPORTS";
            btnReports.Size = new Size(200, 80);
            btnReports.BackColor = Color.LightGray;
            btnReports.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            btnReports.Location = new Point(550, 220);
            btnReports.Click += BtnReports_Click;
            this.Controls.Add(btnReports);

            // Statistics Labels
            lblStudentCount = new Label();
            lblStudentCount.Text = "👥 Students: 0";
            lblStudentCount.Font = new Font("Segoe UI", 12);
            lblStudentCount.Location = new Point(50, 350);
            lblStudentCount.AutoSize = true;
            this.Controls.Add(lblStudentCount);

            lblAdvisorCount = new Label();
            lblAdvisorCount.Text = "👨‍🏫 Advisors: 0";
            lblAdvisorCount.Font = new Font("Segoe UI", 12);
            lblAdvisorCount.Location = new Point(250, 350);
            lblAdvisorCount.AutoSize = true;
            this.Controls.Add(lblAdvisorCount);

            lblProjectCount = new Label();
            lblProjectCount.Text = "📁 Projects: 0";
            lblProjectCount.Font = new Font("Segoe UI", 12);
            lblProjectCount.Location = new Point(450, 350);
            lblProjectCount.AutoSize = true;
            this.Controls.Add(lblProjectCount);

            lblGroupCount = new Label();
            lblGroupCount.Text = "👥 Groups: 0";
            lblGroupCount.Font = new Font("Segoe UI", 12);
            lblGroupCount.Location = new Point(650, 350);
            lblGroupCount.AutoSize = true;
            this.Controls.Add(lblGroupCount);
        }

        private void LoadStatistics()
        {
            try
            {
                object studentCount = db.ExecuteScalar("SELECT COUNT(*) FROM student");
                lblStudentCount.Text = "👥 Students: " + (studentCount != null ? studentCount.ToString() : "0");

                object advisorCount = db.ExecuteScalar("SELECT COUNT(*) FROM advisor");
                lblAdvisorCount.Text = "👨‍🏫 Advisors: " + (advisorCount != null ? advisorCount.ToString() : "0");

                object projectCount = db.ExecuteScalar("SELECT COUNT(*) FROM project");
                lblProjectCount.Text = "📁 Projects: " + (projectCount != null ? projectCount.ToString() : "0");

                object groupCount = db.ExecuteScalar("SELECT COUNT(*) FROM `group`");
                lblGroupCount.Text = "👥 Groups: " + (groupCount != null ? groupCount.ToString() : "0");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading statistics: " + ex.Message);
            }
        }

        private void BtnStudents_Click(object sender, EventArgs e)
        {
            ManageStudentsForm form = new ManageStudentsForm();
            form.ShowDialog();
            LoadStatistics();
        }

        private void BtnAdvisors_Click(object sender, EventArgs e)
        {
            ManageAdvisorsForm form = new ManageAdvisorsForm();
            form.ShowDialog();
            LoadStatistics();
        }

        private void BtnProjects_Click(object sender, EventArgs e)
        {
            ManageProjectsForm form = new ManageProjectsForm();
            form.ShowDialog();
            LoadStatistics();
        }

        private void BtnGroups_Click(object sender, EventArgs e)
        {
            ManageGroupsForm form = new ManageGroupsForm();
            form.ShowDialog();
            LoadStatistics();
        }

        private void BtnEvaluations_Click(object sender, EventArgs e)
        {
            ManageEvaluationsForm form = new ManageEvaluationsForm();
            form.ShowDialog();
        }

        private void BtnReports_Click(object sender, EventArgs e)
        {
            ReportForm form = new ReportForm();
            form.ShowDialog();
           
        }
    }
}