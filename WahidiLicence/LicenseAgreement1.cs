using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace WahidiLicence
{
    public class LicenseAgreement1

    {
        public string CompanyName { get; set; }
        public int NumberofUsers { get; set; }
        public decimal LicenseCostPerUser { get; set; }

        public LicenseAgreement1()

        {
            CompanyName = "";
            NumberofUsers = 0;
            LicenseCostPerUser = 100m;
        }

        public LicenseAgreement1(string companyName, int numberOfUsers, decimal licenseCostPerUser)
        {
            CompanyName = companyName;
            NumberofUsers = numberOfUsers;
            LicenseCostPerUser = licenseCostPerUser;
        }
 
    }
}
