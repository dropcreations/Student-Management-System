
namespace StudentManagementSystem
{
    partial class ForgotPassUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForgotPassUI));
            this.lbContinueDesc = new System.Windows.Forms.Label();
            this.picClearUserNIC = new System.Windows.Forms.PictureBox();
            this.picClearUserID = new System.Windows.Forms.PictureBox();
            this.txtUserNIC = new System.Windows.Forms.TextBox();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.btContinueCancel = new System.Windows.Forms.Button();
            this.btContinue = new System.Windows.Forms.Button();
            this.borderUserNIC = new System.Windows.Forms.TextBox();
            this.lbUserNIC = new System.Windows.Forms.Label();
            this.borderUserID = new System.Windows.Forms.TextBox();
            this.lbUserID = new System.Windows.Forms.Label();
            this.groupContinue = new System.Windows.Forms.GroupBox();
            this.panelContinue = new System.Windows.Forms.Panel();
            this.panelReset = new System.Windows.Forms.Panel();
            this.groupReset = new System.Windows.Forms.GroupBox();
            this.error = new System.Windows.Forms.Label();
            this.picEyeConfirmPassword = new System.Windows.Forms.PictureBox();
            this.picEyeNewPassword = new System.Windows.Forms.PictureBox();
            this.picClearConfirmPassword = new System.Windows.Forms.PictureBox();
            this.picClearNewPassword = new System.Windows.Forms.PictureBox();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.btResetCancel = new System.Windows.Forms.Button();
            this.btReset = new System.Windows.Forms.Button();
            this.borderConfirmPassword = new System.Windows.Forms.TextBox();
            this.lbConfirmPassword = new System.Windows.Forms.Label();
            this.borderNewPassword = new System.Windows.Forms.TextBox();
            this.lbNewPassword = new System.Windows.Forms.Label();
            this.lbResetDesc = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picClearUserNIC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClearUserID)).BeginInit();
            this.groupContinue.SuspendLayout();
            this.panelContinue.SuspendLayout();
            this.panelReset.SuspendLayout();
            this.groupReset.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picEyeConfirmPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEyeNewPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClearConfirmPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClearNewPassword)).BeginInit();
            this.SuspendLayout();
            // 
            // lbContinueDesc
            // 
            this.lbContinueDesc.AutoSize = true;
            this.lbContinueDesc.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbContinueDesc.Location = new System.Drawing.Point(36, 71);
            this.lbContinueDesc.Name = "lbContinueDesc";
            this.lbContinueDesc.Size = new System.Drawing.Size(310, 38);
            this.lbContinueDesc.TabIndex = 1;
            this.lbContinueDesc.Text = "Please enter your User ID and NIC to reset\r\nyour account password";
            // 
            // picClearUserNIC
            // 
            this.picClearUserNIC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picClearUserNIC.Image = global::StudentManagementSystem.Properties.Resources.clear;
            this.picClearUserNIC.Location = new System.Drawing.Point(364, 243);
            this.picClearUserNIC.Name = "picClearUserNIC";
            this.picClearUserNIC.Size = new System.Drawing.Size(22, 40);
            this.picClearUserNIC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picClearUserNIC.TabIndex = 25;
            this.picClearUserNIC.TabStop = false;
            this.picClearUserNIC.Visible = false;
            this.picClearUserNIC.Click += new System.EventHandler(this.picClearUserNIC_Click);
            // 
            // picClearUserID
            // 
            this.picClearUserID.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picClearUserID.Image = global::StudentManagementSystem.Properties.Resources.clear;
            this.picClearUserID.Location = new System.Drawing.Point(364, 168);
            this.picClearUserID.Name = "picClearUserID";
            this.picClearUserID.Size = new System.Drawing.Size(22, 40);
            this.picClearUserID.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picClearUserID.TabIndex = 14;
            this.picClearUserID.TabStop = false;
            this.picClearUserID.Visible = false;
            this.picClearUserID.Click += new System.EventHandler(this.picClearUserID_Click);
            // 
            // txtUserNIC
            // 
            this.txtUserNIC.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUserNIC.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserNIC.Location = new System.Drawing.Point(48, 253);
            this.txtUserNIC.MaxLength = 12;
            this.txtUserNIC.Name = "txtUserNIC";
            this.txtUserNIC.Size = new System.Drawing.Size(293, 20);
            this.txtUserNIC.TabIndex = 24;
            this.txtUserNIC.TextChanged += new System.EventHandler(this.txtUserNIC_TextChanged);
            // 
            // txtUserID
            // 
            this.txtUserID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUserID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtUserID.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserID.Location = new System.Drawing.Point(48, 178);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Size = new System.Drawing.Size(294, 20);
            this.txtUserID.TabIndex = 23;
            this.txtUserID.TextChanged += new System.EventHandler(this.txtUserID_TextChanged);
            // 
            // btContinueCancel
            // 
            this.btContinueCancel.BackColor = System.Drawing.Color.Transparent;
            this.btContinueCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btContinueCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btContinueCancel.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btContinueCancel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btContinueCancel.Location = new System.Drawing.Point(205, 321);
            this.btContinueCancel.Name = "btContinueCancel";
            this.btContinueCancel.Size = new System.Drawing.Size(153, 40);
            this.btContinueCancel.TabIndex = 20;
            this.btContinueCancel.Text = "Cancel";
            this.btContinueCancel.UseVisualStyleBackColor = false;
            this.btContinueCancel.Click += new System.EventHandler(this.btContinueCancel_Click);
            // 
            // btContinue
            // 
            this.btContinue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(69)))), ((int)(((byte)(254)))));
            this.btContinue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btContinue.FlatAppearance.BorderSize = 0;
            this.btContinue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btContinue.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btContinue.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btContinue.Location = new System.Drawing.Point(40, 321);
            this.btContinue.Name = "btContinue";
            this.btContinue.Size = new System.Drawing.Size(159, 40);
            this.btContinue.TabIndex = 19;
            this.btContinue.Text = "Continue";
            this.btContinue.UseVisualStyleBackColor = false;
            this.btContinue.Click += new System.EventHandler(this.btContinue_Click);
            // 
            // borderUserNIC
            // 
            this.borderUserNIC.Cursor = System.Windows.Forms.Cursors.Default;
            this.borderUserNIC.Font = new System.Drawing.Font("SF Pro Display", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borderUserNIC.Location = new System.Drawing.Point(40, 243);
            this.borderUserNIC.Name = "borderUserNIC";
            this.borderUserNIC.Size = new System.Drawing.Size(318, 40);
            this.borderUserNIC.TabIndex = 17;
            this.borderUserNIC.TabStop = false;
            this.borderUserNIC.Click += new System.EventHandler(this.borderUserNIC_Click);
            this.borderUserNIC.MouseDown += new System.Windows.Forms.MouseEventHandler(this.borderUserNIC_MouseDown);
            // 
            // lbUserNIC
            // 
            this.lbUserNIC.AutoSize = true;
            this.lbUserNIC.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUserNIC.Location = new System.Drawing.Point(36, 216);
            this.lbUserNIC.Name = "lbUserNIC";
            this.lbUserNIC.Size = new System.Drawing.Size(120, 19);
            this.lbUserNIC.TabIndex = 16;
            this.lbUserNIC.Text = "Enter your NIC :";
            // 
            // borderUserID
            // 
            this.borderUserID.Cursor = System.Windows.Forms.Cursors.Default;
            this.borderUserID.Font = new System.Drawing.Font("SF Pro Display", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borderUserID.Location = new System.Drawing.Point(40, 168);
            this.borderUserID.Name = "borderUserID";
            this.borderUserID.Size = new System.Drawing.Size(318, 40);
            this.borderUserID.TabIndex = 15;
            this.borderUserID.TabStop = false;
            this.borderUserID.Click += new System.EventHandler(this.borderUserID_Click);
            this.borderUserID.MouseDown += new System.Windows.Forms.MouseEventHandler(this.borderUserID_MouseDown);
            // 
            // lbUserID
            // 
            this.lbUserID.AutoSize = true;
            this.lbUserID.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUserID.Location = new System.Drawing.Point(36, 141);
            this.lbUserID.Name = "lbUserID";
            this.lbUserID.Size = new System.Drawing.Size(146, 19);
            this.lbUserID.TabIndex = 13;
            this.lbUserID.Text = "Enter your User ID :";
            // 
            // groupContinue
            // 
            this.groupContinue.Controls.Add(this.picClearUserNIC);
            this.groupContinue.Controls.Add(this.picClearUserID);
            this.groupContinue.Controls.Add(this.txtUserNIC);
            this.groupContinue.Controls.Add(this.txtUserID);
            this.groupContinue.Controls.Add(this.btContinueCancel);
            this.groupContinue.Controls.Add(this.btContinue);
            this.groupContinue.Controls.Add(this.borderUserNIC);
            this.groupContinue.Controls.Add(this.lbUserNIC);
            this.groupContinue.Controls.Add(this.borderUserID);
            this.groupContinue.Controls.Add(this.lbUserID);
            this.groupContinue.Controls.Add(this.lbContinueDesc);
            this.groupContinue.Font = new System.Drawing.Font("SF Pro Display", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupContinue.Location = new System.Drawing.Point(6, 14);
            this.groupContinue.Name = "groupContinue";
            this.groupContinue.Size = new System.Drawing.Size(394, 400);
            this.groupContinue.TabIndex = 26;
            this.groupContinue.TabStop = false;
            this.groupContinue.Text = "Reset password";
            // 
            // panelContinue
            // 
            this.panelContinue.Controls.Add(this.groupContinue);
            this.panelContinue.Location = new System.Drawing.Point(13, 0);
            this.panelContinue.Name = "panelContinue";
            this.panelContinue.Size = new System.Drawing.Size(406, 426);
            this.panelContinue.TabIndex = 26;
            // 
            // panelReset
            // 
            this.panelReset.Controls.Add(this.groupReset);
            this.panelReset.Location = new System.Drawing.Point(13, 0);
            this.panelReset.Name = "panelReset";
            this.panelReset.Size = new System.Drawing.Size(406, 426);
            this.panelReset.TabIndex = 27;
            this.panelReset.Visible = false;
            // 
            // groupReset
            // 
            this.groupReset.Controls.Add(this.error);
            this.groupReset.Controls.Add(this.picEyeConfirmPassword);
            this.groupReset.Controls.Add(this.picEyeNewPassword);
            this.groupReset.Controls.Add(this.picClearConfirmPassword);
            this.groupReset.Controls.Add(this.picClearNewPassword);
            this.groupReset.Controls.Add(this.txtConfirmPassword);
            this.groupReset.Controls.Add(this.txtNewPassword);
            this.groupReset.Controls.Add(this.btResetCancel);
            this.groupReset.Controls.Add(this.btReset);
            this.groupReset.Controls.Add(this.borderConfirmPassword);
            this.groupReset.Controls.Add(this.lbConfirmPassword);
            this.groupReset.Controls.Add(this.borderNewPassword);
            this.groupReset.Controls.Add(this.lbNewPassword);
            this.groupReset.Controls.Add(this.lbResetDesc);
            this.groupReset.Font = new System.Drawing.Font("SF Pro Display", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupReset.Location = new System.Drawing.Point(6, 14);
            this.groupReset.Name = "groupReset";
            this.groupReset.Size = new System.Drawing.Size(394, 400);
            this.groupReset.TabIndex = 26;
            this.groupReset.TabStop = false;
            this.groupReset.Text = "Reset password";
            // 
            // error
            // 
            this.error.AutoSize = true;
            this.error.Font = new System.Drawing.Font("SF Pro Display", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.error.ForeColor = System.Drawing.Color.Red;
            this.error.Location = new System.Drawing.Point(18, 251);
            this.error.Name = "error";
            this.error.Size = new System.Drawing.Size(19, 25);
            this.error.TabIndex = 28;
            this.error.Text = "!";
            this.error.Visible = false;
            // 
            // picEyeConfirmPassword
            // 
            this.picEyeConfirmPassword.BackColor = System.Drawing.SystemColors.Window;
            this.picEyeConfirmPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picEyeConfirmPassword.Image = global::StudentManagementSystem.Properties.Resources.eyeClose;
            this.picEyeConfirmPassword.Location = new System.Drawing.Point(328, 246);
            this.picEyeConfirmPassword.Name = "picEyeConfirmPassword";
            this.picEyeConfirmPassword.Size = new System.Drawing.Size(25, 34);
            this.picEyeConfirmPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picEyeConfirmPassword.TabIndex = 27;
            this.picEyeConfirmPassword.TabStop = false;
            this.picEyeConfirmPassword.Visible = false;
            this.picEyeConfirmPassword.Click += new System.EventHandler(this.picEyeConfirmPassword_Click);
            // 
            // picEyeNewPassword
            // 
            this.picEyeNewPassword.BackColor = System.Drawing.SystemColors.Window;
            this.picEyeNewPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picEyeNewPassword.Image = global::StudentManagementSystem.Properties.Resources.eyeClose;
            this.picEyeNewPassword.Location = new System.Drawing.Point(328, 171);
            this.picEyeNewPassword.Name = "picEyeNewPassword";
            this.picEyeNewPassword.Size = new System.Drawing.Size(25, 34);
            this.picEyeNewPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picEyeNewPassword.TabIndex = 26;
            this.picEyeNewPassword.TabStop = false;
            this.picEyeNewPassword.Visible = false;
            this.picEyeNewPassword.Click += new System.EventHandler(this.picEyeNewPassword_Click);
            // 
            // picClearConfirmPassword
            // 
            this.picClearConfirmPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picClearConfirmPassword.Image = global::StudentManagementSystem.Properties.Resources.clear;
            this.picClearConfirmPassword.Location = new System.Drawing.Point(364, 243);
            this.picClearConfirmPassword.Name = "picClearConfirmPassword";
            this.picClearConfirmPassword.Size = new System.Drawing.Size(22, 40);
            this.picClearConfirmPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picClearConfirmPassword.TabIndex = 25;
            this.picClearConfirmPassword.TabStop = false;
            this.picClearConfirmPassword.Visible = false;
            this.picClearConfirmPassword.Click += new System.EventHandler(this.picClearConfirmPassword_Click);
            // 
            // picClearNewPassword
            // 
            this.picClearNewPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picClearNewPassword.Image = global::StudentManagementSystem.Properties.Resources.clear;
            this.picClearNewPassword.Location = new System.Drawing.Point(364, 168);
            this.picClearNewPassword.Name = "picClearNewPassword";
            this.picClearNewPassword.Size = new System.Drawing.Size(22, 40);
            this.picClearNewPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picClearNewPassword.TabIndex = 14;
            this.picClearNewPassword.TabStop = false;
            this.picClearNewPassword.Visible = false;
            this.picClearNewPassword.Click += new System.EventHandler(this.picClearNewPassword_Click);
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtConfirmPassword.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmPassword.Location = new System.Drawing.Point(48, 253);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.Size = new System.Drawing.Size(267, 20);
            this.txtConfirmPassword.TabIndex = 24;
            this.txtConfirmPassword.UseSystemPasswordChar = true;
            this.txtConfirmPassword.TextChanged += new System.EventHandler(this.txtConfirmPassword_TextChanged);
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNewPassword.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewPassword.Location = new System.Drawing.Point(48, 178);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.Size = new System.Drawing.Size(267, 20);
            this.txtNewPassword.TabIndex = 23;
            this.txtNewPassword.UseSystemPasswordChar = true;
            this.txtNewPassword.TextChanged += new System.EventHandler(this.txtNewPassword_TextChanged);
            // 
            // btResetCancel
            // 
            this.btResetCancel.BackColor = System.Drawing.Color.Transparent;
            this.btResetCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btResetCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btResetCancel.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btResetCancel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btResetCancel.Location = new System.Drawing.Point(205, 321);
            this.btResetCancel.Name = "btResetCancel";
            this.btResetCancel.Size = new System.Drawing.Size(153, 40);
            this.btResetCancel.TabIndex = 20;
            this.btResetCancel.Text = "Cancel";
            this.btResetCancel.UseVisualStyleBackColor = false;
            this.btResetCancel.Click += new System.EventHandler(this.btResetCancel_Click);
            // 
            // btReset
            // 
            this.btReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(69)))), ((int)(((byte)(254)))));
            this.btReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btReset.FlatAppearance.BorderSize = 0;
            this.btReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btReset.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btReset.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btReset.Location = new System.Drawing.Point(40, 321);
            this.btReset.Name = "btReset";
            this.btReset.Size = new System.Drawing.Size(159, 40);
            this.btReset.TabIndex = 19;
            this.btReset.Text = "Reset";
            this.btReset.UseVisualStyleBackColor = false;
            this.btReset.Click += new System.EventHandler(this.btReset_Click);
            // 
            // borderConfirmPassword
            // 
            this.borderConfirmPassword.Cursor = System.Windows.Forms.Cursors.Default;
            this.borderConfirmPassword.Font = new System.Drawing.Font("SF Pro Display", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borderConfirmPassword.Location = new System.Drawing.Point(40, 243);
            this.borderConfirmPassword.Name = "borderConfirmPassword";
            this.borderConfirmPassword.Size = new System.Drawing.Size(318, 40);
            this.borderConfirmPassword.TabIndex = 17;
            this.borderConfirmPassword.TabStop = false;
            this.borderConfirmPassword.Click += new System.EventHandler(this.borderConfirmPassword_Click);
            this.borderConfirmPassword.MouseDown += new System.Windows.Forms.MouseEventHandler(this.borderConfirmPassword_MouseDown);
            // 
            // lbConfirmPassword
            // 
            this.lbConfirmPassword.AutoSize = true;
            this.lbConfirmPassword.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbConfirmPassword.Location = new System.Drawing.Point(36, 216);
            this.lbConfirmPassword.Name = "lbConfirmPassword";
            this.lbConfirmPassword.Size = new System.Drawing.Size(150, 19);
            this.lbConfirmPassword.TabIndex = 16;
            this.lbConfirmPassword.Text = "Confirm password :";
            // 
            // borderNewPassword
            // 
            this.borderNewPassword.Cursor = System.Windows.Forms.Cursors.Default;
            this.borderNewPassword.Font = new System.Drawing.Font("SF Pro Display", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borderNewPassword.Location = new System.Drawing.Point(40, 168);
            this.borderNewPassword.Name = "borderNewPassword";
            this.borderNewPassword.Size = new System.Drawing.Size(318, 40);
            this.borderNewPassword.TabIndex = 15;
            this.borderNewPassword.TabStop = false;
            this.borderNewPassword.Click += new System.EventHandler(this.borderNewPassword_Click);
            this.borderNewPassword.MouseDown += new System.Windows.Forms.MouseEventHandler(this.borderNewPassword_MouseDown);
            // 
            // lbNewPassword
            // 
            this.lbNewPassword.AutoSize = true;
            this.lbNewPassword.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNewPassword.Location = new System.Drawing.Point(36, 141);
            this.lbNewPassword.Name = "lbNewPassword";
            this.lbNewPassword.Size = new System.Drawing.Size(124, 19);
            this.lbNewPassword.TabIndex = 13;
            this.lbNewPassword.Text = "New password :";
            // 
            // lbResetDesc
            // 
            this.lbResetDesc.AutoSize = true;
            this.lbResetDesc.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResetDesc.Location = new System.Drawing.Point(36, 71);
            this.lbResetDesc.Name = "lbResetDesc";
            this.lbResetDesc.Size = new System.Drawing.Size(282, 38);
            this.lbResetDesc.TabIndex = 1;
            this.lbResetDesc.Text = "Enter a new password and re-enter to\r\nconfirm the password";
            // 
            // ForgotPassUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 434);
            this.Controls.Add(this.panelContinue);
            this.Controls.Add(this.panelReset);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ForgotPassUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Forgot password";
            this.Load += new System.EventHandler(this.ForgotPassUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picClearUserNIC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClearUserID)).EndInit();
            this.groupContinue.ResumeLayout(false);
            this.groupContinue.PerformLayout();
            this.panelContinue.ResumeLayout(false);
            this.panelReset.ResumeLayout(false);
            this.groupReset.ResumeLayout(false);
            this.groupReset.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picEyeConfirmPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEyeNewPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClearConfirmPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClearNewPassword)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lbContinueDesc;
        private System.Windows.Forms.PictureBox picClearUserNIC;
        private System.Windows.Forms.PictureBox picClearUserID;
        private System.Windows.Forms.TextBox txtUserNIC;
        private System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.Button btContinueCancel;
        private System.Windows.Forms.Button btContinue;
        private System.Windows.Forms.TextBox borderUserNIC;
        private System.Windows.Forms.Label lbUserNIC;
        private System.Windows.Forms.TextBox borderUserID;
        private System.Windows.Forms.Label lbUserID;
        private System.Windows.Forms.GroupBox groupContinue;
        private System.Windows.Forms.Panel panelContinue;
        private System.Windows.Forms.Panel panelReset;
        private System.Windows.Forms.GroupBox groupReset;
        private System.Windows.Forms.PictureBox picClearConfirmPassword;
        private System.Windows.Forms.PictureBox picClearNewPassword;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.Button btResetCancel;
        private System.Windows.Forms.Button btReset;
        private System.Windows.Forms.TextBox borderConfirmPassword;
        private System.Windows.Forms.Label lbConfirmPassword;
        private System.Windows.Forms.TextBox borderNewPassword;
        private System.Windows.Forms.Label lbNewPassword;
        private System.Windows.Forms.Label lbResetDesc;
        private System.Windows.Forms.PictureBox picEyeConfirmPassword;
        private System.Windows.Forms.PictureBox picEyeNewPassword;
        private System.Windows.Forms.Label error;
    }
}