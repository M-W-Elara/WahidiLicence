using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace WahidiLicence
{
    public class LicenseAgreement1

    {
        public string CompanyName { get; set; }
        public int NumberOfUsers { get; set; }
        public decimal LicenseCostPerUser { get; set; }
        public decimal SubTotal { get; set; }
        public decimal TaxRate { get; set; }
        public decimal TotalCost { get; set; }

        public LicenseAgreement1()

        {
            CompanyName = "";
            NumberOfUsers = 0;
            LicenseCostPerUser = 100m;
            SubTotal = 0m;
            TaxRate = 0.10m;
            TotalCost = 0m;
        }

        
  
        public LicenseAgreement1(string companyName, int numberOfUsers, decimal licenseCostPerUser)
        {
            CompanyName = companyName;
            NumberOfUsers = numberOfUsers;
            LicenseCostPerUser = licenseCostPerUser;
            SubTotal = 0m;
            TaxRate = 0.10m;
            TotalCost = 0m;
        }
        public decimal CalculateSubTotal()
        {

            SubTotal = NumberOfUsers * LicenseCostPerUser;
            return SubTotal;
        }
        public decimal CalculateTaxAmount()
        {

            return SubTotal * TaxRate;
        }
        public decimal CalculateTotalCost()

        {
            TotalCost = SubTotal + CalculateTaxAmount();
            return TotalCost;
        }
        public override string ToString()
        {
            return "Company Name: " + CompanyName +
                "\nNumber of Users: " + NumberOfUsers.ToString("N0") +
                "\nLicense Cost Per User: " + LicenseCostPerUser.ToString("C") +
                "\nSub Total:"+ SubTotal.ToString("C") +
                " \nTax Rate:" + TaxRate.ToString("P0") +
                "\nTotal Cost: " + TotalCost.ToString("C");
        }

    }
}
