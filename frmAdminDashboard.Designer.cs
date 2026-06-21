using System;
using System.Drawing;
using System.Windows.Forms;

namespace UMS
{
    partial class frmAdminDashboard
    {
        private System.ComponentModel.IContainer components = null;
        private Panel panelHeader;
        private Label lblTitle;
        private Label lblWelcome;
        private Button btnStudentManagement;
        private Button btnProgramMerit;
        private Button btnHostelSetup;
        private Button btnFeeHeads;
        private Button btnFeeVoucher;
        private Button btnReports;
        private Button btnLogout;
        private Panel panelButtons;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.panelHeader = new Panel();
            this.lblTitle = new Label();
            this.lblWelcome = new Label();
            this.panelButtons = new Panel();
            this.btnStudentManagement = new Button();
            this.btnProgramMerit = new Button();
            this.btnHostelSetup = new Button();
            this.btnFeeHeads = new Button();
            this.btnFeeVoucher = new Button();
            this.btnReports = new Button();
            this.btnLogout = new Button();
            this.panelHeader.SuspendLayout();
            this.panelButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = Color.DarkSlateBlue;
            this.panelHeader.Controls.Add(this.lblTitle);
            this.panelHeader.Controls.Add(this.lblWelcome);
            this.panelHeader.Dock = DockStyle.Top;
            this.panelHeader.Location = new Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new Size(900, 100);
            this.panelHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            this.lblTitle.ForeColor = Color.White;
            this.lblTitle.Location = new Point(250, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new Size(400, 32);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "ADMIN CONTROL DASHBOARD";
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new Font("Segoe UI", 10F);
            this.lblWelcome.ForeColor = Color.LightGray;
            this.lblWelcome.Location = new Point(370, 60);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new Size(159, 19);
            this.lblWelcome.TabIndex = 1;
            this.lblWelcome.Text = "Welcome, Administrator";
            // 
            // panelButtons
            // 
            this.panelButtons.BackColor = Color.White;
            this.panelButtons.Controls.Add(this.btnStudentManagement);
            this.panelButtons.Controls.Add(this.btnProgramMerit);
            this.panelButtons.Controls.Add(this.btnHostelSetup);
            this.panelButtons.Controls.Add(this.btnFeeHeads);
            this.panelButtons.Controls.Add(this.btnFeeVoucher);
            this.panelButtons.Controls.Add(this.btnReports);
            this.panelButtons.Controls.Add(this.btnLogout);
            this.panelButtons.Dock = DockStyle.Fill;
            this.panelButtons.Location = new Point(0, 100);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new Size(900, 500);
            this.panelButtons.TabIndex = 1;
            // 
            // btnStudentManagement
            // 
            this.btnStudentManagement.BackColor = Color.SteelBlue;
            this.btnStudentManagement.FlatStyle = FlatStyle.Flat;
            this.btnStudentManagement.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            this.btnStudentManagement.ForeColor = Color.White;
            this.btnStudentManagement.Location = new Point(100, 50);
            this.btnStudentManagement.Name = "btnStudentManagement";
            this.btnStudentManagement.Size = new Size(220, 80);
            this.btnStudentManagement.TabIndex = 0;
            this.btnStudentManagement.Text = "📚 STUDENT MANAGEMENT\r\n(Add/Edit/Delete)";
            this.btnStudentManagement.UseVisualStyleBackColor = false;
            this.btnStudentManagement.Click += new EventHandler(this.btnStudentManagement_Click);
            // 
            // btnProgramMerit
            // 
            this.btnProgramMerit.BackColor = Color.ForestGreen;
            this.btnProgramMerit.FlatStyle = FlatStyle.Flat;
            this.btnProgramMerit.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            this.btnProgramMerit.ForeColor = Color.White;
            this.btnProgramMerit.Location = new Point(340, 50);
            this.btnProgramMerit.Name = "btnProgramMerit";
            this.btnProgramMerit.Size = new Size(220, 80);
            this.btnProgramMerit.TabIndex = 1;
            this.btnProgramMerit.Text = "🎯 PROGRAM & MERIT\r\n(Programs + Merit List)";
            this.btnProgramMerit.UseVisualStyleBackColor = false;
            this.btnProgramMerit.Click += new EventHandler(this.btnProgramMerit_Click);
            // 
            // btnHostelSetup
            // 
            this.btnHostelSetup.BackColor = Color.DarkGoldenrod;
            this.btnHostelSetup.FlatStyle = FlatStyle.Flat;
            this.btnHostelSetup.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            this.btnHostelSetup.ForeColor = Color.White;
            this.btnHostelSetup.Location = new Point(580, 50);
            this.btnHostelSetup.Name = "btnHostelSetup";
            this.btnHostelSetup.Size = new Size(220, 80);
            this.btnHostelSetup.TabIndex = 2;
            this.btnHostelSetup.Text = "🏠 HOSTEL SETUP\r\n(Hostels + Rooms)";
            this.btnHostelSetup.UseVisualStyleBackColor = false;
            this.btnHostelSetup.Click += new EventHandler(this.btnHostelSetup_Click);
            // 
            // btnFeeHeads
            // 
            this.btnFeeHeads.BackColor = Color.Purple;
            this.btnFeeHeads.FlatStyle = FlatStyle.Flat;
            this.btnFeeHeads.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            this.btnFeeHeads.ForeColor = Color.White;
            this.btnFeeHeads.Location = new Point(100, 160);
            this.btnFeeHeads.Name = "btnFeeHeads";
            this.btnFeeHeads.Size = new Size(220, 80);
            this.btnFeeHeads.TabIndex = 3;
            this.btnFeeHeads.Text = "💰 FEE HEADS\r\n(Hostel + Day + Common)";
            this.btnFeeHeads.UseVisualStyleBackColor = false;
            this.btnFeeHeads.Click += new EventHandler(this.btnFeeHeads_Click);
            // 
            // btnFeeVoucher
            // 
            this.btnFeeVoucher.BackColor = Color.Crimson;
            this.btnFeeVoucher.FlatStyle = FlatStyle.Flat;
            this.btnFeeVoucher.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            this.btnFeeVoucher.ForeColor = Color.White;
            this.btnFeeVoucher.Location = new Point(340, 160);
            this.btnFeeVoucher.Name = "btnFeeVoucher";
            this.btnFeeVoucher.Size = new Size(220, 80);
            this.btnFeeVoucher.TabIndex = 4;
            this.btnFeeVoucher.Text = "🧾 FEE VOUCHER\r\n(Generate + Payment)";
            this.btnFeeVoucher.UseVisualStyleBackColor = false;
            this.btnFeeVoucher.Click += new EventHandler(this.btnFeeVoucher_Click);
            // 
            // btnReports
            // 
            this.btnReports.BackColor = Color.Teal;
            this.btnReports.FlatStyle = FlatStyle.Flat;
            this.btnReports.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            this.btnReports.ForeColor = Color.White;
            this.btnReports.Location = new Point(580, 160);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new Size(220, 80);
            this.btnReports.TabIndex = 5;
            this.btnReports.Text = "📊 REPORTS\r\n(All Reports PDF)";
            this.btnReports.UseVisualStyleBackColor = false;
            this.btnReports.Click += new EventHandler(this.btnReports_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = Color.DarkRed;
            this.btnLogout.FlatStyle = FlatStyle.Flat;
            this.btnLogout.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.btnLogout.ForeColor = Color.White;
            this.btnLogout.Location = new Point(750, 430);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new Size(120, 40);
            this.btnLogout.TabIndex = 6;
            this.btnLogout.Text = "LOGOUT";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new EventHandler(this.btnLogout_Click);
            // 
            // frmAdminDashboard
            // 
            this.BackColor = Color.White;
            this.ClientSize = new Size(900, 600);
            this.Controls.Add(this.panelButtons);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmAdminDashboard";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "UMS - Admin Dashboard";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelButtons.ResumeLayout(false);
            this.ResumeLayout(false);
        }
    }
}