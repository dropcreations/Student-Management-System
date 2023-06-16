
namespace StudentManagementSystem
{
    partial class PassGenUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PassGenUI));
            this.borderPassword = new System.Windows.Forms.TextBox();
            this.groupLength = new System.Windows.Forms.GroupBox();
            this.lengthSlider = new System.Windows.Forms.TrackBar();
            this.sliderValue = new System.Windows.Forms.Label();
            this.groupCharType = new System.Windows.Forms.GroupBox();
            this.chSymbols = new System.Windows.Forms.CheckBox();
            this.chLowercase = new System.Windows.Forms.CheckBox();
            this.chNumbers = new System.Windows.Forms.CheckBox();
            this.chUppercase = new System.Windows.Forms.CheckBox();
            this.btSuggest = new System.Windows.Forms.Button();
            this.groupPassword = new System.Windows.Forms.GroupBox();
            this.picCopy = new System.Windows.Forms.PictureBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.picVector = new System.Windows.Forms.PictureBox();
            this.groupLength.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lengthSlider)).BeginInit();
            this.groupCharType.SuspendLayout();
            this.groupPassword.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCopy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picVector)).BeginInit();
            this.SuspendLayout();
            // 
            // borderPassword
            // 
            this.borderPassword.Cursor = System.Windows.Forms.Cursors.Default;
            this.borderPassword.Font = new System.Drawing.Font("SF Pro Display", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borderPassword.Location = new System.Drawing.Point(17, 55);
            this.borderPassword.Name = "borderPassword";
            this.borderPassword.Size = new System.Drawing.Size(269, 36);
            this.borderPassword.TabIndex = 1;
            this.borderPassword.TabStop = false;
            this.borderPassword.Click += new System.EventHandler(this.borderPassword_Click);
            this.borderPassword.MouseDown += new System.Windows.Forms.MouseEventHandler(this.borderPassword_MouseDown);
            // 
            // groupLength
            // 
            this.groupLength.Controls.Add(this.lengthSlider);
            this.groupLength.Controls.Add(this.sliderValue);
            this.groupLength.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupLength.Location = new System.Drawing.Point(17, 107);
            this.groupLength.Name = "groupLength";
            this.groupLength.Size = new System.Drawing.Size(269, 85);
            this.groupLength.TabIndex = 2;
            this.groupLength.TabStop = false;
            this.groupLength.Text = "Length";
            // 
            // lengthSlider
            // 
            this.lengthSlider.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lengthSlider.LargeChange = 1;
            this.lengthSlider.Location = new System.Drawing.Point(57, 33);
            this.lengthSlider.Maximum = 12;
            this.lengthSlider.Minimum = 4;
            this.lengthSlider.Name = "lengthSlider";
            this.lengthSlider.Size = new System.Drawing.Size(187, 45);
            this.lengthSlider.TabIndex = 1;
            this.lengthSlider.Value = 4;
            this.lengthSlider.Scroll += new System.EventHandler(this.lengthSlider_Scroll);
            // 
            // sliderValue
            // 
            this.sliderValue.AutoSize = true;
            this.sliderValue.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sliderValue.Location = new System.Drawing.Point(25, 35);
            this.sliderValue.Name = "sliderValue";
            this.sliderValue.Size = new System.Drawing.Size(19, 19);
            this.sliderValue.TabIndex = 0;
            this.sliderValue.Text = "4";
            // 
            // groupCharType
            // 
            this.groupCharType.Controls.Add(this.chSymbols);
            this.groupCharType.Controls.Add(this.chLowercase);
            this.groupCharType.Controls.Add(this.chNumbers);
            this.groupCharType.Controls.Add(this.chUppercase);
            this.groupCharType.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupCharType.Location = new System.Drawing.Point(17, 198);
            this.groupCharType.Name = "groupCharType";
            this.groupCharType.Size = new System.Drawing.Size(269, 105);
            this.groupCharType.TabIndex = 3;
            this.groupCharType.TabStop = false;
            this.groupCharType.Text = "Character type";
            // 
            // chSymbols
            // 
            this.chSymbols.AutoSize = true;
            this.chSymbols.Checked = true;
            this.chSymbols.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chSymbols.Font = new System.Drawing.Font("SF Pro Display", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chSymbols.Location = new System.Drawing.Point(142, 64);
            this.chSymbols.Name = "chSymbols";
            this.chSymbols.Size = new System.Drawing.Size(81, 22);
            this.chSymbols.TabIndex = 3;
            this.chSymbols.Text = "Symbols";
            this.chSymbols.UseVisualStyleBackColor = true;
            // 
            // chLowercase
            // 
            this.chLowercase.AutoSize = true;
            this.chLowercase.Checked = true;
            this.chLowercase.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chLowercase.Font = new System.Drawing.Font("SF Pro Display", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chLowercase.Location = new System.Drawing.Point(142, 35);
            this.chLowercase.Name = "chLowercase";
            this.chLowercase.Size = new System.Drawing.Size(98, 22);
            this.chLowercase.TabIndex = 2;
            this.chLowercase.Text = "Lowercase";
            this.chLowercase.UseVisualStyleBackColor = true;
            // 
            // chNumbers
            // 
            this.chNumbers.AutoSize = true;
            this.chNumbers.Checked = true;
            this.chNumbers.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chNumbers.Font = new System.Drawing.Font("SF Pro Display", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chNumbers.Location = new System.Drawing.Point(28, 64);
            this.chNumbers.Name = "chNumbers";
            this.chNumbers.Size = new System.Drawing.Size(85, 22);
            this.chNumbers.TabIndex = 1;
            this.chNumbers.Text = "Numbers";
            this.chNumbers.UseVisualStyleBackColor = true;
            // 
            // chUppercase
            // 
            this.chUppercase.AutoSize = true;
            this.chUppercase.Checked = true;
            this.chUppercase.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chUppercase.Font = new System.Drawing.Font("SF Pro Display", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chUppercase.Location = new System.Drawing.Point(28, 35);
            this.chUppercase.Name = "chUppercase";
            this.chUppercase.Size = new System.Drawing.Size(97, 22);
            this.chUppercase.TabIndex = 0;
            this.chUppercase.Text = "Uppercase";
            this.chUppercase.UseVisualStyleBackColor = true;
            // 
            // btSuggest
            // 
            this.btSuggest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(69)))), ((int)(((byte)(254)))));
            this.btSuggest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSuggest.FlatAppearance.BorderSize = 0;
            this.btSuggest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSuggest.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSuggest.ForeColor = System.Drawing.SystemColors.Window;
            this.btSuggest.Location = new System.Drawing.Point(17, 324);
            this.btSuggest.Name = "btSuggest";
            this.btSuggest.Size = new System.Drawing.Size(269, 43);
            this.btSuggest.TabIndex = 4;
            this.btSuggest.Text = "Suggest";
            this.btSuggest.UseVisualStyleBackColor = false;
            this.btSuggest.Click += new System.EventHandler(this.btSuggest_Click);
            // 
            // groupPassword
            // 
            this.groupPassword.Controls.Add(this.picCopy);
            this.groupPassword.Controls.Add(this.txtPassword);
            this.groupPassword.Controls.Add(this.btSuggest);
            this.groupPassword.Controls.Add(this.groupCharType);
            this.groupPassword.Controls.Add(this.groupLength);
            this.groupPassword.Controls.Add(this.borderPassword);
            this.groupPassword.Font = new System.Drawing.Font("SF Pro Display", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupPassword.Location = new System.Drawing.Point(21, 20);
            this.groupPassword.Name = "groupPassword";
            this.groupPassword.Size = new System.Drawing.Size(302, 386);
            this.groupPassword.TabIndex = 6;
            this.groupPassword.TabStop = false;
            this.groupPassword.Text = "Suggest a password";
            // 
            // picCopy
            // 
            this.picCopy.BackColor = System.Drawing.SystemColors.Window;
            this.picCopy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picCopy.Image = global::StudentManagementSystem.Properties.Resources.copy;
            this.picCopy.Location = new System.Drawing.Point(250, 58);
            this.picCopy.Name = "picCopy";
            this.picCopy.Size = new System.Drawing.Size(27, 30);
            this.picCopy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCopy.TabIndex = 5;
            this.picCopy.TabStop = false;
            this.picCopy.Visible = false;
            this.picCopy.Click += new System.EventHandler(this.picCopy_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtPassword.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(34, 64);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(212, 20);
            this.txtPassword.TabIndex = 10;
            this.txtPassword.TabStop = false;
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPassword.Click += new System.EventHandler(this.txtPassword_Click);
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            this.txtPassword.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtPassword_MouseDown);
            // 
            // picVector
            // 
            this.picVector.Image = global::StudentManagementSystem.Properties.Resources.passGenPic;
            this.picVector.Location = new System.Drawing.Point(320, 32);
            this.picVector.Name = "picVector";
            this.picVector.Size = new System.Drawing.Size(296, 363);
            this.picVector.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picVector.TabIndex = 5;
            this.picVector.TabStop = false;
            // 
            // PassGenUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 426);
            this.Controls.Add(this.groupPassword);
            this.Controls.Add(this.picVector);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PassGenUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Suggest password";
            this.Load += new System.EventHandler(this.PassGenUI_Load);
            this.groupLength.ResumeLayout(false);
            this.groupLength.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lengthSlider)).EndInit();
            this.groupCharType.ResumeLayout(false);
            this.groupCharType.PerformLayout();
            this.groupPassword.ResumeLayout(false);
            this.groupPassword.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCopy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picVector)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox borderPassword;
        private System.Windows.Forms.GroupBox groupLength;
        private System.Windows.Forms.GroupBox groupCharType;
        private System.Windows.Forms.Button btSuggest;
        private System.Windows.Forms.TrackBar lengthSlider;
        private System.Windows.Forms.Label sliderValue;
        private System.Windows.Forms.CheckBox chSymbols;
        private System.Windows.Forms.CheckBox chLowercase;
        private System.Windows.Forms.CheckBox chNumbers;
        private System.Windows.Forms.CheckBox chUppercase;
        private System.Windows.Forms.PictureBox picVector;
        private System.Windows.Forms.GroupBox groupPassword;
        private System.Windows.Forms.PictureBox picCopy;
        private System.Windows.Forms.TextBox txtPassword;
    }
}