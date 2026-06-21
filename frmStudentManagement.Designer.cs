namespace UniversityManagementSystem
{
    partial class frmStudentManagement
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblRollNo;
        private System.Windows.Forms.Label lblCNIC;
        private System.Windows.Forms.Label lblProgram;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblRoom;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblMatric;
        private System.Windows.Forms.Label lblInter;
        private System.Windows.Forms.Label lblEntryTest;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtRollNo;
        private System.Windows.Forms.TextBox txtCNIC;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtMatric;
        private System.Windows.Forms.TextBox txtInter;
        private System.Windows.Forms.TextBox txtEntryTest;
        private System.Windows.Forms.ComboBox cmbProgram;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.ComboBox cmbRoomNumber;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Panel panelHeader;

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
            this.lblName = new System.Windows.Forms.Label();
            this.lblRollNo = new System.Windows.Forms.Label();
            this.lblCNIC = new System.Windows.Forms.Label();
            this.lblProgram = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblRoom = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblMatric = new System.Windows.Forms.Label();
            this.lblInter = new System.Windows.Forms.Label();
            this.lblEntryTest = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtRollNo = new System.Windows.Forms.TextBox();
            this.txtCNIC = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtMatric = new System.Windows.Forms.TextBox();
            this.txtInter = new System.Windows.Forms.TextBox();
            this.txtEntryTest = new System.Windows.Forms.TextBox();
            this.cmbProgram = new System.Windows.Forms.ComboBox();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.cmbRoomNumber = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.panelHeader.SuspendLayout();
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
            this.lblTitle.Size = new System.Drawing.Size(250, 32);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "STUDENT MANAGEMENT";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblName.Location = new System.Drawing.Point(50, 90);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(48, 19);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name:";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtName.Location = new System.Drawing.Point(150, 87);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(250, 25);
            this.txtName.TabIndex = 2;
            // 
            // lblRollNo
            // 
            this.lblRollNo.AutoSize = true;
            this.lblRollNo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblRollNo.Location = new System.Drawing.Point(50, 125);
            this.lblRollNo.Name = "lblRollNo";
            this.lblRollNo.Size = new System.Drawing.Size(55, 19);
            this.lblRollNo.TabIndex = 3;
            this.lblRollNo.Text = "Roll No:";
            // 
            // txtRollNo
            // 
            this.txtRollNo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtRollNo.Location = new System.Drawing.Point(150, 122);
            this.txtRollNo.Name = "txtRollNo";
            this.txtRollNo.Size = new System.Drawing.Size(250, 25);
            this.txtRollNo.TabIndex = 4;
            // 
            // lblCNIC
            // 
            this.lblCNIC.AutoSize = true;
            this.lblCNIC.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblCNIC.Location = new System.Drawing.Point(50, 160);
            this.lblCNIC.Name = "lblCNIC";
            this.lblCNIC.Size = new System.Drawing.Size(42, 19);
            this.lblCNIC.TabIndex = 5;
            this.lblCNIC.Text = "CNIC:";
            // 
            // txtCNIC
            // 
            this.txtCNIC.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtCNIC.Location = new System.Drawing.Point(150, 157);
            this.txtCNIC.Name = "txtCNIC";
            this.txtCNIC.Size = new System.Drawing.Size(250, 25);
            this.txtCNIC.TabIndex = 6;
            // 
            // lblProgram
            // 
            this.lblProgram.AutoSize = true;
            this.lblProgram.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblProgram.Location = new System.Drawing.Point(50, 195);
            this.lblProgram.Name = "lblProgram";
            this.lblProgram.Size = new System.Drawing.Size(64, 19);
            this.lblProgram.TabIndex = 7;
            this.lblProgram.Text = "Program:";
            // 
            // cmbProgram
            // 
            this.cmbProgram.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProgram.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbProgram.Items.AddRange(new object[] { "Select Program", "BSCS", "BSAI", "BSSE", "BBA" });
            this.cmbProgram.Location = new System.Drawing.Point(150, 192);
            this.cmbProgram.Name = "cmbProgram";
            this.cmbProgram.Size = new System.Drawing.Size(250, 25);
            this.cmbProgram.TabIndex = 8;
            this.cmbProgram.SelectedIndex = 0;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblCategory.Location = new System.Drawing.Point(50, 230);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(64, 19);
            this.lblCategory.TabIndex = 9;
            this.lblCategory.Text = "Category:";
            // 
            // cmbCategory
            // 
            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategory.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbCategory.Items.AddRange(new object[] { "Day Scholar Student", "Hostel Student" });
            this.cmbCategory.Location = new System.Drawing.Point(150, 227);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(250, 25);
            this.cmbCategory.TabIndex = 10;
            this.cmbCategory.SelectedIndex = 0;
            this.cmbCategory.SelectedIndexChanged += new System.EventHandler(this.cmbCategory_SelectedIndexChanged);
            // 
            // lblRoom
            // 
            this.lblRoom.AutoSize = true;
            this.lblRoom.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblRoom.Location = new System.Drawing.Point(50, 265);
            this.lblRoom.Name = "lblRoom";
            this.lblRoom.Size = new System.Drawing.Size(48, 19);
            this.lblRoom.TabIndex = 11;
            this.lblRoom.Text = "Room:";
            this.lblRoom.Visible = false;
            // 
            // cmbRoomNumber
            // 
            this.cmbRoomNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRoomNumber.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbRoomNumber.Items.AddRange(new object[] { "101", "102", "103", "201", "202", "203", "301", "302" });
            this.cmbRoomNumber.Location = new System.Drawing.Point(150, 262);
            this.cmbRoomNumber.Name = "cmbRoomNumber";
            this.cmbRoomNumber.Size = new System.Drawing.Size(250, 25);
            this.cmbRoomNumber.TabIndex = 12;
            this.cmbRoomNumber.Visible = false;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblPhone.Location = new System.Drawing.Point(500, 90);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(50, 19);
            this.lblPhone.TabIndex = 13;
            this.lblPhone.Text = "Phone:";
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPhone.Location = new System.Drawing.Point(600, 87);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(250, 25);
            this.txtPhone.TabIndex = 14;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblAddress.Location = new System.Drawing.Point(500, 125);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(62, 19);
            this.lblAddress.TabIndex = 15;
            this.lblAddress.Text = "Address:";
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtAddress.Location = new System.Drawing.Point(600, 122);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(250, 60);
            this.txtAddress.TabIndex = 16;
            // 
            // lblMatric
            // 
            this.lblMatric.AutoSize = true;
            this.lblMatric.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblMatric.Location = new System.Drawing.Point(500, 200);
            this.lblMatric.Name = "lblMatric";
            this.lblMatric.Size = new System.Drawing.Size(93, 19);
            this.lblMatric.TabIndex = 17;
            this.lblMatric.Text = "Matric Marks:";
            // 
            // txtMatric
            // 
            this.txtMatric.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtMatric.Location = new System.Drawing.Point(600, 197);
            this.txtMatric.Name = "txtMatric";
            this.txtMatric.Size = new System.Drawing.Size(120, 25);
            this.txtMatric.TabIndex = 18;
            // 
            // lblInter
            // 
            this.lblInter.AutoSize = true;
            this.lblInter.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblInter.Location = new System.Drawing.Point(500, 235);
            this.lblInter.Name = "lblInter";
            this.lblInter.Size = new System.Drawing.Size(78, 19);
            this.lblInter.TabIndex = 19;
            this.lblInter.Text = "Inter Marks:";
            // 
            // txtInter
            // 
            this.txtInter.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtInter.Location = new System.Drawing.Point(600, 232);
            this.txtInter.Name = "txtInter";
            this.txtInter.Size = new System.Drawing.Size(120, 25);
            this.txtInter.TabIndex = 20;
            // 
            // lblEntryTest
            // 
            this.lblEntryTest.AutoSize = true;
            this.lblEntryTest.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblEntryTest.Location = new System.Drawing.Point(500, 270);
            this.lblEntryTest.Name = "lblEntryTest";
            this.lblEntryTest.Size = new System.Drawing.Size(96, 19);
            this.lblEntryTest.TabIndex = 21;
            this.lblEntryTest.Text = "Entry Test (0-100):";
            // 
            // txtEntryTest
            // 
            this.txtEntryTest.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtEntryTest.Location = new System.Drawing.Point(600, 267);
            this.txtEntryTest.Name = "txtEntryTest";
            this.txtEntryTest.Size = new System.Drawing.Size(120, 25);
            this.txtEntryTest.TabIndex = 22;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.ForestGreen;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(200, 330);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(120, 45);
            this.btnSave.TabIndex = 23;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Gray;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(380, 330);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(120, 45);
            this.btnClear.TabIndex = 24;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(560, 330);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(120, 45);
            this.btnSearch.TabIndex = 25;
            this.btnSearch.Text = "SEARCH";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // frmStudentManagement
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(900, 420);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtEntryTest);
            this.Controls.Add(this.lblEntryTest);
            this.Controls.Add(this.txtInter);
            this.Controls.Add(this.lblInter);
            this.Controls.Add(this.txtMatric);
            this.Controls.Add(this.lblMatric);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.cmbRoomNumber);
            this.Controls.Add(this.lblRoom);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.cmbProgram);
            this.Controls.Add(this.lblProgram);
            this.Controls.Add(this.txtCNIC);
            this.Controls.Add(this.lblCNIC);
            this.Controls.Add(this.txtRollNo);
            this.Controls.Add(this.lblRollNo);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmStudentManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UMS - Student Management";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}