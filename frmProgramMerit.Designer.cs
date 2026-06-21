namespace UniversityManagementSystem
{
    partial class frmProgramMerit
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPrograms;
        private System.Windows.Forms.TabPage tabMerit;
        private System.Windows.Forms.DataGridView dgvPrograms;
        private System.Windows.Forms.DataGridView dgvMeritList;
        private System.Windows.Forms.Label lblProgramName;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.Label lblSeats;
        private System.Windows.Forms.Label lblClosingMerit;
        private System.Windows.Forms.TextBox txtProgramName;
        private System.Windows.Forms.TextBox txtDuration;
        private System.Windows.Forms.TextBox txtSeats;
        private System.Windows.Forms.TextBox txtClosingMerit;
        private System.Windows.Forms.Button btnAddProgram;
        private System.Windows.Forms.Button btnDeleteProgram;
        private System.Windows.Forms.ComboBox cmbProgram;
        private System.Windows.Forms.Button btnCalculateMerit;
        private System.Windows.Forms.Label lblSelectProgram;

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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPrograms = new System.Windows.Forms.TabPage();
            this.tabMerit = new System.Windows.Forms.TabPage();
            this.dgvPrograms = new System.Windows.Forms.DataGridView();
            this.dgvMeritList = new System.Windows.Forms.DataGridView();
            this.lblProgramName = new System.Windows.Forms.Label();
            this.lblDuration = new System.Windows.Forms.Label();
            this.lblSeats = new System.Windows.Forms.Label();
            this.lblClosingMerit = new System.Windows.Forms.Label();
            this.txtProgramName = new System.Windows.Forms.TextBox();
            this.txtDuration = new System.Windows.Forms.TextBox();
            this.txtSeats = new System.Windows.Forms.TextBox();
            this.txtClosingMerit = new System.Windows.Forms.TextBox();
            this.btnAddProgram = new System.Windows.Forms.Button();
            this.btnDeleteProgram = new System.Windows.Forms.Button();
            this.cmbProgram = new System.Windows.Forms.ComboBox();
            this.btnCalculateMerit = new System.Windows.Forms.Button();
            this.lblSelectProgram = new System.Windows.Forms.Label();
            this.panelHeader.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPrograms.SuspendLayout();
            this.tabMerit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrograms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMeritList)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panelHeader.Controls.Add(this.lblTitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(900, 60);
            this.panelHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(300, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(280, 32);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "PROGRAM & MERIT LIST";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPrograms);
            this.tabControl1.Controls.Add(this.tabMerit);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tabControl1.Location = new System.Drawing.Point(0, 60);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(900, 540);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPrograms
            // 
            this.tabPrograms.BackColor = System.Drawing.Color.White;
            this.tabPrograms.Controls.Add(this.btnDeleteProgram);
            this.tabPrograms.Controls.Add(this.btnAddProgram);
            this.tabPrograms.Controls.Add(this.txtClosingMerit);
            this.tabPrograms.Controls.Add(this.txtSeats);
            this.tabPrograms.Controls.Add(this.txtDuration);
            this.tabPrograms.Controls.Add(this.txtProgramName);
            this.tabPrograms.Controls.Add(this.lblClosingMerit);
            this.tabPrograms.Controls.Add(this.lblSeats);
            this.tabPrograms.Controls.Add(this.lblDuration);
            this.tabPrograms.Controls.Add(this.lblProgramName);
            this.tabPrograms.Controls.Add(this.dgvPrograms);
            this.tabPrograms.Location = new System.Drawing.Point(4, 26);
            this.tabPrograms.Name = "tabPrograms";
            this.tabPrograms.Padding = new System.Windows.Forms.Padding(3);
            this.tabPrograms.Size = new System.Drawing.Size(892, 510);
            this.tabPrograms.TabIndex = 0;
            this.tabPrograms.Text = "Manage Programs";
            // 
            // dgvPrograms
            // 
            this.dgvPrograms.AllowUserToAddRows = false;
            this.dgvPrograms.BackgroundColor = System.Drawing.Color.White;
            this.dgvPrograms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrograms.Columns.Add("ProgramName", "Program Name");
            this.dgvPrograms.Columns.Add("Duration", "Duration (Years)");
            this.dgvPrograms.Columns.Add("Seats", "Total Seats");
            this.dgvPrograms.Columns.Add("ClosingMerit", "Closing Merit");
            this.dgvPrograms.Location = new System.Drawing.Point(20, 180);
            this.dgvPrograms.Name = "dgvPrograms";
            this.dgvPrograms.Size = new System.Drawing.Size(850, 300);
            this.dgvPrograms.TabIndex = 0;
            // 
            // lblProgramName
            // 
            this.lblProgramName.AutoSize = true;
            this.lblProgramName.Location = new System.Drawing.Point(20, 20);
            this.lblProgramName.Name = "lblProgramName";
            this.lblProgramName.Size = new System.Drawing.Size(100, 19);
            this.lblProgramName.TabIndex = 1;
            this.lblProgramName.Text = "Program Name:";
            // 
            // txtProgramName
            // 
            this.txtProgramName.Location = new System.Drawing.Point(150, 17);
            this.txtProgramName.Name = "txtProgramName";
            this.txtProgramName.Size = new System.Drawing.Size(200, 25);
            this.txtProgramName.TabIndex = 2;
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.Location = new System.Drawing.Point(20, 55);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(110, 19);
            this.lblDuration.TabIndex = 3;
            this.lblDuration.Text = "Duration (Years):";
            // 
            // txtDuration
            // 
            this.txtDuration.Location = new System.Drawing.Point(150, 52);
            this.txtDuration.Name = "txtDuration";
            this.txtDuration.Size = new System.Drawing.Size(100, 25);
            this.txtDuration.TabIndex = 4;
            // 
            // lblSeats
            // 
            this.lblSeats.AutoSize = true;
            this.lblSeats.Location = new System.Drawing.Point(20, 90);
            this.lblSeats.Name = "lblSeats";
            this.lblSeats.Size = new System.Drawing.Size(78, 19);
            this.lblSeats.TabIndex = 5;
            this.lblSeats.Text = "Total Seats:";
            // 
            // txtSeats
            // 
            this.txtSeats.Location = new System.Drawing.Point(150, 87);
            this.txtSeats.Name = "txtSeats";
            this.txtSeats.Size = new System.Drawing.Size(100, 25);
            this.txtSeats.TabIndex = 6;
            // 
            // lblClosingMerit
            // 
            this.lblClosingMerit.AutoSize = true;
            this.lblClosingMerit.Location = new System.Drawing.Point(20, 125);
            this.lblClosingMerit.Name = "lblClosingMerit";
            this.lblClosingMerit.Size = new System.Drawing.Size(85, 19);
            this.lblClosingMerit.TabIndex = 7;
            this.lblClosingMerit.Text = "Closing Merit:";
            // 
            // txtClosingMerit
            // 
            this.txtClosingMerit.Location = new System.Drawing.Point(150, 122);
            this.txtClosingMerit.Name = "txtClosingMerit";
            this.txtClosingMerit.Size = new System.Drawing.Size(100, 25);
            this.txtClosingMerit.TabIndex = 8;
            // 
            // btnAddProgram
            // 
            this.btnAddProgram.BackColor = System.Drawing.Color.ForestGreen;
            this.btnAddProgram.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProgram.ForeColor = System.Drawing.Color.White;
            this.btnAddProgram.Location = new System.Drawing.Point(300, 17);
            this.btnAddProgram.Name = "btnAddProgram";
            this.btnAddProgram.Size = new System.Drawing.Size(100, 35);
            this.btnAddProgram.TabIndex = 9;
            this.btnAddProgram.Text = "ADD";
            this.btnAddProgram.UseVisualStyleBackColor = false;
            this.btnAddProgram.Click += new System.EventHandler(this.btnAddProgram_Click);
            // 
            // btnDeleteProgram
            // 
            this.btnDeleteProgram.BackColor = System.Drawing.Color.Crimson;
            this.btnDeleteProgram.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteProgram.ForeColor = System.Drawing.Color.White;
            this.btnDeleteProgram.Location = new System.Drawing.Point(300, 60);
            this.btnDeleteProgram.Name = "btnDeleteProgram";
            this.btnDeleteProgram.Size = new System.Drawing.Size(100, 35);
            this.btnDeleteProgram.TabIndex = 10;
            this.btnDeleteProgram.Text = "DELETE";
            this.btnDeleteProgram.UseVisualStyleBackColor = false;
            this.btnDeleteProgram.Click += new System.EventHandler(this.btnDeleteProgram_Click);
            // 
            // tabMerit
            // 
            this.tabMerit.BackColor = System.Drawing.Color.White;
            this.tabMerit.Controls.Add(this.btnCalculateMerit);
            this.tabMerit.Controls.Add(this.cmbProgram);
            this.tabMerit.Controls.Add(this.lblSelectProgram);
            this.tabMerit.Controls.Add(this.dgvMeritList);
            this.tabMerit.Location = new System.Drawing.Point(4, 26);
            this.tabMerit.Name = "tabMerit";
            this.tabMerit.Padding = new System.Windows.Forms.Padding(3);
            this.tabMerit.Size = new System.Drawing.Size(892, 510);
            this.tabMerit.TabIndex = 1;
            this.tabMerit.Text = "Merit List";
            // 
            // dgvMeritList
            // 
            this.dgvMeritList.AllowUserToAddRows = false;
            this.dgvMeritList.BackgroundColor = System.Drawing.Color.White;
            this.dgvMeritList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMeritList.Columns.Add("Rank", "Rank");
            this.dgvMeritList.Columns.Add("StudentName", "Student Name");
            this.dgvMeritList.Columns.Add("MeritScore", "Merit Score");
            this.dgvMeritList.Columns.Add("Status", "Status");
            this.dgvMeritList.Location = new System.Drawing.Point(20, 80);
            this.dgvMeritList.Name = "dgvMeritList";
            this.dgvMeritList.Size = new System.Drawing.Size(850, 400);
            this.dgvMeritList.TabIndex = 0;
            // 
            // lblSelectProgram
            // 
            this.lblSelectProgram.AutoSize = true;
            this.lblSelectProgram.Location = new System.Drawing.Point(20, 25);
            this.lblSelectProgram.Name = "lblSelectProgram";
            this.lblSelectProgram.Size = new System.Drawing.Size(100, 19);
            this.lblSelectProgram.TabIndex = 1;
            this.lblSelectProgram.Text = "Select Program:";
            // 
            // cmbProgram
            // 
            this.cmbProgram.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProgram.Items.AddRange(new object[] { "Select Program", "BSCS", "BSAI", "BSSE", "BBA" });
            this.cmbProgram.Location = new System.Drawing.Point(140, 22);
            this.cmbProgram.Name = "cmbProgram";
            this.cmbProgram.Size = new System.Drawing.Size(150, 25);
            this.cmbProgram.TabIndex = 2;
            this.cmbProgram.SelectedIndex = 0;
            // 
            // btnCalculateMerit
            // 
            this.btnCalculateMerit.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnCalculateMerit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalculateMerit.ForeColor = System.Drawing.Color.White;
            this.btnCalculateMerit.Location = new System.Drawing.Point(320, 20);
            this.btnCalculateMerit.Name = "btnCalculateMerit";
            this.btnCalculateMerit.Size = new System.Drawing.Size(150, 30);
            this.btnCalculateMerit.TabIndex = 3;
            this.btnCalculateMerit.Text = "GENERATE MERIT LIST";
            this.btnCalculateMerit.UseVisualStyleBackColor = false;
            this.btnCalculateMerit.Click += new System.EventHandler(this.btnCalculateMerit_Click);
            // 
            // frmProgramMerit
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmProgramMerit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UMS - Program & Merit Management";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPrograms.ResumeLayout(false);
            this.tabPrograms.PerformLayout();
            this.tabMerit.ResumeLayout(false);
            this.tabMerit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrograms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMeritList)).EndInit();
            this.ResumeLayout(false);
        }
    }
}