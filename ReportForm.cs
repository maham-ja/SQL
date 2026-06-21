using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace MidDb26_25GA49
{
    public class ReportForm : Form
    {
        DatabaseHelper db = new DatabaseHelper();

        private Button btnProjectReport, btnMarksReport, btnStudentReport, btnClose;
        private ReportViewer reportViewer;

        public ReportForm()
        {
            InitializeForm();
        }

        private void InitializeForm()
        {
            this.Text = "Generate Reports";
            this.Size = new Size(900, 650);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.White;

            // Buttons panel
            Panel buttonPanel = new Panel();
            buttonPanel.Size = new Size(900, 100);
            buttonPanel.Location = new Point(0, 0);
            buttonPanel.BackColor = Color.LightGray;

            btnProjectReport = new Button();
            btnProjectReport.Text = "📁 PROJECTS REPORT";
            btnProjectReport.Location = new Point(50, 30);
            btnProjectReport.Size = new Size(180, 50);
            btnProjectReport.BackColor = Color.LightBlue;
            btnProjectReport.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            btnProjectReport.Click += BtnProjectReport_Click;
            buttonPanel.Controls.Add(btnProjectReport);

            btnMarksReport = new Button();
            btnMarksReport.Text = "📊 MARKS REPORT";
            btnMarksReport.Location = new Point(250, 30);
            btnMarksReport.Size = new Size(180, 50);
            btnMarksReport.BackColor = Color.LightGreen;
            btnMarksReport.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            btnMarksReport.Click += BtnMarksReport_Click;
            buttonPanel.Controls.Add(btnMarksReport);

            btnStudentReport = new Button();
            btnStudentReport.Text = "👥 STUDENTS REPORT";
            btnStudentReport.Location = new Point(450, 30);
            btnStudentReport.Size = new Size(180, 50);
            btnStudentReport.BackColor = Color.LightYellow;
            btnStudentReport.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            btnStudentReport.Click += BtnStudentReport_Click;
            buttonPanel.Controls.Add(btnStudentReport);

            btnClose = new Button();
            btnClose.Text = "❌ CLOSE";
            btnClose.Location = new Point(650, 30);
            btnClose.Size = new Size(180, 50);
            btnClose.BackColor = Color.LightGray;
            btnClose.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            btnClose.Click += (s, e) => this.Close();
            buttonPanel.Controls.Add(btnClose);

            this.Controls.Add(buttonPanel);

            // Report Viewer
            reportViewer = new ReportViewer();
            reportViewer.Location = new Point(0, 110);
            reportViewer.Size = new Size(900, 500);
            reportViewer.Dock = DockStyle.Bottom;
            this.Controls.Add(reportViewer);
        }

        private void BtnProjectReport_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;

                string query = @"SELECT DISTINCT 
                    p.Title AS ProjectTitle,
                    CONCAT(pers.FirstName, ' ', pers.LastName) AS AdvisorName,
                    l.Value AS AdvisorRole,
                    CONCAT(stud.FirstName, ' ', stud.LastName) AS StudentName,
                    s.RegistrationNo
                    FROM project p
                    LEFT JOIN projectadvisor pa ON p.Id = pa.ProjectId
                    LEFT JOIN advisor a ON pa.AdvisorId = a.Id
                    LEFT JOIN person pers ON a.Id = pers.Id
                    LEFT JOIN lookup l ON pa.AdvisorRole = l.Id
                    LEFT JOIN groupproject gp ON p.Id = gp.ProjectId
                    LEFT JOIN `group` g ON gp.GroupId = g.Id
                    LEFT JOIN groupstudent gs ON g.Id = gs.GroupId
                    LEFT JOIN student s ON gs.StudentId = s.Id
                    LEFT JOIN person stud ON s.Id = stud.Id
                    ORDER BY p.Title";

                DataTable dt = db.ExecuteQuery(query);

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No data found for report", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                reportViewer.LocalReport.ReportPath = "ProjectReport.rdlc";
                reportViewer.LocalReport.DataSources.Clear();

                ReportDataSource rds = new ReportDataSource("ProjectDataSet", dt);
                reportViewer.LocalReport.DataSources.Add(rds);

                reportViewer.RefreshReport();

                Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {
                Cursor = Cursors.Default;
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnMarksReport_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Marks Report - Create MarksReport.rdlc first");
        }

        private void BtnStudentReport_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Student Report - Create StudentReport.rdlc first");
        }
    }
}