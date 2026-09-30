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


        private void btnDisplay_Click(object sender, EventArgs e)
        {
            // User input
            string companyName = txtCompanyName.Text;
            int numberOfUsers = int.Parse(txtNumberOfUsers.Text);
            int softwareCost = 100;


            // Output
            decimal subTotal;
            decimal taxRate;
            decimal taxAmount;
            decimal totalCost;

            companyName = txtCompanyName.Text;

            //Calculate
            taxRate = 0.1m;
            subTotal = numberOfUsers * softwareCost;
            taxAmount = subTotal * taxRate;
            totalCost = subTotal + taxAmount;

            //display output
            lstOutput.Items.Add("Company Name: " + companyName);
            lstOutput.Items.Add("Number Of Users: " + numberOfUsers.ToString("N0"));
            lstOutput.Items.Add("Software Cost: $" + softwareCost.ToString("C"));
            lstOutput.Items.Add("Sub Total: $" + subTotal.ToString("C"));
            lstOutput.Items.Add("Tax Amount: $" + taxAmount.ToString("C"));
            lstOutput.Items.Add("Total Cost: $" + totalCost.ToString("C"));

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

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
