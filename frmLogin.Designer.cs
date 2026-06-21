using System;
using System.Drawing;
using System.Windows.Forms;

namespace UMS
{
    partial class frmLogin
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblTitle;
        private Label lblRole;
        private Label lblPassword;
        private ComboBox cmbRole;
        private TextBox txtPassword;
        private Button btnLogin;
        private Button btnCancel;
        private Panel panelHeader;
        private Label lblSubTitle;

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
            this.lblSubTitle = new Label();
            this.lblRole = new Label();
            this.cmbRole = new ComboBox();
            this.lblPassword = new Label();
            this.txtPassword = new TextBox();
            this.btnLogin = new Button();
            this.btnCancel = new Button();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = Color.DarkSlateBlue;
            this.panelHeader.Controls.Add(this.lblTitle);
            this.panelHeader.Controls.Add(this.lblSubTitle);
            this.panelHeader.Dock = DockStyle.Top;
            this.panelHeader.Location = new Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new Size(500, 100);
            this.panelHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            this.lblTitle.ForeColor = Color.White;
            this.lblTitle.Location = new Point(60, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new Size(380, 32);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "UNIVERSITY MANAGEMENT SYSTEM";
            // 
            // lblSubTitle
            // 
            this.lblSubTitle.AutoSize = true;
            this.lblSubTitle.Font = new Font("Segoe UI", 10F);
            this.lblSubTitle.ForeColor = Color.LightGray;
            this.lblSubTitle.Location = new Point(160, 60);
            this.lblSubTitle.Name = "lblSubTitle";
            this.lblSubTitle.Size = new Size(178, 19);
            this.lblSubTitle.TabIndex = 1;
            this.lblSubTitle.Text = "Login to Access Dashboard";
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Font = new Font("Segoe UI", 11F);
            this.lblRole.Location = new Point(80, 130);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new Size(42, 20);
            this.lblRole.TabIndex = 1;
            this.lblRole.Text = "Role:";
            // 
            // cmbRole
            // 
            this.cmbRole.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbRole.Font = new Font("Segoe UI", 11F);
            this.cmbRole.Items.AddRange(new object[] { "Admin", "Accounts", "Student" });
            this.cmbRole.Location = new Point(140, 127);
            this.cmbRole.Name = "cmbRole";
            this.cmbRole.Size = new Size(250, 28);
            this.cmbRole.TabIndex = 2;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new Font("Segoe UI", 11F);
            this.lblPassword.Location = new Point(80, 180);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new Size(73, 20);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "Password:";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new Font("Segoe UI", 11F);
            this.txtPassword.Location = new Point(160, 177);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '●';
            this.txtPassword.Size = new Size(230, 27);
            this.txtPassword.TabIndex = 4;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = Color.DarkSlateBlue;
            this.btnLogin.FlatStyle = FlatStyle.Flat;
            this.btnLogin.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.btnLogin.ForeColor = Color.White;
            this.btnLogin.Location = new Point(160, 230);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new Size(100, 35);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "LOGIN";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new EventHandler(this.btnLogin_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = Color.Gray;
            this.btnCancel.FlatStyle = FlatStyle.Flat;
            this.btnCancel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.btnCancel.ForeColor = Color.White;
            this.btnCancel.Location = new Point(290, 230);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new Size(100, 35);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new EventHandler(this.btnCancel_Click);
            // 
            // Info Label
            // 
            Label lblInfo = new Label();
            lblInfo.AutoSize = true;
            lblInfo.Font = new Font("Segoe UI", 8F);
            lblInfo.ForeColor = Color.DarkGray;
            lblInfo.Location = new Point(70, 290);
            lblInfo.Text = "🔐 Demo Passwords: Admin: admin123  |  Accounts: acc123  |  Student: student123";
            lblInfo.Size = new Size(360, 13);
            this.Controls.Add(lblInfo);
            // 
            // frmLogin
            // 
            this.AcceptButton = this.btnLogin;
            this.BackColor = Color.White;
            this.ClientSize = new Size(500, 340);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.cmbRole);
            this.Controls.Add(this.lblRole);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmLogin";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "UMS - Login";
            this.Load += new EventHandler(this.frmLogin_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}