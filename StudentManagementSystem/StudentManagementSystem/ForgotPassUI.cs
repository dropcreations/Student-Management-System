using System;
using System.Drawing;
using System.IO; // Stream
using System.Drawing.Text; // PrivateFontCollection
using System.Reflection; // Assembly
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.InteropServices; // DllImport

namespace StudentManagementSystem
{
    public partial class ForgotPassUI : Form
    {
        SqlConnection sqlCon = new SqlConnection();

        public ForgotPassUI()
        {
            sqlCon.ConnectionString = @"Data Source=DESKTOP-CHJ79U0\SQLEXPRESS;Initial Catalog=Student;Integrated Security=True";
            InitializeComponent();
            LoadFont();
        }

        [DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont, IntPtr pdv, [In] ref uint pcFonts);
        PrivateFontCollection fontCollection = new PrivateFontCollection();

        private void LoadFont()
        {
            string[] resource = { "StudentManagementSystem.Fonts.SFPRODISPLAYBOLD.OTF", "StudentManagementSystem.Fonts.SFPRODISPLAYREGULAR.OTF" }; // specify embedded resource names
            foreach (string fontItem in resource)
            {
                Stream fontStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(fontItem); // receive resource stream
                IntPtr data = Marshal.AllocCoTaskMem((int)fontStream.Length); // create an unsafe memory block for the data
                Byte[] fontData = new Byte[fontStream.Length]; // create a buffer to read in to
                fontStream.Read(fontData, 0, (int)fontStream.Length); // fetch the font program from the resource
                Marshal.Copy(fontData, 0, data, (int)fontStream.Length); // copy the bytes to the unsafe memory block       
                uint cFonts = 0;
                AddFontMemResourceEx(data, (uint)fontData.Length, IntPtr.Zero, ref cFonts);
                fontCollection.AddMemoryFont(data, (int)fontStream.Length); // pass the font to the font collection
                fontStream.Close(); // close the resource stream
                Marshal.FreeCoTaskMem(data); // free the unsafe memory
            }
        }

        private void embedFont()
        {
            groupContinue.Font = new Font(fontCollection.Families[0], 18, FontStyle.Bold);
            lbContinueDesc.Font = new Font(fontCollection.Families[0], 12, FontStyle.Bold);
            lbUserID.Font = new Font(fontCollection.Families[0], 12, FontStyle.Bold);
            lbUserNIC.Font = new Font(fontCollection.Families[0], 12, FontStyle.Bold);
            txtUserID.Font = new Font(fontCollection.Families[0], 12, FontStyle.Bold);
            txtUserNIC.Font = new Font(fontCollection.Families[0], 12, FontStyle.Bold);
            btContinue.Font = new Font(fontCollection.Families[0], 12, FontStyle.Bold);
            btContinueCancel.Font = new Font(fontCollection.Families[0], 12, FontStyle.Bold);
            groupReset.Font = new Font(fontCollection.Families[0], 18, FontStyle.Bold);
            lbResetDesc.Font = new Font(fontCollection.Families[0], 12, FontStyle.Bold);
            lbNewPassword.Font = new Font(fontCollection.Families[0], 12, FontStyle.Bold);
            lbConfirmPassword.Font = new Font(fontCollection.Families[0], 12, FontStyle.Bold);
            txtNewPassword.Font = new Font(fontCollection.Families[0], 12, FontStyle.Bold);
            txtConfirmPassword.Font = new Font(fontCollection.Families[0], 12, FontStyle.Bold);
            btReset.Font = new Font(fontCollection.Families[0], 12, FontStyle.Bold);
            btResetCancel.Font = new Font(fontCollection.Families[0], 12, FontStyle.Bold);
        }

        private void ForgotPassUI_Load(object sender, EventArgs e)
        {
            embedFont();
        }

        [DllImport("user32.dll")] // Import user32.dll file for hide caret in textboxes
        private static extern bool HideCaret(IntPtr hWnd);

        private void btContinueCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btResetCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void borderUserID_MouseDown(object sender, MouseEventArgs e)
        {
            HideCaret(borderUserID.Handle);
        }

        private void borderUserNIC_MouseDown(object sender, MouseEventArgs e)
        {
            HideCaret(borderUserNIC.Handle);
        }

        private void borderNewPassword_MouseDown(object sender, MouseEventArgs e)
        {
            HideCaret(borderNewPassword.Handle);
        }

        private void borderConfirmPassword_MouseDown(object sender, MouseEventArgs e)
        {
            HideCaret(borderConfirmPassword.Handle);
        }

        private void borderUserID_Click(object sender, EventArgs e)
        {
            txtUserID.Focus();
        }

        private void borderUserNIC_Click(object sender, EventArgs e)
        {
            txtUserNIC.Focus();
        }

        private void borderNewPassword_Click(object sender, EventArgs e)
        {
            txtNewPassword.Focus();
        }

        private void borderConfirmPassword_Click(object sender, EventArgs e)
        {
            txtConfirmPassword.Focus();
        }

        private void picClearUserID_Click(object sender, EventArgs e)
        {
            txtUserID.Clear();
            txtUserID.Focus();
        }

        private void picClearUserNIC_Click(object sender, EventArgs e)
        {
            txtUserNIC.Clear();
            txtUserNIC.Focus();
        }

        private void picClearNewPassword_Click(object sender, EventArgs e)
        {
            txtNewPassword.Clear();
            txtNewPassword.Focus();
        }

        private void picClearConfirmPassword_Click(object sender, EventArgs e)
        {
            txtConfirmPassword.Clear();
            txtConfirmPassword.Focus();
        }

        int newPassword = 1;

        private void picEyeNewPassword_Click(object sender, EventArgs e)
        {
            if (newPassword == 1)
            {
                txtNewPassword.UseSystemPasswordChar = false;
                newPassword = 0;
                picEyeNewPassword.Image = null;
                this.picEyeNewPassword.BackgroundImage = StudentManagementSystem.Properties.Resources.eyeOpen;
                picEyeNewPassword.BackgroundImageLayout = ImageLayout.Zoom;
            }
            else if (newPassword == 0)
            {
                txtNewPassword.UseSystemPasswordChar = true;
                newPassword = 1;
                picEyeNewPassword.Image = null;
                this.picEyeNewPassword.BackgroundImage = StudentManagementSystem.Properties.Resources.eyeClose;
                picEyeNewPassword.BackgroundImageLayout = ImageLayout.Zoom;
            }
        }

        int confirmPassword = 1;

        private void picEyeConfirmPassword_Click(object sender, EventArgs e)
        {
            if (confirmPassword == 1)
            {
                txtConfirmPassword.UseSystemPasswordChar = false;
                confirmPassword = 0;
                picEyeConfirmPassword.Image = null;
                this.picEyeConfirmPassword.BackgroundImage = StudentManagementSystem.Properties.Resources.eyeOpen;
                picEyeConfirmPassword.BackgroundImageLayout = ImageLayout.Zoom;
            }
            else if (confirmPassword == 0)
            {
                txtConfirmPassword.UseSystemPasswordChar = true;
                confirmPassword = 1;
                picEyeConfirmPassword.Image = null;
                this.picEyeConfirmPassword.BackgroundImage = StudentManagementSystem.Properties.Resources.eyeClose;
                picEyeConfirmPassword.BackgroundImageLayout = ImageLayout.Zoom;
            }
        }

        private void txtUserID_TextChanged(object sender, EventArgs e)
        {
            if (txtUserID.Text != "")
            {
                picClearUserID.Visible = true;
            }
            else if (txtUserID.Text == "")
            {
                picClearUserID.Visible = false;
            }
        }

        private void txtUserNIC_TextChanged(object sender, EventArgs e)
        {
            if (txtUserNIC.Text != "")
            {
                picClearUserNIC.Visible = true;
            }
            else if (txtUserNIC.Text == "")
            {
                picClearUserNIC.Visible = false;
            }
        }

        private void txtNewPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtNewPassword.Text != "")
            {
                picEyeNewPassword.Visible = true;
                picClearNewPassword.Visible = true;
                // Checking re-entered password is matching
                if (txtNewPassword.Text != txtConfirmPassword.Text)
                {
                    error.Visible = true;
                }
                else if (txtNewPassword.Text == txtConfirmPassword.Text)
                {
                    error.Visible = false;
                }
                // Check password error with empty re-entered password
                if (txtConfirmPassword.Text == "")
                {
                    error.Visible = false;
                }
            }
            else if (txtNewPassword.Text == "")
            {
                picEyeNewPassword.Visible = false;
                picClearNewPassword.Visible = false;
                txtNewPassword.UseSystemPasswordChar = true;
                newPassword = 1;
                picEyeNewPassword.Image = null;
                this.picEyeNewPassword.BackgroundImage = StudentManagementSystem.Properties.Resources.eyeClose;
                picEyeNewPassword.BackgroundImageLayout = ImageLayout.Zoom;
                if (txtConfirmPassword.Text != "")
                {
                    error.Visible = true;
                }
            }
        }

        private void txtConfirmPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtConfirmPassword.Text != "")
            {
                picEyeConfirmPassword.Visible = true;
                picClearConfirmPassword.Visible = true;
                if (txtNewPassword.Text != txtConfirmPassword.Text)
                {
                    error.Visible = true;
                }
                else if (txtNewPassword.Text == txtConfirmPassword.Text)
                {
                    error.Visible = false;
                }
            }
            else if (txtConfirmPassword.Text == "")
            {
                error.Visible = false;
                picEyeConfirmPassword.Visible = false;
                picClearConfirmPassword.Visible = false;
                txtConfirmPassword.UseSystemPasswordChar = true;
                confirmPassword = 1;
                picEyeConfirmPassword.Image = null;
                this.picEyeConfirmPassword.BackgroundImage = StudentManagementSystem.Properties.Resources.eyeClose;
                picEyeConfirmPassword.BackgroundImageLayout = ImageLayout.Zoom;
            }
        }

        private void btContinue_Click(object sender, EventArgs e)
        {
            if (txtUserID.Text != "" && txtUserNIC.Text != "")
            {
                sqlCon.Open();

                string selectQuery = "SELECT * FROM Logins WHERE userID='" + txtUserID.Text + "' AND userNIC='" + txtUserNIC.Text + "'";
                SqlCommand cmdQuery = new SqlCommand(selectQuery, sqlCon);
                SqlDataReader sqlData = cmdQuery.ExecuteReader();

                if (sqlData.HasRows)
                {
                    panelContinue.Visible = false;
                    panelReset.Visible = true;
                }
                else
                {
                    MessageBox.Show("Please make sure 'User ID' and 'NIC' is correct and try again", "Invalid details", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                sqlCon.Close();
            }
            else
            {
                MessageBox.Show("Please fill all the fields correctly", "Fill details", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btReset_Click(object sender, EventArgs e)
        {
            if (txtNewPassword.Text != "" && txtConfirmPassword.Text != "")
            {
                try
                {
                    sqlCon.Open();
                    string selectQuery = "SELECT password FROM Logins WHERE userID='" + txtUserID.Text + "'";
                    SqlCommand cmdQuery = new SqlCommand(selectQuery, sqlCon);
                    string oldPassword = cmdQuery.ExecuteScalar().ToString();

                    if (oldPassword == txtNewPassword.Text)
                    {
                        MessageBox.Show("New password cannot be same as old password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        string updateQuery = "UPDATE Logins SET password='" + txtNewPassword.Text + "' WHERE userID='" + txtUserID.Text + "'";
                        SqlCommand updateCmd = new SqlCommand(updateQuery, sqlCon);
                        updateCmd.ExecuteNonQuery();
                        MessageBox.Show("Your account password is successfully reset!", "Successfully reset", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                    }
                    sqlCon.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex);
                }
            }
            else
            {
                MessageBox.Show("Please fill all the fields correctly", "Fill details", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
