using System;
using System.Drawing;
using System.IO; // Stream
using System.Drawing.Text; // PrivateFontCollection
using System.Reflection; // Assembly
using System.Windows.Forms;
using System.Runtime.InteropServices; // DllImport

namespace StudentManagementSystem
{
    public partial class PassGenUI : Form
    {
        public PassGenUI()
        {
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

        private void PassGenUI_Load(object sender, EventArgs e)
        {
            groupPassword.Font = new Font(fontCollection.Families[0], 20, FontStyle.Bold);
            groupLength.Font = new Font(fontCollection.Families[0], 12, FontStyle.Bold);
            groupCharType.Font = new Font(fontCollection.Families[0], 12, FontStyle.Bold);
            txtPassword.Font = new Font(fontCollection.Families[0], 12, FontStyle.Bold);
            sliderValue.Font = new Font(fontCollection.Families[0], 12, FontStyle.Regular);
            chUppercase.Font = new Font(fontCollection.Families[0], 12, FontStyle.Regular);
            chLowercase.Font = new Font(fontCollection.Families[0], 12, FontStyle.Regular);
            chNumbers.Font = new Font(fontCollection.Families[0], 12, FontStyle.Regular);
            chSymbols.Font = new Font(fontCollection.Families[0], 12, FontStyle.Regular);
            btSuggest.Font = new Font(fontCollection.Families[0], 12, FontStyle.Bold);
        }

        [DllImport("user32.dll")]
        private static extern bool HideCaret(IntPtr hWnd);

        // Create a random character object

        Random randomChar = new Random();

        // Password generator

        private void PasswordGenerator(int PasswordLength)
        {
            string UppercaseChar = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string LowercaseChar = "abcdefghijklmnopqrstuvwxyz";
            string NumbersChar = "0123456789";
            string SymbolsChar = "!@#$%^&*";
            string CharLibrary = "";
            string randomPassword = "";

            if (chUppercase.Checked == true)
            {
                CharLibrary += UppercaseChar;
            }
            if (chLowercase.Checked == true)
            {
                CharLibrary += LowercaseChar;
            }
            if (chNumbers.Checked == true)
            {
                CharLibrary += NumbersChar;
            }
            if (chSymbols.Checked == true)
            {
                CharLibrary += SymbolsChar;
            }

            for (int i = 0; i < PasswordLength; i++)
            {
                int randomIndex = randomChar.Next(0, CharLibrary.Length);
                randomPassword += CharLibrary[randomIndex];
            }
            txtPassword.Text = randomPassword;
        }

        private void picCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtPassword.Text);
            MessageBox.Show("Password successfully copied to the clipboard!", "Password copied", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void borderPassword_MouseDown(object sender, MouseEventArgs e)
        {
            HideCaret(borderPassword.Handle);
        }

        private void txtPassword_MouseDown(object sender, MouseEventArgs e)
        {
            HideCaret(txtPassword.Handle);
        }

        private void borderPassword_Click(object sender, EventArgs e)
        {
            picCopy.Focus();
        }

        private void txtPassword_Click(object sender, EventArgs e)
        {
            picCopy.Focus();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtPassword.Text != "")
            {
                picCopy.Visible = true;
            }
        }

        private void btSuggest_Click(object sender, EventArgs e)
        {
            if (chUppercase.Checked == false && chLowercase.Checked == false && chNumbers.Checked == false && chSymbols.Checked == false)
            {
                MessageBox.Show("You haven't selceted any character type.\nPlease select at least one type.", "Character type", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                txtPassword.Clear();
                PasswordGenerator(lengthSlider.Value);
            }
        }

        private void lengthSlider_Scroll(object sender, EventArgs e)
        {
            if (chUppercase.Checked == false && chLowercase.Checked == false && chNumbers.Checked == false && chSymbols.Checked == false)
            {
                MessageBox.Show("You haven't selceted any character type.\nPlease select at least one type.", "Character type", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                sliderValue.Text = lengthSlider.Value.ToString();
                txtPassword.Clear();
                PasswordGenerator(lengthSlider.Value);
            }
        }
    }
}
