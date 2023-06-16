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
    public partial class LoginUI : Form
    {
        SqlConnection sqlCon = new SqlConnection();

        public LoginUI()
        {
            sqlCon.ConnectionString = @"Data Source=DESKTOP-6OCMHBR\SQLEXPRESS;Initial Catalog=Student;Integrated Security=True";
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
            groupLogin.Font = new Font(fontCollection.Families[0], 20, FontStyle.Bold);
            lbUsername.Font = new Font(fontCollection.Families[0], 12, FontStyle.Bold);
            lbPassword.Font = new Font(fontCollection.Families[0], 12, FontStyle.Bold);
            linkForgotPassword.Font = new Font(fontCollection.Families[0], 12, FontStyle.Bold);
            lbNotamember.Font = new Font(fontCollection.Families[0], 12, FontStyle.Bold);
            linkSignup.Font = new Font(fontCollection.Families[0], 12, FontStyle.Bold);
            txtUsername.Font = new Font(fontCollection.Families[0], 12, FontStyle.Bold);
            txtPassword.Font = new Font(fontCollection.Families[0], 12, FontStyle.Bold);
            btLogin.Font = new Font(fontCollection.Families[0], 12, FontStyle.Bold);
            btExit.Font = new Font(fontCollection.Families[0], 12, FontStyle.Bold);
            groupSignup.Font = new Font(fontCollection.Families[0], 20, FontStyle.Bold);
            lbUsernameSignup.Font = new Font(fontCollection.Families[0], 12, FontStyle.Bold);
            lbPasswordSignup.Font = new Font(fontCollection.Families[0], 12, FontStyle.Bold);
            lbRepassword.Font = new Font(fontCollection.Families[0], 12, FontStyle.Bold);
            linkSuggest.Font = new Font(fontCollection.Families[0], 12, FontStyle.Bold);
            linkLogin.Font = new Font(fontCollection.Families[0], 12, FontStyle.Bold);
            lbAlreadyamember.Font = new Font(fontCollection.Families[0], 12, FontStyle.Bold);
            txtUsernameSignup.Font = new Font(fontCollection.Families[0], 12, FontStyle.Bold);
            txtPasswordSignup.Font = new Font(fontCollection.Families[0], 12, FontStyle.Bold);
            txtRePasswordSignup.Font = new Font(fontCollection.Families[0], 12, FontStyle.Bold);
            btSignup.Font = new Font(fontCollection.Families[0], 12, FontStyle.Bold);
            btExitSignup.Font = new Font(fontCollection.Families[0], 12, FontStyle.Bold);
            groupCompleteSignup.Font = new Font(fontCollection.Families[0], 20, FontStyle.Bold);
            lbUserID.Font = new Font(fontCollection.Families[0], 20, FontStyle.Bold);
            lbDesc.Font = new Font(fontCollection.Families[0], 12, FontStyle.Bold);
            lbNIC.Font = new Font(fontCollection.Families[0], 12, FontStyle.Bold);
            lbCompleteAlreadyamember.Font = new Font(fontCollection.Families[0], 12, FontStyle.Bold);
            linkCompleteLogin.Font = new Font(fontCollection.Families[0], 12, FontStyle.Bold);
            txtUserNIC.Font = new Font(fontCollection.Families[0], 12, FontStyle.Bold);
            btCompleteSignup.Font = new Font(fontCollection.Families[0], 12, FontStyle.Bold);
            btCancel.Font = new Font(fontCollection.Families[0], 12, FontStyle.Bold);
        }

        [DllImport("user32.dll")] // Import user32.dll for hide caret in textboxes
        private static extern bool HideCaret(IntPtr hWnd);

        private void LoginUI_Shown(object sender, EventArgs e)
        {
            txtUsername.Focus();
        }

        private void LoginUI_Load(object sender, EventArgs e)
        {
            embedFont();
        }

        private void linkSignup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panelLogin.Visible = false;
            panelSignup.Visible = true;
            panelCompleteSignup.Visible = false;
            this.Text = "Sign Up";
            txtUsername.Clear();
            txtPassword.Clear();
            txtUsernameSignup.Focus();
        }

        private void linkLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panelSignup.Visible = false;
            panelLogin.Visible = true;
            panelCompleteSignup.Visible = false;
            this.Text = "Login";
            txtUsernameSignup.Clear();
            txtPasswordSignup.Clear();
            txtRePasswordSignup.Clear();
            txtUserNIC.Clear();
            txtUsername.Focus();
        }

        private void linkCompleteLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panelSignup.Visible = false;
            panelLogin.Visible = true;
            panelCompleteSignup.Visible = false;
            this.Text = "Login";
            txtUsernameSignup.Clear();
            txtPasswordSignup.Clear();
            txtRePasswordSignup.Clear();
            txtUserNIC.Clear();
            txtUsername.Focus();
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            DialogResult exitPrompt = MessageBox.Show("Are you sure, Do you really want to Exit...?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (exitPrompt == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                this.Show();
            }
        }

        private void btExitSignup_Click(object sender, EventArgs e)
        {
            DialogResult exitPrompt = MessageBox.Show("Are you sure, Do you really want to Exit...?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (exitPrompt == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                this.Show();
            }
        }

        private void borderUsername_MouseDown(object sender, MouseEventArgs e)
        {
            HideCaret(borderUsername.Handle);
        }

        private void borderPassword_MouseDown(object sender, MouseEventArgs e)
        {
            HideCaret(borderPassword.Handle);
        }

        private void borderUsernameSignup_MouseDown(object sender, MouseEventArgs e)
        {
            HideCaret(borderUsernameSignup.Handle);
        }

        private void borderPasswordSignup_MouseDown(object sender, MouseEventArgs e)
        {
            HideCaret(borderPasswordSignup.Handle);
        }

        private void borderRePasswordSignup_MouseDown(object sender, MouseEventArgs e)
        {
            HideCaret(borderRePasswordSignup.Handle);
        }

        private void borderNIC_MouseDown(object sender, MouseEventArgs e)
        {
            HideCaret(borderNIC.Handle);
        }

        private void borderUsername_Click(object sender, EventArgs e)
        {
            txtUsername.Focus();
        }

        private void borderPassword_Click(object sender, EventArgs e)
        {
            txtPassword.Focus();
        }

        private void borderUsernameSignup_Click(object sender, EventArgs e)
        {
            txtUsernameSignup.Focus();
        }

        private void borderPasswordSignup_Click(object sender, EventArgs e)
        {
            txtPasswordSignup.Focus();
        }

        private void borderRePasswordSignup_Click(object sender, EventArgs e)
        {
            txtRePasswordSignup.Focus();
        }

        private void borderNIC_Click(object sender, EventArgs e)
        {
            txtUserNIC.Focus();
        }

        int passwordHide = 1;

        private void picEyePassword_Click(object sender, EventArgs e)
        {
            if (passwordHide == 1)
            {
                txtPassword.UseSystemPasswordChar = false;
                passwordHide = 0;
                picEyePassword.Image = null;
                this.picEyePassword.BackgroundImage = StudentManagementSystem.Properties.Resources.eyeOpen;
                picEyePassword.BackgroundImageLayout = ImageLayout.Zoom;
            }
            else if (passwordHide == 0)
            {
                txtPassword.UseSystemPasswordChar = true;
                passwordHide = 1;
                picEyePassword.Image = null;
                this.picEyePassword.BackgroundImage = StudentManagementSystem.Properties.Resources.eyeClose;
                picEyePassword.BackgroundImageLayout = ImageLayout.Zoom;
            }
        }

        int passwordHideSignup = 1;

        private void picEyePasswordSignup_Click(object sender, EventArgs e)
        {
            if (passwordHideSignup == 1)
            {
                txtPasswordSignup.UseSystemPasswordChar = false;
                passwordHideSignup = 0;
                picEyePasswordSignup.Image = null;
                this.picEyePasswordSignup.BackgroundImage = StudentManagementSystem.Properties.Resources.eyeOpen;
                picEyePasswordSignup.BackgroundImageLayout = ImageLayout.Zoom;
            }
            else if (passwordHideSignup == 0)
            {
                txtPasswordSignup.UseSystemPasswordChar = true;
                passwordHideSignup = 1;
                picEyePasswordSignup.Image = null;
                this.picEyePasswordSignup.BackgroundImage = StudentManagementSystem.Properties.Resources.eyeClose;
                picEyePasswordSignup.BackgroundImageLayout = ImageLayout.Zoom;
            }
        }

        int repasswordHideSignup = 1;

        private void picEyeRePasswordSignup_Click(object sender, EventArgs e)
        {
            if (repasswordHideSignup == 1)
            {
                txtRePasswordSignup.UseSystemPasswordChar = false;
                repasswordHideSignup = 0;
                picEyeRePasswordSignup.Image = null;
                this.picEyeRePasswordSignup.BackgroundImage = StudentManagementSystem.Properties.Resources.eyeOpen;
                picEyeRePasswordSignup.BackgroundImageLayout = ImageLayout.Zoom;
            }
            else if (repasswordHideSignup == 0)
            {
                txtRePasswordSignup.UseSystemPasswordChar = true;
                repasswordHideSignup = 1;
                picEyeRePasswordSignup.Image = null;
                this.picEyeRePasswordSignup.BackgroundImage = StudentManagementSystem.Properties.Resources.eyeClose;
                picEyeRePasswordSignup.BackgroundImageLayout = ImageLayout.Zoom;
            }
        }

        private void picClearUsername_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtUsername.Focus();
        }

        private void picClearPassword_Click(object sender, EventArgs e)
        {
            txtPassword.Clear();
            txtPassword.Focus();
        }

        private void picClearUsernameSignup_Click(object sender, EventArgs e)
        {
            txtUsernameSignup.Clear();
            txtUsernameSignup.Focus();
        }

        private void picClearPasswordSignup_Click(object sender, EventArgs e)
        {
            txtPasswordSignup.Clear();
            txtPasswordSignup.Focus();
        }

        private void picClearRePasswordSignup_Click(object sender, EventArgs e)
        {
            txtRePasswordSignup.Clear();
            txtRePasswordSignup.Focus();
        }

        private void picClearNIC_Click(object sender, EventArgs e)
        {
            txtUserNIC.Clear();
            txtUserNIC.Focus();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            if (txtUsername.Text != "")
            {
                picClearUsername.Visible = true;
            }
            else if (txtUsername.Text == "")
            {
                picClearUsername.Visible = false;
            }
        }

        private void txtUsernameSignup_TextChanged(object sender, EventArgs e)
        {
            if (txtUsernameSignup.Text != "")
            {
                picClearUsernameSignup.Visible = true;
            }
            else if (txtUsernameSignup.Text == "")
            {
                picClearUsernameSignup.Visible = false;
            }
        }

        private void txtUserNIC_TextChanged(object sender, EventArgs e)
        {
            if (txtUserNIC.Text != "")
            {
                picClearNIC.Visible = true;
            }
            else if (txtUserNIC.Text == "")
            {
                picClearNIC.Visible = false;
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtPassword.Text != "")
            {
                picEyePassword.Visible = true;
                picClearPassword.Visible = true;
            }
            else if (txtPassword.Text == "")
            {
                picEyePassword.Visible = false;
                picClearPassword.Visible = false;
                txtPassword.UseSystemPasswordChar = true;
                passwordHide = 1;
                picEyePassword.Image = null;
                this.picEyePassword.BackgroundImage = StudentManagementSystem.Properties.Resources.eyeClose;
                picEyePassword.BackgroundImageLayout = ImageLayout.Zoom;
            }
        }

        private void txtPasswordSignup_TextChanged(object sender, EventArgs e)
        {
            if (txtPasswordSignup.Text != "")
            {
                picEyePasswordSignup.Visible = true;
                picClearPasswordSignup.Visible = true;
                // Checking re-entered password is matching
                if (txtPasswordSignup.Text != txtRePasswordSignup.Text)
                {
                    error.Visible = true;
                }
                else if (txtPasswordSignup.Text == txtRePasswordSignup.Text)
                {
                    error.Visible = false;
                }
                // Check password error with empty re-entered password
                if (txtRePasswordSignup.Text == "")
                {
                    error.Visible = false;
                }
            }
            else if (txtPasswordSignup.Text == "")
            {
                picEyePasswordSignup.Visible = false;
                picClearPasswordSignup.Visible = false;
                txtPasswordSignup.UseSystemPasswordChar = true;
                passwordHideSignup = 1;
                picEyePasswordSignup.Image = null;
                this.picEyePasswordSignup.BackgroundImage = StudentManagementSystem.Properties.Resources.eyeClose;
                picEyePasswordSignup.BackgroundImageLayout = ImageLayout.Zoom;
                if (txtRePasswordSignup.Text != "")
                {
                    error.Visible = true;
                }
            }
        }

        private void txtRePasswordSignup_TextChanged(object sender, EventArgs e)
        {
            if (txtRePasswordSignup.Text != "")
            {
                picEyeRePasswordSignup.Visible = true;
                picClearRePasswordSignup.Visible = true;
                if (txtPasswordSignup.Text != txtRePasswordSignup.Text)
                {
                    error.Visible = true;
                }
                else if (txtPasswordSignup.Text == txtRePasswordSignup.Text)
                {
                    error.Visible = false;
                }
            }
            else if (txtRePasswordSignup.Text == "")
            {
                error.Visible = false;
                picEyeRePasswordSignup.Visible = false;
                picClearRePasswordSignup.Visible = false;
                txtRePasswordSignup.UseSystemPasswordChar = true;
                repasswordHideSignup = 1;
                picEyeRePasswordSignup.Image = null;
                this.picEyeRePasswordSignup.BackgroundImage = StudentManagementSystem.Properties.Resources.eyeClose;
                picEyeRePasswordSignup.BackgroundImageLayout = ImageLayout.Zoom;
            }
        }

        private void linkSuggest_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PassGenUI passForm = new PassGenUI();
            passForm.Show();
        }

        private void linkForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ForgotPassUI forgotForm = new ForgotPassUI();
            forgotForm.Show();
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "Admin" && txtPassword.Text == "Skills@123")
            {
                RegistrationUI regForm = new RegistrationUI();
                regForm.Show();
                this.Hide();
            }
            else
            {
                sqlCon.Open();

                string selectQuery = "SELECT * FROM Logins WHERE username='" + txtUsername.Text + "' AND password='" + txtPassword.Text + "'";
                SqlCommand cmdQuery = new SqlCommand(selectQuery, sqlCon);
                SqlDataReader sqlData = cmdQuery.ExecuteReader();

                if (sqlData.HasRows)
                {
                    RegistrationUI regForm = new RegistrationUI();
                    regForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid login credentials, please check 'Username' and 'Password' then try again", "Invalid login details", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                sqlCon.Close();
            }
        }

        string userID;
        string userNIC;

        private void btSignup_Click(object sender, EventArgs e)
        {
            sqlCon.Open();
            SqlCommand cmdQuery = new SqlCommand("SELECT COUNT(userID) FROM Logins", sqlCon);
            int recordCount = Convert.ToInt32(cmdQuery.ExecuteScalar());
            userID = "U" + (1000 + recordCount);
            sqlCon.Close();
            

            if (txtUsernameSignup.Text != "" && txtPasswordSignup.Text != "" && txtRePasswordSignup.Text != "" && txtPasswordSignup.Text == txtRePasswordSignup.Text)
            {
                panelSignup.Visible = false;
                panelCompleteSignup.Visible = true;
                lbUserID.Text = userID;
            }
            else
            {
                MessageBox.Show("Please fill all fields correctly", "Fill details", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btCompleteSignup_Click(object sender, EventArgs e)
        {
            if (txtUserNIC.Text != "")
            {
                try
                {
                    userNIC = txtUserNIC.Text;
                    sqlCon.Open();
                    string addLoginQuery = "INSERT INTO Logins (userID, username, password, userNIC) VALUES ('" + userID + "', '" + txtUsernameSignup.Text + "', '" + txtPasswordSignup.Text + "', '" + userNIC + "')";
                    SqlDataAdapter sqlData = new SqlDataAdapter(addLoginQuery, sqlCon);
                    sqlData.SelectCommand.ExecuteNonQuery();
                    MessageBox.Show("Successfully registered a new user!\nYour user ID: " + userID, "Successfully registered", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    sqlCon.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex);
                }
                finally
                {
                    panelSignup.Visible = false;
                    panelLogin.Visible = true;
                    panelCompleteSignup.Visible = false;
                    this.Text = "Login";
                    txtUsernameSignup.Clear();
                    txtPasswordSignup.Clear();
                    txtRePasswordSignup.Clear();
                    txtUserNIC.Clear();
                    txtUsername.Focus();
                }

            }
            else if (txtUserNIC.Text == "")
            {
                MessageBox.Show("Please enter your National ID card number", "Enter NIC", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            panelLogin.Visible = false;
            panelSignup.Visible = true;
            panelCompleteSignup.Visible = false;
            this.Text = "Sign Up";
            txtUserNIC.Clear();
            txtUsernameSignup.Clear();
            txtPasswordSignup.Clear();
            txtRePasswordSignup.Clear();
            txtUsernameSignup.Focus();
        }
    }
}
