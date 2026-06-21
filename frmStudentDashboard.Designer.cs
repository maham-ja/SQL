using System;
using System.Drawing;
using System.Windows.Forms;

namespace UMS
{
    partial class frmStudentDashboard
    {
        private System.ComponentModel.IContainer components = null;
        private Panel panelHeader;
        private Label lblTitle;
        private Label lblWelcome;
        private Button btnMyVoucher;
        private Button btnPaymentHistory;
        private Button btnMyAllocation;
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
            this.btnMyVoucher = new Button();
            this.btnPaymentHistory = new Button();
            this.btnMyAllocation = new Button();
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
            this.panelHeader.Size = new Size(800, 100);
            this.panelHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            this.lblTitle.ForeColor = Color.White;
            this.lblTitle.Location = new Point(250, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new Size(300, 32);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "STUDENT PORTAL";
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new Font("Segoe UI", 10F);
            this.lblWelcome.ForeColor = Color.LightGray;
            this.lblWelcome.Location = new Point(330, 60);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new Size(141, 19);
            this.lblWelcome.TabIndex = 1;
            this.lblWelcome.Text = "Welcome, Student";
            // 
            // panelButtons
            // 
            this.panelButtons.BackColor = Color.White;
            this.panelButtons.Controls.Add(this.btnMyVoucher);
            this.panelButtons.Controls.Add(this.btnPaymentHistory);
            this.panelButtons.Controls.Add(this.btnMyAllocation);
            this.panelButtons.Controls.Add(this.btnLogout);
            this.panelButtons.Dock = DockStyle.Fill;
            this.panelButtons.Location = new Point(0, 100);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new Size(800, 500);
            this.panelButtons.TabIndex = 1;
            // 
            // btnMyVoucher
            // 
            this.btnMyVoucher.BackColor = Color.Crimson;
            this.btnMyVoucher.FlatStyle = FlatStyle.Flat;
            this.btnMyVoucher.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            this.btnMyVoucher.ForeColor = Color.White;
            this.btnMyVoucher.Location = new Point(275, 80);
            this.btnMyVoucher.Name = "btnMyVoucher";
            this.btnMyVoucher.Size = new Size(250, 80);
            this.btnMyVoucher.TabIndex = 0;
            this.btnMyVoucher.Text = "🧾 MY FEE VOUCHER\r\n(Download PDF)";
            this.btnMyVoucher.UseVisualStyleBackColor = false;
            this.btnMyVoucher.Click += new EventHandler(this.btnMyVoucher_Click);
            // 
            // btnPaymentHistory
            // 
            this.btnPaymentHistory.BackColor = Color.Teal;
            this.btnPaymentHistory.FlatStyle = FlatStyle.Flat;
            this.btnPaymentHistory.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            this.btnPaymentHistory.ForeColor = Color.White;
            this.btnPaymentHistory.Location = new Point(275, 190);
            this.btnPaymentHistory.Name = "btnPaymentHistory";
            this.btnPaymentHistory.Size = new Size(250, 80);
            this.btnPaymentHistory.TabIndex = 1;
            this.btnPaymentHistory.Text = "💰 PAYMENT HISTORY\r\n(View Past Payments)";
            this.btnPaymentHistory.UseVisualStyleBackColor = false;
            this.btnPaymentHistory.Click += new EventHandler(this.btnPaymentHistory_Click);
            // 
            // btnMyAllocation
            // 
            this.btnMyAllocation.BackColor = Color.DarkGoldenrod;
            this.btnMyAllocation.FlatStyle = FlatStyle.Flat;
            this.btnMyAllocation.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            this.btnMyAllocation.ForeColor = Color.White;
            this.btnMyAllocation.Location = new Point(275, 300);
            this.btnMyAllocation.Name = "btnMyAllocation";
            this.btnMyAllocation.Size = new Size(250, 80);
            this.btnMyAllocation.TabIndex = 2;
            this.btnMyAllocation.Text = "🏠 MY ALLOCATION\r\n(Hostel Room Details)";
            this.btnMyAllocation.UseVisualStyleBackColor = false;
            this.btnMyAllocation.Click += new EventHandler(this.btnMyAllocation_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = Color.DarkRed;
            this.btnLogout.FlatStyle = FlatStyle.Flat;
            this.btnLogout.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.btnLogout.ForeColor = Color.White;
            this.btnLogout.Location = new Point(650, 430);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new Size(120, 40);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.Text = "LOGOUT";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new EventHandler(this.btnLogout_Click);
            // 
            // frmStudentDashboard
            // 
            this.BackColor = Color.White;
            this.ClientSize = new Size(800, 600);
            this.Controls.Add(this.panelButtons);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmStudentDashboard";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "UMS - Student Dashboard";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelButtons.ResumeLayout(false);
            this.ResumeLayout(false);
        }
    }
}