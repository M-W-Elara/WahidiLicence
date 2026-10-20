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

        public LicenseAgreement1()

        {
            CompanyName = "";
            NumberOfUsers = 0;
            LicenseCostPerUser = 100m;
        }

        public LicenseAgreement1(string companyName, int numberOfUsers, decimal licenseCostPerUser)
        {
            CompanyName = companyName;
            NumberOfUsers = numberOfUsers;
            LicenseCostPerUser = licenseCostPerUser;
        }
        public decimal CalculateSubTotal()
        {
            return NumberOfUsers * LicenseCostPerUser;
        }
        public decimal CalculateTaxAmount()
        {
            return CalculateSubTotal() * 0.1m;
        }
        public decimal CalculateTotalCost()

        {
            return CalculateSubTotal() + CalculateTaxAmount();
        }
        public override string ToString()
        {
            return "Company Name: " + CompanyName +
                "\nNumber of Users: " + NumberOfUsers.ToString("N0") +
                "\nLicense Cost Per User: " + LicenseCostPerUser.ToString("C") +
                "\nTotal Cost: " + CalculateTotalCost().ToString("C");
        }

    }
}
