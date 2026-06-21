namespace UniversityManagementSystem
{
    partial class frmFeeVoucher
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox grpGenerate;
        private System.Windows.Forms.GroupBox grpVoucherList;
        private System.Windows.Forms.Label lblStudent;
        private System.Windows.Forms.ComboBox cmbStudent;
        private System.Windows.Forms.Button btnGenerateVoucher;
        private System.Windows.Forms.DataGridView dgvVouchers;
        private System.Windows.Forms.Button btnRecordPayment;
        private System.Windows.Forms.Button btnPrintVoucher;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearchStudent;
        private System.Windows.Forms.Button btnSearchStudent;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.grpGenerate = new System.Windows.Forms.GroupBox();
            this.btnSearchStudent = new System.Windows.Forms.Button();
            this.txtSearchStudent = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.btnGenerateVoucher = new System.Windows.Forms.Button();
            this.cmbStudent = new System.Windows.Forms.ComboBox();
            this.lblStudent = new System.Windows.Forms.Label();
            this.grpVoucherList = new System.Windows.Forms.GroupBox();
            this.btnPrintVoucher = new System.Windows.Forms.Button();
            this.btnRecordPayment = new System.Windows.Forms.Button();
            this.dgvVouchers = new System.Windows.Forms.DataGridView();
            this.panelHeader.SuspendLayout();
            this.grpGenerate.SuspendLayout();
            this.grpVoucherList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVouchers)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panelHeader.Controls.Add(this.lblTitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1000, 60);
            this.panelHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(380, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(250, 32);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "FEE VOUCHER SYSTEM";
            // 
            // grpGenerate
            // 
            this.grpGenerate.Controls.Add(this.btnSearchStudent);
            this.grpGenerate.Controls.Add(this.txtSearchStudent);
            this.grpGenerate.Controls.Add(this.lblSearch);
            this.grpGenerate.Controls.Add(this.btnGenerateVoucher);
            this.grpGenerate.Controls.Add(this.cmbStudent);
            this.grpGenerate.Controls.Add(this.lblStudent);
            this.grpGenerate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpGenerate.Location = new System.Drawing.Point(12, 70);
            this.grpGenerate.Name = "grpGenerate";
            this.grpGenerate.Size = new System.Drawing.Size(976, 120);
            this.grpGenerate.TabIndex = 1;
            this.grpGenerate.TabStop = false;
            this.grpGenerate.Text = "Generate New Voucher";
            // 
            // lblStudent
            // 
            this.lblStudent.AutoSize = true;
            this.lblStudent.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblStudent.Location = new System.Drawing.Point(20, 35);
            this.lblStudent.Name = "lblStudent";
            this.lblStudent.Size = new System.Drawing.Size(64, 19);
            this.lblStudent.TabIndex = 0;
            this.lblStudent.Text = "Student:";
            // 
            // cmbStudent
            // 
            this.cmbStudent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStudent.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbStudent.Items.AddRange(new object[] { "Select Student", "Ali Khan (2025-CS-01)", "Sara Ahmed (2025-CS-02)", "Bilal Hassan (2025-CS-03)", "Fatima Ali (2025-CS-04)", "Usman Chaudhry (2025-CS-05)" });
            this.cmbStudent.Location = new System.Drawing.Point(120, 32);
            this.cmbStudent.Name = "cmbStudent";
            this.cmbStudent.Size = new System.Drawing.Size(300, 25);
            this.cmbStudent.TabIndex = 1;
            this.cmbStudent.SelectedIndex = 0;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSearch.Location = new System.Drawing.Point(20, 75);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(56, 19);
            this.lblSearch.TabIndex = 2;
            this.lblSearch.Text = "Search:";
            // 
            // txtSearchStudent
            // 
            this.txtSearchStudent.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSearchStudent.Location = new System.Drawing.Point(120, 72);
            this.txtSearchStudent.Name = "txtSearchStudent";
            this.txtSearchStudent.Size = new System.Drawing.Size(200, 25);
            this.txtSearchStudent.TabIndex = 3;
            // 
            // btnSearchStudent
            // 
            this.btnSearchStudent.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnSearchStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchStudent.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSearchStudent.ForeColor = System.Drawing.Color.White;
            this.btnSearchStudent.Location = new System.Drawing.Point(340, 70);
            this.btnSearchStudent.Name = "btnSearchStudent";
            this.btnSearchStudent.Size = new System.Drawing.Size(80, 28);
            this.btnSearchStudent.TabIndex = 4;
            this.btnSearchStudent.Text = "SEARCH";
            this.btnSearchStudent.UseVisualStyleBackColor = false;
            this.btnSearchStudent.Click += new System.EventHandler(this.btnSearchStudent_Click);
            // 
            // btnGenerateVoucher
            // 
            this.btnGenerateVoucher.BackColor = System.Drawing.Color.ForestGreen;
            this.btnGenerateVoucher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerateVoucher.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnGenerateVoucher.ForeColor = System.Drawing.Color.White;
            this.btnGenerateVoucher.Location = new System.Drawing.Point(500, 30);
            this.btnGenerateVoucher.Name = "btnGenerateVoucher";
            this.btnGenerateVoucher.Size = new System.Drawing.Size(180, 50);
            this.btnGenerateVoucher.TabIndex = 5;
            this.btnGenerateVoucher.Text = "GENERATE VOUCHER";
            this.btnGenerateVoucher.UseVisualStyleBackColor = false;
            this.btnGenerateVoucher.Click += new System.EventHandler(this.btnGenerateVoucher_Click);
            // 
            // grpVoucherList
            // 
            this.grpVoucherList.Controls.Add(this.btnPrintVoucher);
            this.grpVoucherList.Controls.Add(this.btnRecordPayment);
            this.grpVoucherList.Controls.Add(this.dgvVouchers);
            this.grpVoucherList.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpVoucherList.Location = new System.Drawing.Point(12, 200);
            this.grpVoucherList.Name = "grpVoucherList";
            this.grpVoucherList.Size = new System.Drawing.Size(976, 350);
            this.grpVoucherList.TabIndex = 2;
            this.grpVoucherList.TabStop = false;
            this.grpVoucherList.Text = "Voucher List";
            // 
            // dgvVouchers
            // 
            this.dgvVouchers.AllowUserToAddRows = false;
            this.dgvVouchers.BackgroundColor = System.Drawing.Color.White;
            this.dgvVouchers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVouchers.Columns.Add("VoucherNo", "Voucher No");
            this.dgvVouchers.Columns.Add("StudentName", "Student Name");
            this.dgvVouchers.Columns.Add("Category", "Category");
            this.dgvVouchers.Columns.Add("Amount", "Amount (PKR)");
            this.dgvVouchers.Columns.Add("DueDate", "Due Date");
            this.dgvVouchers.Columns.Add("Status", "Status");
            this.dgvVouchers.Location = new System.Drawing.Point(15, 25);
            this.dgvVouchers.Name = "dgvVouchers";
            this.dgvVouchers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVouchers.Size = new System.Drawing.Size(945, 250);
            this.dgvVouchers.TabIndex = 0;
            // 
            // btnRecordPayment
            // 
            this.btnRecordPayment.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnRecordPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecordPayment.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnRecordPayment.ForeColor = System.Drawing.Color.White;
            this.btnRecordPayment.Location = new System.Drawing.Point(700, 290);
            this.btnRecordPayment.Name = "btnRecordPayment";
            this.btnRecordPayment.Size = new System.Drawing.Size(130, 40);
            this.btnRecordPayment.TabIndex = 1;
            this.btnRecordPayment.Text = "RECORD PAYMENT";
            this.btnRecordPayment.UseVisualStyleBackColor = false;
            this.btnRecordPayment.Click += new System.EventHandler(this.btnRecordPayment_Click);
            // 
            // btnPrintVoucher
            // 
            this.btnPrintVoucher.BackColor = System.Drawing.Color.Teal;
            this.btnPrintVoucher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrintVoucher.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnPrintVoucher.ForeColor = System.Drawing.Color.White;
            this.btnPrintVoucher.Location = new System.Drawing.Point(840, 290);
            this.btnPrintVoucher.Name = "btnPrintVoucher";
            this.btnPrintVoucher.Size = new System.Drawing.Size(120, 40);
            this.btnPrintVoucher.TabIndex = 2;
            this.btnPrintVoucher.Text = "PRINT VOUCHER";
            this.btnPrintVoucher.UseVisualStyleBackColor = false;
            this.btnPrintVoucher.Click += new System.EventHandler(this.btnPrintVoucher_Click);
            // 
            // frmFeeVoucher
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 570);
            this.Controls.Add(this.grpVoucherList);
            this.Controls.Add(this.grpGenerate);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmFeeVoucher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UMS - Fee Voucher Management";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.grpGenerate.ResumeLayout(false);
            this.grpGenerate.PerformLayout();
            this.grpVoucherList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVouchers)).EndInit();
            this.ResumeLayout(false);
        }
    }
}