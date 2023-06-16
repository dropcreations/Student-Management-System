using System;
using System.IO; // Stream
using System.Drawing.Text; // PrivateFontCollection
using System.Reflection; // Assembly
using System.Runtime.InteropServices; // DllImport
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace StudentManagementSystem
{
    public partial class LoadingUI : Form
    {
        public LoadingUI()
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

        private void loadingTimer_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i <= 100; i++)
            {
                progressBar.Value = i;
                lbLoading.Text = "Loading...." + progressBar.Value.ToString() + "%";
                Refresh();
                Thread.Sleep(10);
                if (progressBar.Value == 100)
                {
                    loadingTimer.Enabled = false;
                    LoginUI loginForm = new LoginUI();
                    this.Hide();
                    loginForm.Show();
                }
            }
        }

        private void LoadingUI_Load(object sender, EventArgs e)
        {
            lbDesc.Font = new Font(fontCollection.Families[0], 12, FontStyle.Bold);
            lbLoading.Font = new Font(fontCollection.Families[0], 16, FontStyle.Bold);
        }
    }
}
