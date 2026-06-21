using System;
using System.Drawing;
using System.Windows.Forms;

namespace UMS
{
    partial class frmAccountsDashboard
    {
        private System.ComponentModel.IContainer components = null;
        private Panel panelHeader;
        private Label lblTitle;
        private Label lblWelcome;
        private Button btnViewVouchers;
        private Button btnPendingFees;
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
            this.btnViewVouchers = new Button();
            this.btnPendingFees = new Button();
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
            this.lblTitle.Location = new Point(220, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new Size(360, 32);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "ACCOUNTS DASHBOARD";
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new Font("Segoe UI", 10F);
            this.lblWelcome.ForeColor = Color.LightGray;
            this.lblWelcome.Location = new Point(330, 60);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new Size(140, 19);
            this.lblWelcome.TabIndex = 1;
            this.lblWelcome.Text = "Welcome, Accounts";
            // 
            // panelButtons
            // 
            this.panelButtons.BackColor = Color.White;
            this.panelButtons.Controls.Add(this.btnViewVouchers);
            this.panelButtons.Controls.Add(this.btnPendingFees);
            this.panelButtons.Controls.Add(this.btnLogout);
            this.panelButtons.Dock = DockStyle.Fill;
            this.panelButtons.Location = new Point(0, 100);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new Size(800, 500);
            this.panelButtons.TabIndex = 1;
            // 
            // btnViewVouchers
            // 
            this.btnViewVouchers.BackColor = Color.Crimson;
            this.btnViewVouchers.FlatStyle = FlatStyle.Flat;
            this.btnViewVouchers.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            this.btnViewVouchers.ForeColor = Color.White;
            this.btnViewVouchers.Location = new Point(275, 100);
            this.btnViewVouchers.Name = "btnViewVouchers";
            this.btnViewVouchers.Size = new Size(250, 80);
            this.btnViewVouchers.TabIndex = 0;
            this.btnViewVouchers.Text = "🧾 VIEW VOUCHERS\r\n(View & Print)";
            this.btnViewVouchers.UseVisualStyleBackColor = false;
            this.btnViewVouchers.Click += new EventHandler(this.btnViewVouchers_Click);
            // 
            // btnPendingFees
            // 
            this.btnPendingFees.BackColor = Color.Teal;
            this.btnPendingFees.FlatStyle = FlatStyle.Flat;
            this.btnPendingFees.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            this.btnPendingFees.ForeColor = Color.White;
            this.btnPendingFees.Location = new Point(275, 220);
            this.btnPendingFees.Name = "btnPendingFees";
            this.btnPendingFees.Size = new Size(250, 80);
            this.btnPendingFees.TabIndex = 1;
            this.btnPendingFees.Text = "📊 PENDING FEES\r\n(Pending & Refund Reports)";
            this.btnPendingFees.UseVisualStyleBackColor = false;
            this.btnPendingFees.Click += new EventHandler(this.btnPendingFees_Click);
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
            this.btnLogout.TabIndex = 2;
            this.btnLogout.Text = "LOGOUT";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new EventHandler(this.btnLogout_Click);
            // 
            // frmAccountsDashboard
            // 
            this.BackColor = Color.White;
            this.ClientSize = new Size(800, 600);
            this.Controls.Add(this.panelButtons);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmAccountsDashboard";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "UMS - Accounts Dashboard";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelButtons.ResumeLayout(false);
            this.ResumeLayout(false);
        }
    }
}