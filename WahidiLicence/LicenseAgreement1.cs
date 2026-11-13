using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace WahidiLicence
{
    public class LicenseAgreement1

    {
        public const string NO_SUPPORT_TYPE = "No Support";
        public const string STANDARD_SUPPORT_TYPE = "Standard Support";
        public const string PREMIUM_SUPPORT_TYPE = "Premium Support";

        public string CompanyName { get; set; }
        public int NumberOfUsers { get; set; }
        public decimal LicenseCostPerUser { get; set; }
        public decimal SubTotal { get; set; }
        public decimal TaxRate { get; set; }
        public decimal TaxAmount { get; set; }
        public decimal TotalCost { get; set; }

        public string SupportType { get; set; } = "";
        public void SetSupportType(string supportType)
        {
            switch (supportType)
            {
                case NO_SUPPORT_TYPE:
                    SupportType = NO_SUPPORT_TYPE;
                    break;

                case STANDARD_SUPPORT_TYPE:
                    SupportType = STANDARD_SUPPORT_TYPE;
                    break;

                case PREMIUM_SUPPORT_TYPE:
                    SupportType = PREMIUM_SUPPORT_TYPE;
                    break;
            }
        }

        public LicenseAgreement1()

        {
            CompanyName = "";
            NumberOfUsers = 0;
            LicenseCostPerUser = 100m;
            SubTotal = 0m;
            TaxRate = 0.10m;
            TaxAmount = 0m;
            TotalCost = 0m;
        }

        
  
        public LicenseAgreement1(string companyName, int numberOfUsers, decimal licenseCostPerUser, string supportType)
        {
            CompanyName = companyName;
            NumberOfUsers = numberOfUsers;
            LicenseCostPerUser = licenseCostPerUser;
            SubTotal = 0m;
            TaxRate = 0.10m;
            TaxAmount = 0m;

            TotalCost = 0m;

            SetSupportType(supportType);
            CalculateTotalCost();
        }
        public void CalculateSubTotal()
        {

            SubTotal = NumberOfUsers * LicenseCostPerUser;
        }
        public void CalculateTaxAmount()
        {

            TaxAmount = SubTotal * TaxRate;
           
        }
        public void CalculateTotalCost()

        {
            CalculateSubTotal();
            CalculateTaxAmount();
            TotalCost = SubTotal + TaxAmount;
        }
        public override string ToString()
        {
            return "Company Name: " + CompanyName +
                "\nNumber of Users: " + NumberOfUsers.ToString("N0") +
                "\nLicense Cost Per User: " + LicenseCostPerUser.ToString("C") +
                "\nSub Total:"+ SubTotal.ToString("C") +
                " \nTax Rate:" + TaxRate.ToString("P0") +
                "\nTax Amount: " + TaxAmount.ToString("C") +
                "\nTotal Cost: " + TotalCost.ToString("C");
        }

    }
}
