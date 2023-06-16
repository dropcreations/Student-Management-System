
namespace StudentManagementSystem
{
    partial class LoadingUI
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoadingUI));
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.loadingTimer = new System.Windows.Forms.Timer(this.components);
            this.lbDesc = new System.Windows.Forms.Label();
            this.lbLoading = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // picLogo
            // 
            this.picLogo.Image = global::StudentManagementSystem.Properties.Resources.logo;
            this.picLogo.Location = new System.Drawing.Point(73, -14);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(249, 244);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            // 
            // loadingTimer
            // 
            this.loadingTimer.Enabled = true;
            this.loadingTimer.Tick += new System.EventHandler(this.loadingTimer_Tick);
            // 
            // lbDesc
            // 
            this.lbDesc.AutoSize = true;
            this.lbDesc.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDesc.ForeColor = System.Drawing.SystemColors.Window;
            this.lbDesc.Location = new System.Drawing.Point(68, 192);
            this.lbDesc.Name = "lbDesc";
            this.lbDesc.Size = new System.Drawing.Size(258, 38);
            this.lbDesc.TabIndex = 1;
            this.lbDesc.Text = "The Student Management System\r\nfor Skills International";
            this.lbDesc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbLoading
            // 
            this.lbLoading.AutoSize = true;
            this.lbLoading.Font = new System.Drawing.Font("SF Pro Display", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLoading.ForeColor = System.Drawing.SystemColors.Window;
            this.lbLoading.Location = new System.Drawing.Point(114, 279);
            this.lbLoading.Name = "lbLoading";
            this.lbLoading.Size = new System.Drawing.Size(112, 25);
            this.lbLoading.TabIndex = 2;
            this.lbLoading.Text = "Loading....";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(124, 336);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(146, 10);
            this.progressBar.Step = 1;
            this.progressBar.TabIndex = 3;
            this.progressBar.Visible = false;
            // 
            // LoadingUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(69)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(395, 380);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.lbLoading);
            this.Controls.Add(this.lbDesc);
            this.Controls.Add(this.picLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoadingUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoadingUI";
            this.Load += new System.EventHandler(this.LoadingUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Timer loadingTimer;
        private System.Windows.Forms.Label lbDesc;
        private System.Windows.Forms.Label lbLoading;
        private System.Windows.Forms.ProgressBar progressBar;
    }
}