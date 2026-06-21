namespace UniversityManagementSystem
{
    partial class frmFeeHeads
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabHostel;
        private System.Windows.Forms.TabPage tabDayScholar;
        private System.Windows.Forms.TabPage tabCommon;
        private System.Windows.Forms.Button btnSaveHostel;
        private System.Windows.Forms.Button btnSaveDayScholar;
        private System.Windows.Forms.Button btnSaveCommon;
        private System.Windows.Forms.Button btnResetAll;

        // Hostel Controls
        private System.Windows.Forms.Label lblRoomRent;
        private System.Windows.Forms.TextBox txtRoomRent;
        private System.Windows.Forms.Label lblMessCharges;
        private System.Windows.Forms.TextBox txtMessCharges;
        private System.Windows.Forms.Label lblUtilities;
        private System.Windows.Forms.TextBox txtUtilities;
        private System.Windows.Forms.Label lblMaintenance;
        private System.Windows.Forms.TextBox txtMaintenance;
        private System.Windows.Forms.Label lblSecurityDeposit;
        private System.Windows.Forms.TextBox txtSecurityDeposit;

        // Day Scholar Controls
        private System.Windows.Forms.Label lblTransport;
        private System.Windows.Forms.TextBox txtTransport;
        private System.Windows.Forms.Label lblLibraryFee;
        private System.Windows.Forms.TextBox txtLibraryFee;
        private System.Windows.Forms.Label lblSportsFee;
        private System.Windows.Forms.TextBox txtSportsFee;
        private System.Windows.Forms.Label lblActivityFee;
        private System.Windows.Forms.TextBox txtActivityFee;

        // Common Controls
        private System.Windows.Forms.Label lblTuition;
        private System.Windows.Forms.TextBox txtTuition;
        private System.Windows.Forms.Label lblExamination;
        private System.Windows.Forms.TextBox txtExamination;
        private System.Windows.Forms.Label lblLateFee;
        private System.Windows.Forms.TextBox txtLateFee;

        private System.Windows.Forms.GroupBox grpHostel;
        private System.Windows.Forms.GroupBox grpDayScholar;
        private System.Windows.Forms.GroupBox grpCommon;

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
            this.tabHostel = new System.Windows.Forms.TabPage();
            this.tabDayScholar = new System.Windows.Forms.TabPage();
            this.tabCommon = new System.Windows.Forms.TabPage();
            this.btnResetAll = new System.Windows.Forms.Button();

            // Hostel GroupBox
            this.grpHostel = new System.Windows.Forms.GroupBox();
            this.lblRoomRent = new System.Windows.Forms.Label();
            this.txtRoomRent = new System.Windows.Forms.TextBox();
            this.lblMessCharges = new System.Windows.Forms.Label();
            this.txtMessCharges = new System.Windows.Forms.TextBox();
            this.lblUtilities = new System.Windows.Forms.Label();
            this.txtUtilities = new System.Windows.Forms.TextBox();
            this.lblMaintenance = new System.Windows.Forms.Label();
            this.txtMaintenance = new System.Windows.Forms.TextBox();
            this.lblSecurityDeposit = new System.Windows.Forms.Label();
            this.txtSecurityDeposit = new System.Windows.Forms.TextBox();
            this.btnSaveHostel = new System.Windows.Forms.Button();

            // Day Scholar GroupBox
            this.grpDayScholar = new System.Windows.Forms.GroupBox();
            this.lblTransport = new System.Windows.Forms.Label();
            this.txtTransport = new System.Windows.Forms.TextBox();
            this.lblLibraryFee = new System.Windows.Forms.Label();
            this.txtLibraryFee = new System.Windows.Forms.TextBox();
            this.lblSportsFee = new System.Windows.Forms.Label();
            this.txtSportsFee = new System.Windows.Forms.TextBox();
            this.lblActivityFee = new System.Windows.Forms.Label();
            this.txtActivityFee = new System.Windows.Forms.TextBox();
            this.btnSaveDayScholar = new System.Windows.Forms.Button();

            // Common GroupBox
            this.grpCommon = new System.Windows.Forms.GroupBox();
            this.lblTuition = new System.Windows.Forms.Label();
            this.txtTuition = new System.Windows.Forms.TextBox();
            this.lblExamination = new System.Windows.Forms.Label();
            this.txtExamination = new System.Windows.Forms.TextBox();
            this.lblLateFee = new System.Windows.Forms.Label();
            this.txtLateFee = new System.Windows.Forms.TextBox();
            this.btnSaveCommon = new System.Windows.Forms.Button();

            this.panelHeader.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabHostel.SuspendLayout();
            this.tabDayScholar.SuspendLayout();
            this.tabCommon.SuspendLayout();
            this.grpHostel.SuspendLayout();
            this.grpDayScholar.SuspendLayout();
            this.grpCommon.SuspendLayout();
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
            this.lblTitle.Location = new System.Drawing.Point(350, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(180, 32);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "FEE HEADS";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabHostel);
            this.tabControl1.Controls.Add(this.tabDayScholar);
            this.tabControl1.Controls.Add(this.tabCommon);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tabControl1.Location = new System.Drawing.Point(0, 60);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(900, 540);
            this.tabControl1.TabIndex = 1;
            // 
            // tabHostel
            // 
            this.tabHostel.BackColor = System.Drawing.Color.White;
            this.tabHostel.Controls.Add(this.grpHostel);
            this.tabHostel.Controls.Add(this.btnSaveHostel);
            this.tabHostel.Location = new System.Drawing.Point(4, 26);
            this.tabHostel.Name = "tabHostel";
            this.tabHostel.Padding = new System.Windows.Forms.Padding(3);
            this.tabHostel.Size = new System.Drawing.Size(892, 510);
            this.tabHostel.TabIndex = 0;
            this.tabHostel.Text = "🏠 HOSTEL FEE HEADS";
            // 
            // grpHostel
            // 
            this.grpHostel.Controls.Add(this.lblRoomRent);
            this.grpHostel.Controls.Add(this.txtRoomRent);
            this.grpHostel.Controls.Add(this.lblMessCharges);
            this.grpHostel.Controls.Add(this.txtMessCharges);
            this.grpHostel.Controls.Add(this.lblUtilities);
            this.grpHostel.Controls.Add(this.txtUtilities);
            this.grpHostel.Controls.Add(this.lblMaintenance);
            this.grpHostel.Controls.Add(this.txtMaintenance);
            this.grpHostel.Controls.Add(this.lblSecurityDeposit);
            this.grpHostel.Controls.Add(this.txtSecurityDeposit);
            this.grpHostel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.grpHostel.Location = new System.Drawing.Point(50, 30);
            this.grpHostel.Name = "grpHostel";
            this.grpHostel.Size = new System.Drawing.Size(400, 350);
            this.grpHostel.TabIndex = 0;
            this.grpHostel.TabStop = false;
            this.grpHostel.Text = "Hostel Expenditure Heads";
            // 
            // lblRoomRent
            // 
            this.lblRoomRent.AutoSize = true;
            this.lblRoomRent.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblRoomRent.Location = new System.Drawing.Point(20, 40);
            this.lblRoomRent.Name = "lblRoomRent";
            this.lblRoomRent.Size = new System.Drawing.Size(77, 19);
            this.lblRoomRent.TabIndex = 0;
            this.lblRoomRent.Text = "Room Rent:";
            // 
            // txtRoomRent
            // 
            this.txtRoomRent.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtRoomRent.Location = new System.Drawing.Point(180, 37);
            this.txtRoomRent.Name = "txtRoomRent";
            this.txtRoomRent.Size = new System.Drawing.Size(180, 25);
            this.txtRoomRent.TabIndex = 1;
            // 
            // lblMessCharges
            // 
            this.lblMessCharges.AutoSize = true;
            this.lblMessCharges.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblMessCharges.Location = new System.Drawing.Point(20, 80);
            this.lblMessCharges.Name = "lblMessCharges";
            this.lblMessCharges.Size = new System.Drawing.Size(97, 19);
            this.lblMessCharges.TabIndex = 2;
            this.lblMessCharges.Text = "Mess Charges:";
            // 
            // txtMessCharges
            // 
            this.txtMessCharges.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtMessCharges.Location = new System.Drawing.Point(180, 77);
            this.txtMessCharges.Name = "txtMessCharges";
            this.txtMessCharges.Size = new System.Drawing.Size(180, 25);
            this.txtMessCharges.TabIndex = 3;
            // 
            // lblUtilities
            // 
            this.lblUtilities.AutoSize = true;
            this.lblUtilities.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblUtilities.Location = new System.Drawing.Point(20, 120);
            this.lblUtilities.Name = "lblUtilities";
            this.lblUtilities.Size = new System.Drawing.Size(62, 19);
            this.lblUtilities.TabIndex = 4;
            this.lblUtilities.Text = "Utilities:";
            // 
            // txtUtilities
            // 
            this.txtUtilities.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtUtilities.Location = new System.Drawing.Point(180, 117);
            this.txtUtilities.Name = "txtUtilities";
            this.txtUtilities.Size = new System.Drawing.Size(180, 25);
            this.txtUtilities.TabIndex = 5;
            // 
            // lblMaintenance
            // 
            this.lblMaintenance.AutoSize = true;
            this.lblMaintenance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblMaintenance.Location = new System.Drawing.Point(20, 160);
            this.lblMaintenance.Name = "lblMaintenance";
            this.lblMaintenance.Size = new System.Drawing.Size(90, 19);
            this.lblMaintenance.TabIndex = 6;
            this.lblMaintenance.Text = "Maintenance:";
            // 
            // txtMaintenance
            // 
            this.txtMaintenance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtMaintenance.Location = new System.Drawing.Point(180, 157);
            this.txtMaintenance.Name = "txtMaintenance";
            this.txtMaintenance.Size = new System.Drawing.Size(180, 25);
            this.txtMaintenance.TabIndex = 7;
            // 
            // lblSecurityDeposit
            // 
            this.lblSecurityDeposit.AutoSize = true;
            this.lblSecurityDeposit.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSecurityDeposit.Location = new System.Drawing.Point(20, 200);
            this.lblSecurityDeposit.Name = "lblSecurityDeposit";
            this.lblSecurityDeposit.Size = new System.Drawing.Size(115, 19);
            this.lblSecurityDeposit.TabIndex = 8;
            this.lblSecurityDeposit.Text = "Security Deposit:";
            // 
            // txtSecurityDeposit
            // 
            this.txtSecurityDeposit.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSecurityDeposit.Location = new System.Drawing.Point(180, 197);
            this.txtSecurityDeposit.Name = "txtSecurityDeposit";
            this.txtSecurityDeposit.Size = new System.Drawing.Size(180, 25);
            this.txtSecurityDeposit.TabIndex = 9;
            // 
            // btnSaveHostel
            // 
            this.btnSaveHostel.BackColor = System.Drawing.Color.ForestGreen;
            this.btnSaveHostel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveHostel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnSaveHostel.ForeColor = System.Drawing.Color.White;
            this.btnSaveHostel.Location = new System.Drawing.Point(250, 420);
            this.btnSaveHostel.Name = "btnSaveHostel";
            this.btnSaveHostel.Size = new System.Drawing.Size(150, 45);
            this.btnSaveHostel.TabIndex = 1;
            this.btnSaveHostel.Text = "SAVE HOSTEL FEES";
            this.btnSaveHostel.UseVisualStyleBackColor = false;
            this.btnSaveHostel.Click += new System.EventHandler(this.btnSaveHostel_Click);
            // 
            // tabDayScholar
            // 
            this.tabDayScholar.BackColor = System.Drawing.Color.White;
            this.tabDayScholar.Controls.Add(this.grpDayScholar);
            this.tabDayScholar.Controls.Add(this.btnSaveDayScholar);
            this.tabDayScholar.Location = new System.Drawing.Point(4, 26);
            this.tabDayScholar.Name = "tabDayScholar";
            this.tabDayScholar.Padding = new System.Windows.Forms.Padding(3);
            this.tabDayScholar.Size = new System.Drawing.Size(892, 510);
            this.tabDayScholar.TabIndex = 1;
            this.tabDayScholar.Text = "🎓 DAY SCHOLAR FEE HEADS";
            // 
            // grpDayScholar
            // 
            this.grpDayScholar.Controls.Add(this.lblTransport);
            this.grpDayScholar.Controls.Add(this.txtTransport);
            this.grpDayScholar.Controls.Add(this.lblLibraryFee);
            this.grpDayScholar.Controls.Add(this.txtLibraryFee);
            this.grpDayScholar.Controls.Add(this.lblSportsFee);
            this.grpDayScholar.Controls.Add(this.txtSportsFee);
            this.grpDayScholar.Controls.Add(this.lblActivityFee);
            this.grpDayScholar.Controls.Add(this.txtActivityFee);
            this.grpDayScholar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.grpDayScholar.Location = new System.Drawing.Point(50, 30);
            this.grpDayScholar.Name = "grpDayScholar";
            this.grpDayScholar.Size = new System.Drawing.Size(400, 300);
            this.grpDayScholar.TabIndex = 0;
            this.grpDayScholar.TabStop = false;
            this.grpDayScholar.Text = "Day Scholar Expenditure Heads";
            // 
            // lblTransport
            // 
            this.lblTransport.AutoSize = true;
            this.lblTransport.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblTransport.Location = new System.Drawing.Point(20, 40);
            this.lblTransport.Name = "lblTransport";
            this.lblTransport.Size = new System.Drawing.Size(127, 19);
            this.lblTransport.TabIndex = 0;
            this.lblTransport.Text = "Transport Charges:";
            // 
            // txtTransport
            // 
            this.txtTransport.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtTransport.Location = new System.Drawing.Point(180, 37);
            this.txtTransport.Name = "txtTransport";
            this.txtTransport.Size = new System.Drawing.Size(180, 25);
            this.txtTransport.TabIndex = 1;
            // 
            // lblLibraryFee
            // 
            this.lblLibraryFee.AutoSize = true;
            this.lblLibraryFee.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblLibraryFee.Location = new System.Drawing.Point(20, 80);
            this.lblLibraryFee.Name = "lblLibraryFee";
            this.lblLibraryFee.Size = new System.Drawing.Size(78, 19);
            this.lblLibraryFee.TabIndex = 2;
            this.lblLibraryFee.Text = "Library Fee:";
            // 
            // txtLibraryFee
            // 
            this.txtLibraryFee.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtLibraryFee.Location = new System.Drawing.Point(180, 77);
            this.txtLibraryFee.Name = "txtLibraryFee";
            this.txtLibraryFee.Size = new System.Drawing.Size(180, 25);
            this.txtLibraryFee.TabIndex = 3;
            // 
            // lblSportsFee
            // 
            this.lblSportsFee.AutoSize = true;
            this.lblSportsFee.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSportsFee.Location = new System.Drawing.Point(20, 120);
            this.lblSportsFee.Name = "lblSportsFee";
            this.lblSportsFee.Size = new System.Drawing.Size(74, 19);
            this.lblSportsFee.TabIndex = 4;
            this.lblSportsFee.Text = "Sports Fee:";
            // 
            // txtSportsFee
            // 
            this.txtSportsFee.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSportsFee.Location = new System.Drawing.Point(180, 117);
            this.txtSportsFee.Name = "txtSportsFee";
            this.txtSportsFee.Size = new System.Drawing.Size(180, 25);
            this.txtSportsFee.TabIndex = 5;
            // 
            // lblActivityFee
            // 
            this.lblActivityFee.AutoSize = true;
            this.lblActivityFee.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblActivityFee.Location = new System.Drawing.Point(20, 160);
            this.lblActivityFee.Name = "lblActivityFee";
            this.lblActivityFee.Size = new System.Drawing.Size(117, 19);
            this.lblActivityFee.TabIndex = 6;
            this.lblActivityFee.Text = "Activity Fee:";
            // 
            // txtActivityFee
            // 
            this.txtActivityFee.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtActivityFee.Location = new System.Drawing.Point(180, 157);
            this.txtActivityFee.Name = "txtActivityFee";
            this.txtActivityFee.Size = new System.Drawing.Size(180, 25);
            this.txtActivityFee.TabIndex = 7;
            // 
            // btnSaveDayScholar
            // 
            this.btnSaveDayScholar.BackColor = System.Drawing.Color.ForestGreen;
            this.btnSaveDayScholar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveDayScholar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnSaveDayScholar.ForeColor = System.Drawing.Color.White;
            this.btnSaveDayScholar.Location = new System.Drawing.Point(250, 420);
            this.btnSaveDayScholar.Name = "btnSaveDayScholar";
            this.btnSaveDayScholar.Size = new System.Drawing.Size(180, 45);
            this.btnSaveDayScholar.TabIndex = 1;
            this.btnSaveDayScholar.Text = "SAVE DAY SCHOLAR FEES";
            this.btnSaveDayScholar.UseVisualStyleBackColor = false;
            this.btnSaveDayScholar.Click += new System.EventHandler(this.btnSaveDayScholar_Click);
            // 
            // tabCommon
            // 
            this.tabCommon.BackColor = System.Drawing.Color.White;
            this.tabCommon.Controls.Add(this.grpCommon);
            this.tabCommon.Controls.Add(this.btnSaveCommon);
            this.tabCommon.Location = new System.Drawing.Point(4, 26);
            this.tabCommon.Name = "tabCommon";
            this.tabCommon.Padding = new System.Windows.Forms.Padding(3);
            this.tabCommon.Size = new System.Drawing.Size(892, 510);
            this.tabCommon.TabIndex = 2;
            this.tabCommon.Text = "📚 COMMON FEE HEADS";
            // 
            // grpCommon
            // 
            this.grpCommon.Controls.Add(this.lblTuition);
            this.grpCommon.Controls.Add(this.txtTuition);
            this.grpCommon.Controls.Add(this.lblExamination);
            this.grpCommon.Controls.Add(this.txtExamination);
            this.grpCommon.Controls.Add(this.lblLateFee);
            this.grpCommon.Controls.Add(this.txtLateFee);
            this.grpCommon.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.grpCommon.Location = new System.Drawing.Point(50, 30);
            this.grpCommon.Name = "grpCommon";
            this.grpCommon.Size = new System.Drawing.Size(400, 250);
            this.grpCommon.TabIndex = 0;
            this.grpCommon.TabStop = false;
            this.grpCommon.Text = "Common Expenditure Heads (All Students)";
            // 
            // lblTuition
            // 
            this.lblTuition.AutoSize = true;
            this.lblTuition.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblTuition.Location = new System.Drawing.Point(20, 40);
            this.lblTuition.Name = "lblTuition";
            this.lblTuition.Size = new System.Drawing.Size(78, 19);
            this.lblTuition.TabIndex = 0;
            this.lblTuition.Text = "Tuition Fee:";
            // 
            // txtTuition
            // 
            this.txtTuition.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtTuition.Location = new System.Drawing.Point(180, 37);
            this.txtTuition.Name = "txtTuition";
            this.txtTuition.Size = new System.Drawing.Size(180, 25);
            this.txtTuition.TabIndex = 1;
            // 
            // lblExamination
            // 
            this.lblExamination.AutoSize = true;
            this.lblExamination.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblExamination.Location = new System.Drawing.Point(20, 80);
            this.lblExamination.Name = "lblExamination";
            this.lblExamination.Size = new System.Drawing.Size(111, 19);
            this.lblExamination.TabIndex = 2;
            this.lblExamination.Text = "Examination Fee:";
            // 
            // txtExamination
            // 
            this.txtExamination.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtExamination.Location = new System.Drawing.Point(180, 77);
            this.txtExamination.Name = "txtExamination";
            this.txtExamination.Size = new System.Drawing.Size(180, 25);
            this.txtExamination.TabIndex = 3;
            // 
            // lblLateFee
            // 
            this.lblLateFee.AutoSize = true;
            this.lblLateFee.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblLateFee.Location = new System.Drawing.Point(20, 120);
            this.lblLateFee.Name = "lblLateFee";
            this.lblLateFee.Size = new System.Drawing.Size(105, 19);
            this.lblLateFee.TabIndex = 4;
            this.lblLateFee.Text = "Late Fee (per day):";
            // 
            // txtLateFee
            // 
            this.txtLateFee.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtLateFee.Location = new System.Drawing.Point(180, 117);
            this.txtLateFee.Name = "txtLateFee";
            this.txtLateFee.Size = new System.Drawing.Size(180, 25);
            this.txtLateFee.TabIndex = 5;
            // 
            // btnSaveCommon
            // 
            this.btnSaveCommon.BackColor = System.Drawing.Color.ForestGreen;
            this.btnSaveCommon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveCommon.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnSaveCommon.ForeColor = System.Drawing.Color.White;
            this.btnSaveCommon.Location = new System.Drawing.Point(250, 420);
            this.btnSaveCommon.Name = "btnSaveCommon";
            this.btnSaveCommon.Size = new System.Drawing.Size(150, 45);
            this.btnSaveCommon.TabIndex = 1;
            this.btnSaveCommon.Text = "SAVE COMMON FEES";
            this.btnSaveCommon.UseVisualStyleBackColor = false;
            this.btnSaveCommon.Click += new System.EventHandler(this.btnSaveCommon_Click);
            // 
            // btnResetAll
            // 
            this.btnResetAll.BackColor = System.Drawing.Color.Crimson;
            this.btnResetAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetAll.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnResetAll.ForeColor = System.Drawing.Color.White;
            this.btnResetAll.Location = new System.Drawing.Point(700, 15);
            this.btnResetAll.Name = "btnResetAll";
            this.btnResetAll.Size = new System.Drawing.Size(150, 35);
            this.btnResetAll.TabIndex = 2;
            this.btnResetAll.Text = "RESET ALL TO DEFAULT";
            this.btnResetAll.UseVisualStyleBackColor = false;
            this.btnResetAll.Click += new System.EventHandler(this.btnResetAll_Click);
            // 
            // frmFeeHeads
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.btnResetAll);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmFeeHeads";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UMS - Fee Heads Configuration";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabHostel.ResumeLayout(false);
            this.tabDayScholar.ResumeLayout(false);
            this.tabCommon.ResumeLayout(false);
            this.grpHostel.ResumeLayout(false);
            this.grpHostel.PerformLayout();
            this.grpDayScholar.ResumeLayout(false);
            this.grpDayScholar.PerformLayout();
            this.grpCommon.ResumeLayout(false);
            this.grpCommon.PerformLayout();
            this.ResumeLayout(false);
        }
    }
}