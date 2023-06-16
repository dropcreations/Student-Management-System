using System;
using System.IO; // Stream
using System.Data;
using System.Drawing;
using System.Drawing.Text; // PrivateFontCollection
using System.Linq;
using System.Reflection; // Assembly
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.InteropServices; // DllImport

namespace StudentManagementSystem
{
    public partial class RegistrationUI : Form
    {
        SqlConnection sqlCon = new SqlConnection();

        public RegistrationUI()
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
            lbDetails.Font = new Font(fontCollection.Families[0], 20, FontStyle.Bold);
            lbStdID.Font = new Font(fontCollection.Families[0], 12, FontStyle.Bold);
            groupBasic.Font = new Font(fontCollection.Families[0], 12, FontStyle.Bold);
            lbFullname.Font = new Font(fontCollection.Families[0], 12, FontStyle.Bold);
            lbDOB.Font = new Font(fontCollection.Families[0], 12, FontStyle.Bold);
            lbGender.Font = new Font(fontCollection.Families[0], 12, FontStyle.Bold);
            groupContact.Font = new Font(fontCollection.Families[0], 12, FontStyle.Bold);
            lbAddress.Font = new Font(fontCollection.Families[0], 12, FontStyle.Bold);
            lbEmail.Font = new Font(fontCollection.Families[0], 12, FontStyle.Bold);
            lbPhone.Font = new Font(fontCollection.Families[0], 12, FontStyle.Bold);
            groupParent.Font = new Font(fontCollection.Families[0], 12, FontStyle.Bold);
            lbParentName.Font = new Font(fontCollection.Families[0], 12, FontStyle.Bold);
            lbParentNIC.Font = new Font(fontCollection.Families[0], 12, FontStyle.Bold);
            lbParentContact.Font = new Font(fontCollection.Families[0], 12, FontStyle.Bold);
            lbTotal.Font = new Font(fontCollection.Families[0], 20, FontStyle.Bold);
            lbStdCount.Font = new Font(fontCollection.Families[0], 72, FontStyle.Bold);
            lbStudents.Font = new Font(fontCollection.Families[0], 20, FontStyle.Bold);
            btRegister.Font = new Font(fontCollection.Families[0], 12, FontStyle.Bold);
            btUpdate.Font = new Font(fontCollection.Families[0], 12, FontStyle.Bold);
            btDelete.Font = new Font(fontCollection.Families[0], 12, FontStyle.Bold);
            btClear.Font = new Font(fontCollection.Families[0], 12, FontStyle.Bold);
            btLogout.Font = new Font(fontCollection.Families[0], 12, FontStyle.Bold);
            btExit.Font = new Font(fontCollection.Families[0], 12, FontStyle.Bold);
            comboStdID.Font = new Font(fontCollection.Families[0], 12, FontStyle.Regular);
            txtFirstname.Font = new Font(fontCollection.Families[0], 12, FontStyle.Regular);
            txtLastname.Font = new Font(fontCollection.Families[0], 12, FontStyle.Regular);
            datePicker.Font = new Font(fontCollection.Families[0], 12, FontStyle.Regular);
            rbMale.Font = new Font(fontCollection.Families[0], 12, FontStyle.Regular);
            rbFemale.Font = new Font(fontCollection.Families[0], 12, FontStyle.Regular);
            txtAddressLine1.Font = new Font(fontCollection.Families[0], 12, FontStyle.Regular);
            txtAddressLine2.Font = new Font(fontCollection.Families[0], 12, FontStyle.Regular);
            comboDisctrict.Font = new Font(fontCollection.Families[0], 12, FontStyle.Regular);
            comboProvince.Font = new Font(fontCollection.Families[0], 12, FontStyle.Regular);
            txtEmail.Font = new Font(fontCollection.Families[0], 12, FontStyle.Regular);
            txtMobile.Font = new Font(fontCollection.Families[0], 12, FontStyle.Regular);
            txtHome.Font = new Font(fontCollection.Families[0], 12, FontStyle.Regular);
            txtParentName.Font = new Font(fontCollection.Families[0], 12, FontStyle.Regular);
            txtParentNIC.Font = new Font(fontCollection.Families[0], 12, FontStyle.Regular);
            txtParentContact.Font = new Font(fontCollection.Families[0], 12, FontStyle.Regular);
        }

        string gender;
        string studentID;

        private void loadData()
        {
            try
            {
                sqlCon.Open();
                SqlDataAdapter sqlData = new SqlDataAdapter("SELECT * FROM Registrations", sqlCon);
                DataSet dataSet = new DataSet();
                sqlData.Fill(dataSet, "Registration");
                dataGrid.DataSource = dataSet.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
            finally
            {
                sqlCon.Close();
            }
        }

        private void stdCountStatus()
        {
            sqlCon.Open();
            SqlCommand cmdQuery = new SqlCommand("SELECT COUNT(stdID) FROM Registrations", sqlCon);
            int recordCount = Convert.ToInt32(cmdQuery.ExecuteScalar());
            sqlCon.Close();
            lbStdCount.Text = recordCount.ToString();
            if (recordCount < 10)
            {
                lbStdCount.Location = new Point(50, 84);
            }
            else if (recordCount < 100)
            {
                lbStdCount.Location = new Point(28, 84);
            }
            
        }

        private void loadStdID()
        {
            try
            {
                comboStdID.Items.Clear();
                sqlCon.Open();
                SqlDataAdapter sqlData = new SqlDataAdapter("SELECT stdID FROM Registrations ORDER BY stdID", sqlCon);
                DataTable dataTable = new DataTable();
                sqlData.Fill(dataTable);
                comboStdID.Items.Add("New Student");
                foreach (DataRow row in dataTable.Rows)
                {
                    comboStdID.Items.Add(row["stdID"]);
                }
                comboStdID.SelectedIndex = 0;
                comboStdID.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
            finally
            {
                sqlCon.Close();
            }
        }

        private void RegistrationUI_Load(object sender, EventArgs e)
        {
            embedFont();
            loadData();
            stdCountStatus();
            loadStdID();
        }

        private void RegistrationUI_Shown(object sender, EventArgs e)
        {
            comboStdID.Focus();
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

        private void btLogout_Click(object sender, EventArgs e)
        {
            DialogResult logoutPrompt = MessageBox.Show("Do you really want to Log out...?", "Log out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (logoutPrompt == DialogResult.Yes)
            {
                LoginUI loginForm = new LoginUI();
                loginForm.Show();
                this.Hide();
            }
            else
            {
                this.Show();
            }
        }

        private void txtFirstname_Enter(object sender, EventArgs e)
        {
            if (txtFirstname.Text == "  First name")
            {
                txtFirstname.Text = "";
                txtFirstname.ForeColor = Color.Black;
            }
        }

        private void txtFirstname_Leave(object sender, EventArgs e)
        {
            if (txtFirstname.Text == "")
            {
                txtFirstname.Text = "  First name";
                txtFirstname.ForeColor = Color.Gray;
            }
        }

        private void txtLastname_Enter(object sender, EventArgs e)
        {
            if (txtLastname.Text == "  Last name")
            {
                txtLastname.Text = "";
                txtLastname.ForeColor = Color.Black;
            }
        }

        private void txtLastname_Leave(object sender, EventArgs e)
        {
            if (txtLastname.Text == "")
            {
                txtLastname.Text = "  Last name";
                txtLastname.ForeColor = Color.Gray;
            }
        }

        private void txtAddressLine1_Enter(object sender, EventArgs e)
        {
            if (txtAddressLine1.Text == "  Address Line 1")
            {
                txtAddressLine1.Text = "";
                txtAddressLine1.ForeColor = Color.Black;
            }
        }

        private void txtAddressLine1_Leave(object sender, EventArgs e)
        {
            if (txtAddressLine1.Text == "")
            {
                txtAddressLine1.Text = "  Address Line 1";
                txtAddressLine1.ForeColor = Color.Gray;
            }
            else if (txtAddressLine1.Text != "")
            {
                if (txtAddressLine1.Text.Contains("'"))
                {
                    txtAddressLine1.Text = txtAddressLine1.Text.Replace("'", "");
                }
            }
        }

        private void txtAddressLine2_Enter(object sender, EventArgs e)
        {
            if (txtAddressLine2.Text == "  Address Line 2")
            {
                txtAddressLine2.Text = "";
                txtAddressLine2.ForeColor = Color.Black;
            }
        }

        private void txtAddressLine2_Leave(object sender, EventArgs e)
        {
            if (txtAddressLine2.Text == "")
            {
                txtAddressLine2.Text = "  Address Line 2";
                txtAddressLine2.ForeColor = Color.Gray;
            }
            else if (txtAddressLine2.Text != "")
            {
                if (txtAddressLine2.Text.Contains("'"))
                {
                    txtAddressLine2.Text = txtAddressLine2.Text.Replace("'", "");
                }
            }
        }

        private void comboDisctrict_Enter(object sender, EventArgs e)
        {
            if (comboDisctrict.Text == "  District")
            {
                comboDisctrict.Text = "";
                comboDisctrict.ForeColor = Color.Black;
            }
        }

        private void comboDisctrict_Leave(object sender, EventArgs e)
        {
            if (comboDisctrict.Text == "")
            {
                comboDisctrict.Text = "  District";
                comboDisctrict.ForeColor = Color.Gray;
            }
        }

        private void comboProvince_Enter(object sender, EventArgs e)
        {
            if (comboProvince.Text == "  Province")
            {
                comboProvince.Text = "";
                comboProvince.ForeColor = Color.Black;
            }
        }

        private void comboProvince_Leave(object sender, EventArgs e)
        {
            if (comboProvince.Text == "")
            {
                comboProvince.Text = "  Province";
                comboProvince.ForeColor = Color.Gray;
            }
        }

        private void txtEmail_Enter(object sender, EventArgs e)
        {
            if (txtEmail.Text == "  example@example.com")
            {
                txtEmail.Text = "";
                txtEmail.ForeColor = Color.Black;
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")
            {
                txtEmail.Text = "  example@example.com";
                txtEmail.ForeColor = Color.Gray;
            }
            else if (txtEmail.Text != "")
            {
                if (!txtEmail.Text.Contains("@") || !txtEmail.Text.Contains("."))
                {
                    MessageBox.Show("Email may not in a proper format. Please check it.", "Email", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void txtMobile_Enter(object sender, EventArgs e)
        {
            if (txtMobile.Text == "  Mobile")
            {
                txtMobile.Text = "";
                txtMobile.ForeColor = Color.Black;
            }
        }

        private void txtMobile_Leave(object sender, EventArgs e)
        {
            if (txtMobile.Text == "")
            {
                txtMobile.Text = "  Mobile";
                txtMobile.ForeColor = Color.Gray;
            }
            else if (txtMobile.Text != "")
            {
                bool isContainNumbers = txtMobile.Text.All(char.IsDigit);
                if (isContainNumbers == false)
                {
                    MessageBox.Show("Field 'Mobile' can only contain numbers", "Mobile", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtMobile.Text = "  Mobile";
                    txtMobile.ForeColor = Color.Gray;
                }
                else if (!txtMobile.Text.StartsWith("0"))
                {
                    MessageBox.Show("Field 'Mobile' isn't in a correct format.\nKeep it in '0#########' format", "Mobile", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtMobile.Text = "  Mobile";
                    txtMobile.ForeColor = Color.Gray;
                }
                else if (txtMobile.Text.Length != 10)
                {
                    MessageBox.Show("Field 'Mobile' must contain 10-digits starts with '0'", "Mobile", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtMobile.Text = "  Mobile";
                    txtMobile.ForeColor = Color.Gray;
                }
            }
        }

        private void txtHome_Enter(object sender, EventArgs e)
        {
            if (txtHome.Text == "  Home")
            {
                txtHome.Text = "";
                txtHome.ForeColor = Color.Black;
            }
        }

        private void txtHome_Leave(object sender, EventArgs e)
        {
            if (txtHome.Text == "")
            {
                txtHome.Text = "  Home";
                txtHome.ForeColor = Color.Gray;
            }
            else if (txtHome.Text != "")
            {
                bool isContainNumbers = txtHome.Text.All(char.IsDigit);
                if (isContainNumbers == false)
                {
                    MessageBox.Show("Field 'Home' can only contain numbers", "Home", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtHome.Text = "  Home";
                    txtHome.ForeColor = Color.Gray;
                }
                else if (!txtHome.Text.StartsWith("0"))
                {
                    MessageBox.Show("Field 'Home' isn't in a correct format.\nKeep it in '0#########' format", "Home", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtHome.Text = "  Home";
                    txtHome.ForeColor = Color.Gray;
                }
                else if (txtHome.Text.Length != 10)
                {
                    MessageBox.Show("Field 'Home' must contain 10-digits starts with '0'", "Home", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtHome.Text = "  Home";
                    txtHome.ForeColor = Color.Gray;
                }
            }
        }

        private void txtParentName_Enter(object sender, EventArgs e)
        {
            if (txtParentName.Text == "  Parent's name")
            {
                txtParentName.Text = "";
                txtParentName.ForeColor = Color.Black;
            }
        }

        private void txtParentName_Leave(object sender, EventArgs e)
        {
            if (txtParentName.Text == "")
            {
                txtParentName.Text = "  Parent's name";
                txtParentName.ForeColor = Color.Gray;
            }
        }

        private void txtParentNIC_Enter(object sender, EventArgs e)
        {
            if (txtParentNIC.Text == "  Parent's National ID")
            {
                txtParentNIC.Text = "";
                txtParentNIC.ForeColor = Color.Black;
            }
        }

        private void txtParentNIC_Leave(object sender, EventArgs e)
        {
            if (txtParentNIC.Text == "")
            {
                txtParentNIC.Text = "  Parent's National ID";
                txtParentNIC.ForeColor = Color.Gray;
            }
        }

        private void txtParentContact_Enter(object sender, EventArgs e)
        {
            if (txtParentContact.Text == "  Parent's contact no.")
            {
                txtParentContact.Text = "";
                txtParentContact.ForeColor = Color.Black;
            }
        }

        private void txtParentContact_Leave(object sender, EventArgs e)
        {
            if (txtParentContact.Text == "")
            {
                txtParentContact.Text = "  Parent's contact no.";
                txtParentContact.ForeColor = Color.Gray;
            }
            else if (txtParentContact.Text != "")
            {
                bool isContainNumbers = txtParentContact.Text.All(char.IsDigit);
                if (isContainNumbers == false)
                {
                    MessageBox.Show("Field 'Parent's contact' can only contain numbers", "Parent's contact", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtParentContact.Text = "  Parent's contact no.";
                    txtParentContact.ForeColor = Color.Gray;
                }
                else if (!txtParentContact.Text.StartsWith("0"))
                {
                    MessageBox.Show("Field 'Parent's contact' isn't in a correct format.\nKeep it in '0#########' format", "Parent's contact", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtParentContact.Text = "  Parent's contact no.";
                    txtParentContact.ForeColor = Color.Gray;
                }
                else if (txtParentContact.Text.Length != 10)
                {
                    MessageBox.Show("Field 'Parent's contact' must contain 10-digits starts with '0'", "Parent's contact", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtParentContact.Text = "  Parent's contact no.";
                    txtParentContact.ForeColor = Color.Gray;
                }
            }
        }

        private void clearFields()
        {
            comboStdID.SelectedIndex = 0;
            txtFirstname.Text = "  First name";
            txtFirstname.ForeColor = Color.Gray;
            txtLastname.Text = "  Last name";
            txtLastname.ForeColor = Color.Gray;
            datePicker.ResetText();
            rbMale.Checked = false;
            rbFemale.Checked = false;
            txtAddressLine1.Text = "  Address Line 1";
            txtAddressLine1.ForeColor = Color.Gray;
            txtAddressLine2.Text = "  Address Line 2";
            txtAddressLine2.ForeColor = Color.Gray;
            comboDisctrict.Text = "  District";
            comboDisctrict.ForeColor = Color.Gray;
            comboProvince.Text = "  Province";
            comboProvince.ForeColor = Color.Gray;
            txtEmail.Text = "  example@example.com";
            txtEmail.ForeColor = Color.Gray;
            txtMobile.Text = "  Mobile";
            txtMobile.ForeColor = Color.Gray;
            txtHome.Text = "  Home";
            txtHome.ForeColor = Color.Gray;
            txtParentName.Text = "  Parent's name";
            txtParentName.ForeColor = Color.Gray;
            txtParentNIC.Text = "  Parent's National ID";
            txtParentNIC.ForeColor = Color.Gray;
            txtParentContact.Text = "  Parent's contact no.";
            txtParentContact.ForeColor = Color.Gray;
        }

        private bool validateFields()
        {
            if (txtFirstname.Text != "  First name" && txtLastname.Text != "  Last name" && (rbMale.Checked == true || rbFemale.Checked == true) && txtAddressLine1.Text != "  Address Line 1" && txtAddressLine2.Text != "  Address Line 2" && comboDisctrict.Text != "  District" && comboProvince.Text != "  Province" && txtEmail.Text != "  example@example.com" && txtMobile.Text != "  Mobile" && txtHome.Text != "  Home" && txtParentName.Text != "  Parent's name" && txtParentNIC.Text != "  Parent's National ID" && txtParentContact.Text != "  Parent's contact no.")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void btRegister_Click(object sender, EventArgs e)
        {
            bool isValid = validateFields();
            if (comboStdID.SelectedIndex != 0 || isValid == false)
            {
                MessageBox.Show("Please fill all the details", "Fill details", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    if (rbMale.Checked == true)
                    {
                        gender = "Male";
                    }
                    else if (rbFemale.Checked == true)
                    {
                        gender = "Female";
                    }

                    sqlCon.Open();

                    SqlCommand cmdQuery = new SqlCommand("SELECT COUNT(stdID) FROM Registrations", sqlCon);
                    int recordCount = Convert.ToInt32(cmdQuery.ExecuteScalar());
                    studentID = "ST" + (1000 + recordCount);

                    SqlCommand checkQuery = new SqlCommand("SELECT COUNT(stdID) FROM Registrations WHERE stdID='" + studentID + "'", sqlCon);
                    int checkCount = Convert.ToInt32(checkQuery.ExecuteScalar());
                    if (checkCount == 1)
                    {
                        for (int i = 0; i < recordCount; i++)
                        {
                            string checkID = "ST" + (1000 + i);
                            SqlCommand inTableQuery = new SqlCommand("SELECT COUNT(stdID) FROM Registrations WHERE stdID='" + checkID + "'", sqlCon);
                            int inTableCount = Convert.ToInt32(inTableQuery.ExecuteScalar());
                            if (inTableCount == 0)
                            {
                                studentID = checkID;
                            }
                        }
                    }

                    string insertQuery = "INSERT INTO Registrations (stdID, firstName, lastName, dateOfBirth, gender, addressLine1, addressLine2, addressDistrict, addressProvince, email, mobilePhone, homePhone, parentName, parentNIC, parentContact) VALUES ('" + studentID + "', '" + txtFirstname.Text + "', '" + txtLastname.Text + "', '" + datePicker.Value.ToString("yyyy-MM-dd") + "', '" + gender + "', '" + txtAddressLine1.Text + "', '" + txtAddressLine2.Text + "', '" + comboDisctrict.Text + "', '" + comboProvince.Text + "', '" + txtEmail.Text + "', '" + txtMobile.Text + "', '" + txtHome.Text + "', '" + txtParentName.Text + "', '" + txtParentNIC.Text + "', '" + txtParentContact.Text + "')";
                    SqlCommand sqlCmd = new SqlCommand(insertQuery, sqlCon);
                    sqlCmd.ExecuteNonQuery();
                    MessageBox.Show("Record added successfully\nYour Student ID : " + studentID, "Register student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex);
                }
                finally
                {
                    sqlCon.Close();
                    clearFields();
                    loadData();
                    stdCountStatus();
                    loadStdID();
                }
            }
        }

        private void comboStdID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboStdID.SelectedIndex == 0)
            {
                clearFields();
            }
            else
            {
                sqlCon.Open();

                string searchQuery = "SELECT * FROM Registrations WHERE stdID='" + comboStdID.SelectedItem.ToString() + "'";
                SqlCommand sqlCmd = new SqlCommand(searchQuery, sqlCon);
                SqlDataReader dataRead = sqlCmd.ExecuteReader();
                while (dataRead.Read())
                {
                    txtFirstname.Text = dataRead[1].ToString();
                    txtFirstname.ForeColor = Color.Black;
                    txtLastname.Text = dataRead[2].ToString();
                    txtLastname.ForeColor = Color.Black;
                    datePicker.Value = (DateTime)dataRead[3];
                    gender = dataRead[4].ToString();
                    if (gender == "Male")
                    {
                        rbMale.Checked = true;
                    }
                    else if (gender == "Female")
                    {
                        rbFemale.Checked = true;
                    }
                    txtAddressLine1.Text = dataRead[5].ToString();
                    txtAddressLine1.ForeColor = Color.Black;
                    txtAddressLine2.Text = dataRead[6].ToString();
                    txtAddressLine2.ForeColor = Color.Black;
                    comboDisctrict.Text = dataRead[7].ToString();
                    comboDisctrict.ForeColor = Color.Black;
                    comboProvince.Text = dataRead[8].ToString();
                    comboProvince.ForeColor = Color.Black;
                    txtEmail.Text = dataRead[9].ToString();
                    txtEmail.ForeColor = Color.Black;
                    txtMobile.Text = "0" + dataRead[10].ToString();
                    txtMobile.ForeColor = Color.Black;
                    txtHome.Text = "0" + dataRead[11].ToString();
                    txtHome.ForeColor = Color.Black;
                    txtParentName.Text = dataRead[12].ToString();
                    txtParentName.ForeColor = Color.Black;
                    txtParentNIC.Text = dataRead[13].ToString();
                    txtParentNIC.ForeColor = Color.Black;
                    txtParentContact.Text = "0" + dataRead[14].ToString();
                    txtParentContact.ForeColor = Color.Black;
                }

                sqlCon.Close();
            }
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            bool isValid = validateFields();
            if (comboStdID.SelectedIndex == 0 || isValid == false)
            {
                MessageBox.Show("Please fill all the details", "Fill details", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult updatePrompt = MessageBox.Show("Do you really want to update the record?", "Update student", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (updatePrompt == DialogResult.Yes)
                {
                    try
                    {
                        if (rbMale.Checked == true)
                        {
                            gender = "Male";
                        }
                        else if (rbFemale.Checked == true)
                        {
                            gender = "Female";
                        }

                        sqlCon.Open();

                        string updateQuery = "UPDATE Registrations SET firstName='" + txtFirstname.Text + "', lastName='" + txtLastname.Text + "', dateOfBirth='" + datePicker.Value.ToString("yyyy-MM-dd") + "', gender='" + gender + "', addressLine1='" + txtAddressLine1.Text + "', addressLine2='" + txtAddressLine2.Text + "', addressDistrict='" + comboDisctrict.Text + "', addressProvince='" + comboProvince.Text + "', email='" + txtEmail.Text + "', mobilePhone='" + txtMobile.Text + "', homePhone='" + txtHome.Text + "', parentName='" + txtParentName.Text + "', parentNIC='" + txtParentNIC.Text + "', parentContact='" + txtParentContact.Text + "' WHERE stdID='" + comboStdID.Text + "'";
                        SqlCommand sqlCmd = new SqlCommand(updateQuery, sqlCon);
                        sqlCmd.ExecuteNonQuery();
                        MessageBox.Show("Record updated successfully", "Update student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex);
                    }
                    finally
                    {
                        sqlCon.Close();
                        clearFields();
                        loadData();
                    }
                }
            }
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            if (comboStdID.SelectedIndex == 0)
            {
                MessageBox.Show("First select a Student ID to remove", "Student ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult deletePrompt = MessageBox.Show("Are you sure, Do you really want to delete this record...?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (deletePrompt == DialogResult.Yes)
                {
                    try
                    {
                        sqlCon.Open();
                        string deleteQuery = "DELETE FROM Registrations WHERE stdID='" + comboStdID.SelectedItem.ToString() + "'";
                        SqlCommand sqlCmd = new SqlCommand(deleteQuery, sqlCon);
                        sqlCmd.ExecuteNonQuery();
                        MessageBox.Show("Record deleted successfully", "Delete student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex);
                    }
                    finally
                    {
                        sqlCon.Close();
                        clearFields();
                        loadData();
                        stdCountStatus();
                        loadStdID();
                    }
                }
            }
        }
    }
}
