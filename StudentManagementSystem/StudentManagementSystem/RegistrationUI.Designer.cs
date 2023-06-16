
namespace StudentManagementSystem
{
    partial class RegistrationUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrationUI));
            this.groupBasic = new System.Windows.Forms.GroupBox();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.lbGender = new System.Windows.Forms.Label();
            this.lbDOB = new System.Windows.Forms.Label();
            this.txtLastname = new System.Windows.Forms.TextBox();
            this.txtFirstname = new System.Windows.Forms.TextBox();
            this.lbFullname = new System.Windows.Forms.Label();
            this.groupContact = new System.Windows.Forms.GroupBox();
            this.lbPhone = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.txtHome = new System.Windows.Forms.TextBox();
            this.txtMobile = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.comboDisctrict = new System.Windows.Forms.ComboBox();
            this.comboProvince = new System.Windows.Forms.ComboBox();
            this.txtAddressLine2 = new System.Windows.Forms.TextBox();
            this.txtAddressLine1 = new System.Windows.Forms.TextBox();
            this.lbAddress = new System.Windows.Forms.Label();
            this.groupParent = new System.Windows.Forms.GroupBox();
            this.lbParentContact = new System.Windows.Forms.Label();
            this.lbParentNIC = new System.Windows.Forms.Label();
            this.txtParentContact = new System.Windows.Forms.TextBox();
            this.txtParentNIC = new System.Windows.Forms.TextBox();
            this.txtParentName = new System.Windows.Forms.TextBox();
            this.lbParentName = new System.Windows.Forms.Label();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.lbDetails = new System.Windows.Forms.Label();
            this.groupStatus = new System.Windows.Forms.GroupBox();
            this.lbStudents = new System.Windows.Forms.Label();
            this.lbTotal = new System.Windows.Forms.Label();
            this.lbStdCount = new System.Windows.Forms.Label();
            this.btRegister = new System.Windows.Forms.Button();
            this.btUpdate = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.btClear = new System.Windows.Forms.Button();
            this.btLogout = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.picFlag = new System.Windows.Forms.PictureBox();
            this.comboStdID = new System.Windows.Forms.ComboBox();
            this.lbStdID = new System.Windows.Forms.Label();
            this.groupBasic.SuspendLayout();
            this.groupContact.SuspendLayout();
            this.groupParent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.groupStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFlag)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBasic
            // 
            this.groupBasic.Controls.Add(this.rbFemale);
            this.groupBasic.Controls.Add(this.rbMale);
            this.groupBasic.Controls.Add(this.datePicker);
            this.groupBasic.Controls.Add(this.lbGender);
            this.groupBasic.Controls.Add(this.lbDOB);
            this.groupBasic.Controls.Add(this.txtLastname);
            this.groupBasic.Controls.Add(this.txtFirstname);
            this.groupBasic.Controls.Add(this.lbFullname);
            this.groupBasic.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBasic.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBasic.Location = new System.Drawing.Point(32, 81);
            this.groupBasic.Name = "groupBasic";
            this.groupBasic.Size = new System.Drawing.Size(516, 164);
            this.groupBasic.TabIndex = 7;
            this.groupBasic.TabStop = false;
            this.groupBasic.Text = "Basic";
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFemale.Location = new System.Drawing.Point(205, 112);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(75, 23);
            this.rbFemale.TabIndex = 5;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "Female";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMale.Location = new System.Drawing.Point(129, 112);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(59, 23);
            this.rbMale.TabIndex = 4;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Male";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // datePicker
            // 
            this.datePicker.CustomFormat = "yyyy-MM-dd";
            this.datePicker.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datePicker.Location = new System.Drawing.Point(120, 79);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(366, 27);
            this.datePicker.TabIndex = 3;
            // 
            // lbGender
            // 
            this.lbGender.AutoSize = true;
            this.lbGender.Location = new System.Drawing.Point(50, 114);
            this.lbGender.Name = "lbGender";
            this.lbGender.Size = new System.Drawing.Size(64, 19);
            this.lbGender.TabIndex = 6;
            this.lbGender.Text = "Gender";
            // 
            // lbDOB
            // 
            this.lbDOB.AutoSize = true;
            this.lbDOB.Location = new System.Drawing.Point(14, 84);
            this.lbDOB.Name = "lbDOB";
            this.lbDOB.Size = new System.Drawing.Size(100, 19);
            this.lbDOB.TabIndex = 4;
            this.lbDOB.Text = "Date of Birth";
            // 
            // txtLastname
            // 
            this.txtLastname.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastname.ForeColor = System.Drawing.Color.Gray;
            this.txtLastname.Location = new System.Drawing.Point(306, 46);
            this.txtLastname.Name = "txtLastname";
            this.txtLastname.Size = new System.Drawing.Size(180, 27);
            this.txtLastname.TabIndex = 2;
            this.txtLastname.Text = "  Last name";
            this.txtLastname.Enter += new System.EventHandler(this.txtLastname_Enter);
            this.txtLastname.Leave += new System.EventHandler(this.txtLastname_Leave);
            // 
            // txtFirstname
            // 
            this.txtFirstname.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstname.ForeColor = System.Drawing.Color.Gray;
            this.txtFirstname.Location = new System.Drawing.Point(120, 46);
            this.txtFirstname.Name = "txtFirstname";
            this.txtFirstname.Size = new System.Drawing.Size(180, 27);
            this.txtFirstname.TabIndex = 1;
            this.txtFirstname.Text = "  First name";
            this.txtFirstname.Enter += new System.EventHandler(this.txtFirstname_Enter);
            this.txtFirstname.Leave += new System.EventHandler(this.txtFirstname_Leave);
            // 
            // lbFullname
            // 
            this.lbFullname.AutoSize = true;
            this.lbFullname.Location = new System.Drawing.Point(35, 49);
            this.lbFullname.Name = "lbFullname";
            this.lbFullname.Size = new System.Drawing.Size(79, 19);
            this.lbFullname.TabIndex = 0;
            this.lbFullname.Text = "Full name";
            // 
            // groupContact
            // 
            this.groupContact.Controls.Add(this.lbPhone);
            this.groupContact.Controls.Add(this.lbEmail);
            this.groupContact.Controls.Add(this.txtHome);
            this.groupContact.Controls.Add(this.txtMobile);
            this.groupContact.Controls.Add(this.txtEmail);
            this.groupContact.Controls.Add(this.comboDisctrict);
            this.groupContact.Controls.Add(this.comboProvince);
            this.groupContact.Controls.Add(this.txtAddressLine2);
            this.groupContact.Controls.Add(this.txtAddressLine1);
            this.groupContact.Controls.Add(this.lbAddress);
            this.groupContact.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupContact.Location = new System.Drawing.Point(32, 251);
            this.groupContact.Name = "groupContact";
            this.groupContact.Size = new System.Drawing.Size(516, 228);
            this.groupContact.TabIndex = 8;
            this.groupContact.TabStop = false;
            this.groupContact.Text = "Contact";
            // 
            // lbPhone
            // 
            this.lbPhone.AutoSize = true;
            this.lbPhone.Location = new System.Drawing.Point(59, 181);
            this.lbPhone.Name = "lbPhone";
            this.lbPhone.Size = new System.Drawing.Size(55, 19);
            this.lbPhone.TabIndex = 14;
            this.lbPhone.Text = "Phone";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(65, 148);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(49, 19);
            this.lbEmail.TabIndex = 13;
            this.lbEmail.Text = "Email";
            // 
            // txtHome
            // 
            this.txtHome.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHome.ForeColor = System.Drawing.Color.Gray;
            this.txtHome.Location = new System.Drawing.Point(306, 178);
            this.txtHome.MaxLength = 10;
            this.txtHome.Name = "txtHome";
            this.txtHome.Size = new System.Drawing.Size(180, 27);
            this.txtHome.TabIndex = 6;
            this.txtHome.Text = "  Home";
            this.txtHome.Enter += new System.EventHandler(this.txtHome_Enter);
            this.txtHome.Leave += new System.EventHandler(this.txtHome_Leave);
            // 
            // txtMobile
            // 
            this.txtMobile.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMobile.ForeColor = System.Drawing.Color.Gray;
            this.txtMobile.Location = new System.Drawing.Point(120, 178);
            this.txtMobile.MaxLength = 10;
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.Size = new System.Drawing.Size(180, 27);
            this.txtMobile.TabIndex = 5;
            this.txtMobile.Text = "  Mobile";
            this.txtMobile.Enter += new System.EventHandler(this.txtMobile_Enter);
            this.txtMobile.Leave += new System.EventHandler(this.txtMobile_Leave);
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.Gray;
            this.txtEmail.Location = new System.Drawing.Point(120, 145);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(366, 27);
            this.txtEmail.TabIndex = 4;
            this.txtEmail.Text = "  example@example.com";
            this.txtEmail.Enter += new System.EventHandler(this.txtEmail_Enter);
            this.txtEmail.Leave += new System.EventHandler(this.txtEmail_Leave);
            // 
            // comboDisctrict
            // 
            this.comboDisctrict.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboDisctrict.ForeColor = System.Drawing.Color.Gray;
            this.comboDisctrict.FormattingEnabled = true;
            this.comboDisctrict.Items.AddRange(new object[] {
            "Ampara",
            "Anuradhapura",
            "Badulla",
            "Batticaloa",
            "Colombo",
            "Galle",
            "Gampaha",
            "Hambantota",
            "Jaffna",
            "Kalutara",
            "Kandy",
            "Kegalle",
            "Kilinochchi",
            "Kurunegala",
            "Mannar",
            "Matale",
            "Matara",
            "Monaragala",
            "Mullaitivu",
            "Nuwara Eliya",
            "Polonnaruwa",
            "Puttalam",
            "Ratnapura",
            "Trincomalee",
            "Vavuniya"});
            this.comboDisctrict.Location = new System.Drawing.Point(120, 112);
            this.comboDisctrict.Name = "comboDisctrict";
            this.comboDisctrict.Size = new System.Drawing.Size(180, 27);
            this.comboDisctrict.Sorted = true;
            this.comboDisctrict.TabIndex = 2;
            this.comboDisctrict.Text = "  District";
            this.comboDisctrict.Enter += new System.EventHandler(this.comboDisctrict_Enter);
            this.comboDisctrict.Leave += new System.EventHandler(this.comboDisctrict_Leave);
            // 
            // comboProvince
            // 
            this.comboProvince.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboProvince.ForeColor = System.Drawing.Color.Gray;
            this.comboProvince.FormattingEnabled = true;
            this.comboProvince.Items.AddRange(new object[] {
            "Central",
            "Eastern",
            "North Central",
            "North Western",
            "Nothern",
            "Sabaragamuwa",
            "Southern",
            "Uva",
            "Western"});
            this.comboProvince.Location = new System.Drawing.Point(306, 112);
            this.comboProvince.Name = "comboProvince";
            this.comboProvince.Size = new System.Drawing.Size(180, 27);
            this.comboProvince.Sorted = true;
            this.comboProvince.TabIndex = 3;
            this.comboProvince.Text = "  Province";
            this.comboProvince.Enter += new System.EventHandler(this.comboProvince_Enter);
            this.comboProvince.Leave += new System.EventHandler(this.comboProvince_Leave);
            // 
            // txtAddressLine2
            // 
            this.txtAddressLine2.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddressLine2.ForeColor = System.Drawing.Color.Gray;
            this.txtAddressLine2.Location = new System.Drawing.Point(120, 79);
            this.txtAddressLine2.Name = "txtAddressLine2";
            this.txtAddressLine2.Size = new System.Drawing.Size(366, 27);
            this.txtAddressLine2.TabIndex = 1;
            this.txtAddressLine2.Text = "  Address Line 2";
            this.txtAddressLine2.Enter += new System.EventHandler(this.txtAddressLine2_Enter);
            this.txtAddressLine2.Leave += new System.EventHandler(this.txtAddressLine2_Leave);
            // 
            // txtAddressLine1
            // 
            this.txtAddressLine1.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddressLine1.ForeColor = System.Drawing.Color.Gray;
            this.txtAddressLine1.Location = new System.Drawing.Point(120, 46);
            this.txtAddressLine1.Name = "txtAddressLine1";
            this.txtAddressLine1.Size = new System.Drawing.Size(366, 27);
            this.txtAddressLine1.TabIndex = 0;
            this.txtAddressLine1.Text = "  Address Line 1";
            this.txtAddressLine1.Enter += new System.EventHandler(this.txtAddressLine1_Enter);
            this.txtAddressLine1.Leave += new System.EventHandler(this.txtAddressLine1_Leave);
            // 
            // lbAddress
            // 
            this.lbAddress.AutoSize = true;
            this.lbAddress.Location = new System.Drawing.Point(43, 49);
            this.lbAddress.Name = "lbAddress";
            this.lbAddress.Size = new System.Drawing.Size(71, 19);
            this.lbAddress.TabIndex = 0;
            this.lbAddress.Text = "Address";
            // 
            // groupParent
            // 
            this.groupParent.Controls.Add(this.lbParentContact);
            this.groupParent.Controls.Add(this.lbParentNIC);
            this.groupParent.Controls.Add(this.txtParentContact);
            this.groupParent.Controls.Add(this.txtParentNIC);
            this.groupParent.Controls.Add(this.txtParentName);
            this.groupParent.Controls.Add(this.lbParentName);
            this.groupParent.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupParent.Location = new System.Drawing.Point(32, 485);
            this.groupParent.Name = "groupParent";
            this.groupParent.Size = new System.Drawing.Size(516, 164);
            this.groupParent.TabIndex = 9;
            this.groupParent.TabStop = false;
            this.groupParent.Text = "Parent";
            // 
            // lbParentContact
            // 
            this.lbParentContact.AutoSize = true;
            this.lbParentContact.Location = new System.Drawing.Point(21, 115);
            this.lbParentContact.Name = "lbParentContact";
            this.lbParentContact.Size = new System.Drawing.Size(93, 19);
            this.lbParentContact.TabIndex = 14;
            this.lbParentContact.Text = "Contact no.";
            // 
            // lbParentNIC
            // 
            this.lbParentNIC.AutoSize = true;
            this.lbParentNIC.Location = new System.Drawing.Point(79, 82);
            this.lbParentNIC.Name = "lbParentNIC";
            this.lbParentNIC.Size = new System.Drawing.Size(35, 19);
            this.lbParentNIC.TabIndex = 13;
            this.lbParentNIC.Text = "NIC";
            // 
            // txtParentContact
            // 
            this.txtParentContact.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtParentContact.ForeColor = System.Drawing.Color.Gray;
            this.txtParentContact.Location = new System.Drawing.Point(120, 112);
            this.txtParentContact.MaxLength = 10;
            this.txtParentContact.Name = "txtParentContact";
            this.txtParentContact.Size = new System.Drawing.Size(237, 27);
            this.txtParentContact.TabIndex = 2;
            this.txtParentContact.Text = "  Parent\'s contact no.";
            this.txtParentContact.Enter += new System.EventHandler(this.txtParentContact_Enter);
            this.txtParentContact.Leave += new System.EventHandler(this.txtParentContact_Leave);
            // 
            // txtParentNIC
            // 
            this.txtParentNIC.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtParentNIC.ForeColor = System.Drawing.Color.Gray;
            this.txtParentNIC.Location = new System.Drawing.Point(120, 79);
            this.txtParentNIC.MaxLength = 12;
            this.txtParentNIC.Name = "txtParentNIC";
            this.txtParentNIC.Size = new System.Drawing.Size(237, 27);
            this.txtParentNIC.TabIndex = 1;
            this.txtParentNIC.Text = "  Parent\'s National ID";
            this.txtParentNIC.Enter += new System.EventHandler(this.txtParentNIC_Enter);
            this.txtParentNIC.Leave += new System.EventHandler(this.txtParentNIC_Leave);
            // 
            // txtParentName
            // 
            this.txtParentName.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtParentName.ForeColor = System.Drawing.Color.Gray;
            this.txtParentName.Location = new System.Drawing.Point(120, 46);
            this.txtParentName.Name = "txtParentName";
            this.txtParentName.Size = new System.Drawing.Size(366, 27);
            this.txtParentName.TabIndex = 0;
            this.txtParentName.Text = "  Parent\'s name";
            this.txtParentName.Enter += new System.EventHandler(this.txtParentName_Enter);
            this.txtParentName.Leave += new System.EventHandler(this.txtParentName_Leave);
            // 
            // lbParentName
            // 
            this.lbParentName.AutoSize = true;
            this.lbParentName.Location = new System.Drawing.Point(13, 49);
            this.lbParentName.Name = "lbParentName";
            this.lbParentName.Size = new System.Drawing.Size(101, 19);
            this.lbParentName.TabIndex = 0;
            this.lbParentName.Text = "Parent name";
            // 
            // dataGrid
            // 
            this.dataGrid.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Location = new System.Drawing.Point(564, 92);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.Size = new System.Drawing.Size(367, 557);
            this.dataGrid.TabIndex = 16;
            // 
            // lbDetails
            // 
            this.lbDetails.AutoSize = true;
            this.lbDetails.Font = new System.Drawing.Font("SF Pro Display", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDetails.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbDetails.Location = new System.Drawing.Point(72, 26);
            this.lbDetails.Name = "lbDetails";
            this.lbDetails.Size = new System.Drawing.Size(101, 32);
            this.lbDetails.TabIndex = 17;
            this.lbDetails.Text = "Details";
            // 
            // groupStatus
            // 
            this.groupStatus.Controls.Add(this.lbStudents);
            this.groupStatus.Controls.Add(this.lbTotal);
            this.groupStatus.Controls.Add(this.lbStdCount);
            this.groupStatus.Location = new System.Drawing.Point(948, 85);
            this.groupStatus.Name = "groupStatus";
            this.groupStatus.Size = new System.Drawing.Size(200, 287);
            this.groupStatus.TabIndex = 21;
            this.groupStatus.TabStop = false;
            // 
            // lbStudents
            // 
            this.lbStudents.AutoSize = true;
            this.lbStudents.Font = new System.Drawing.Font("SF Pro Display", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStudents.Location = new System.Drawing.Point(36, 208);
            this.lbStudents.Name = "lbStudents";
            this.lbStudents.Size = new System.Drawing.Size(129, 32);
            this.lbStudents.TabIndex = 2;
            this.lbStudents.Text = "Students";
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Font = new System.Drawing.Font("SF Pro Display", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotal.Location = new System.Drawing.Point(63, 46);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(75, 32);
            this.lbTotal.TabIndex = 1;
            this.lbTotal.Text = "Total";
            // 
            // lbStdCount
            // 
            this.lbStdCount.AutoSize = true;
            this.lbStdCount.Font = new System.Drawing.Font("SF Pro Display", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStdCount.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbStdCount.Location = new System.Drawing.Point(50, 84);
            this.lbStdCount.Name = "lbStdCount";
            this.lbStdCount.Size = new System.Drawing.Size(111, 115);
            this.lbStdCount.TabIndex = 0;
            this.lbStdCount.Text = "0";
            // 
            // btRegister
            // 
            this.btRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRegister.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRegister.Location = new System.Drawing.Point(948, 385);
            this.btRegister.Name = "btRegister";
            this.btRegister.Size = new System.Drawing.Size(200, 39);
            this.btRegister.TabIndex = 1;
            this.btRegister.Text = "Register";
            this.btRegister.UseVisualStyleBackColor = true;
            this.btRegister.Click += new System.EventHandler(this.btRegister_Click);
            // 
            // btUpdate
            // 
            this.btUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btUpdate.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btUpdate.Location = new System.Drawing.Point(948, 430);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(200, 39);
            this.btUpdate.TabIndex = 2;
            this.btUpdate.Text = "Update";
            this.btUpdate.UseVisualStyleBackColor = true;
            this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
            // 
            // btDelete
            // 
            this.btDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDelete.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDelete.Location = new System.Drawing.Point(948, 475);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(200, 39);
            this.btDelete.TabIndex = 3;
            this.btDelete.Text = "Delete";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btClear
            // 
            this.btClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btClear.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btClear.Location = new System.Drawing.Point(948, 520);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(200, 39);
            this.btClear.TabIndex = 4;
            this.btClear.Text = "Clear";
            this.btClear.UseVisualStyleBackColor = true;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // btLogout
            // 
            this.btLogout.BackColor = System.Drawing.Color.Transparent;
            this.btLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btLogout.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(69)))), ((int)(((byte)(254)))));
            this.btLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLogout.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLogout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(69)))), ((int)(((byte)(254)))));
            this.btLogout.Location = new System.Drawing.Point(948, 565);
            this.btLogout.Name = "btLogout";
            this.btLogout.Size = new System.Drawing.Size(200, 39);
            this.btLogout.TabIndex = 5;
            this.btLogout.Text = "Log out";
            this.btLogout.UseVisualStyleBackColor = false;
            this.btLogout.Click += new System.EventHandler(this.btLogout_Click);
            // 
            // btExit
            // 
            this.btExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(69)))), ((int)(((byte)(254)))));
            this.btExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btExit.FlatAppearance.BorderSize = 0;
            this.btExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btExit.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExit.ForeColor = System.Drawing.SystemColors.Control;
            this.btExit.Location = new System.Drawing.Point(948, 610);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(200, 39);
            this.btExit.TabIndex = 6;
            this.btExit.Text = "Exit";
            this.btExit.UseVisualStyleBackColor = false;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // picFlag
            // 
            this.picFlag.Image = global::StudentManagementSystem.Properties.Resources.flag;
            this.picFlag.Location = new System.Drawing.Point(32, 19);
            this.picFlag.Name = "picFlag";
            this.picFlag.Size = new System.Drawing.Size(42, 45);
            this.picFlag.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picFlag.TabIndex = 28;
            this.picFlag.TabStop = false;
            // 
            // comboStdID
            // 
            this.comboStdID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboStdID.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboStdID.FormattingEnabled = true;
            this.comboStdID.Location = new System.Drawing.Point(948, 31);
            this.comboStdID.Name = "comboStdID";
            this.comboStdID.Size = new System.Drawing.Size(200, 27);
            this.comboStdID.Sorted = true;
            this.comboStdID.TabIndex = 0;
            this.comboStdID.SelectedIndexChanged += new System.EventHandler(this.comboStdID_SelectedIndexChanged);
            // 
            // lbStdID
            // 
            this.lbStdID.AutoSize = true;
            this.lbStdID.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStdID.Location = new System.Drawing.Point(856, 35);
            this.lbStdID.Name = "lbStdID";
            this.lbStdID.Size = new System.Drawing.Size(86, 19);
            this.lbStdID.TabIndex = 11;
            this.lbStdID.Text = "Student ID";
            // 
            // RegistrationUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 681);
            this.Controls.Add(this.lbStdID);
            this.Controls.Add(this.comboStdID);
            this.Controls.Add(this.picFlag);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btLogout);
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btUpdate);
            this.Controls.Add(this.btRegister);
            this.Controls.Add(this.groupStatus);
            this.Controls.Add(this.lbDetails);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.groupParent);
            this.Controls.Add(this.groupContact);
            this.Controls.Add(this.groupBasic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "RegistrationUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.Load += new System.EventHandler(this.RegistrationUI_Load);
            this.Shown += new System.EventHandler(this.RegistrationUI_Shown);
            this.groupBasic.ResumeLayout(false);
            this.groupBasic.PerformLayout();
            this.groupContact.ResumeLayout(false);
            this.groupContact.PerformLayout();
            this.groupParent.ResumeLayout(false);
            this.groupParent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.groupStatus.ResumeLayout(false);
            this.groupStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFlag)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBasic;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.Label lbGender;
        private System.Windows.Forms.Label lbDOB;
        private System.Windows.Forms.TextBox txtLastname;
        private System.Windows.Forms.TextBox txtFirstname;
        private System.Windows.Forms.Label lbFullname;
        private System.Windows.Forms.GroupBox groupContact;
        private System.Windows.Forms.TextBox txtHome;
        private System.Windows.Forms.TextBox txtMobile;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.ComboBox comboDisctrict;
        private System.Windows.Forms.ComboBox comboProvince;
        private System.Windows.Forms.TextBox txtAddressLine2;
        private System.Windows.Forms.TextBox txtAddressLine1;
        private System.Windows.Forms.Label lbAddress;
        private System.Windows.Forms.Label lbPhone;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.GroupBox groupParent;
        private System.Windows.Forms.Label lbParentContact;
        private System.Windows.Forms.Label lbParentNIC;
        private System.Windows.Forms.TextBox txtParentContact;
        private System.Windows.Forms.TextBox txtParentNIC;
        private System.Windows.Forms.TextBox txtParentName;
        private System.Windows.Forms.Label lbParentName;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.Label lbDetails;
        private System.Windows.Forms.GroupBox groupStatus;
        private System.Windows.Forms.Button btRegister;
        private System.Windows.Forms.Button btUpdate;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.Button btLogout;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Label lbStudents;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Label lbStdCount;
        private System.Windows.Forms.PictureBox picFlag;
        private System.Windows.Forms.ComboBox comboStdID;
        private System.Windows.Forms.Label lbStdID;
    }
}