namespace WahidiLicence
{
    public partial class Form1 : Form
    {
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
            txtCompanyName.Focus();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnCal_Click(object sender, EventArgs e)
        {
            decimal subTotal;
            decimal taxAmount;
            decimal totalCost;

            // User input
            // Create object
            LicenseAgreement1 license = new LicenseAgreement1();

            // Set object properties
            license.CompanyName = txtCompanyName.Text;
            license.NumberOfUsers = int.Parse(txtNumberOfUsers.Text);
            license.LicenseCostPerUser = 100m;

            subTotal = license.CalculateSubTotal();
            taxAmount = license.CalculateTaxAmount();
            totalCost = license.CalculateTotalCost();

            // Display output
            lstOutput.Items.Add("Company Name: " + license.CompanyName);
            lstOutput.Items.Add("Number Of Users: " + license.NumberOfUsers.ToString("N0"));
            lstOutput.Items.Add("Software Cost: " + license.LicenseCostPerUser.ToString("C"));
            lstOutput.Items.Add("Sub Total: " + subTotal.ToString("C"));
            lstOutput.Items.Add("Tax Rate: 10%");
            lstOutput.Items.Add("Tax Amount: " + taxAmount.ToString("C"));
            lstOutput.Items.Add("Total Cost: " + totalCost.ToString("C"));

            btnClear.Focus();


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
    }
}
