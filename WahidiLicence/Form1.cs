using System.IO;
using System.Drawing.Text;
using System.Net.NetworkInformation;

namespace WahidiLicence
{
    public partial class Form1 : Form
    {

        private string supportType = "";
        private string licenseTransactionOutput = "LicenseTransactionOutput.txt";

        private const int LISTBOX = 1;
        private const int FILE = 2;
        private const int BOTH = 3;

        public Form1()
        {
            InitializeComponent();
        }

        private void lblUsers_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCompanyName.Clear();
            txtNumberOfUsers.Clear();
            lstOutput.Items.Clear();
            rdoNoSupport.Checked = true;
            txtCompanyName.Focus();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            DialogResult buttonSelected;

            buttonSelected = MessageBox.Show("Are you sure you want to quit?", "Quit Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (buttonSelected == DialogResult.Yes)

            {
                this.Close();
            }
        }


        private void btnCal_Click(object sender, EventArgs e)
        {

            int numberOfUsers;
            bool isNumberOfUsersValid;

            isNumberOfUsersValid =
                int.TryParse(txtNumberOfUsers.Text, out numberOfUsers);

            if (isNumberOfUsersValid)
            {



                // Create object
                LicenseAgreement1 license = new LicenseAgreement1(
                    txtCompanyName.Text.Trim(),
                    numberOfUsers,
                    100m,
                    supportType);
                // Output transaction header with date and time

                outputMsg("************** Transaction Output at "
                    + DateTime.Now.ToString("G")
                    + "****************", FILE);


                // Display transaction in ListBox and save to file
                outputMsg(license.ToString(), BOTH);
                outputMsg("****************************************", BOTH);
                btnClear.Focus();
            }


            else
            {
                lstOutput.Items.Add("Please enter a valid whole number of users.");

            }
        }
        private void outputMsg(string msg, int type)
        {
            StreamWriter sw;

            if (type == FILE || type == BOTH)
            {
                sw = File.AppendText(licenseTransactionOutput);
                string[] lines = msg.Split('\n');
                for (int i = 0; i < lines.Length; i++)
                {
                    sw.WriteLine(lines[i]);
                }
                sw.Close();
            }
            if (type == LISTBOX || type == BOTH)
            {
                string[] lines = msg.Split('\n');
                for (int i = 0; i < lines.Length; i++)
                {
                    lstOutput.Items.Add(lines[i]);
                }
            }

        }
                


        private void txtCompanyName_Enter(object sender, EventArgs e)
        {
            txtCompanyName.BackColor = SystemColors.Info;
        }

        private void txtNumberOfUsers_Enter(object sender, EventArgs e)
        {
            txtNumberOfUsers.BackColor = SystemColors.Info;
        }

        private void txtCompanyName_Leave(object sender, EventArgs e)
        {
            txtCompanyName.BackColor = SystemColors.Window;
        }

        private void txtNumberOfUsers_Leave(object sender, EventArgs e)
        {
            txtNumberOfUsers.BackColor = SystemColors.Window;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoNoSupport.Checked)
            {
                supportType = LicenseAgreement1.NO_SUPPORT_TYPE;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            rdoNoSupport.Checked = true;
        }
        private void grpSupport_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoStandardSupport.Checked)
            {
                supportType = LicenseAgreement1.STANDARD_SUPPORT_TYPE;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoPremiumSupport.Checked)
            {
                supportType = LicenseAgreement1.PREMIUM_SUPPORT_TYPE;
            }
        }
    }

}
