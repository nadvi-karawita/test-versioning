using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper.Configuration.Attributes;

namespace Patient_BulkImport_Formatter.Models
{
    public class ETPPatient
    {
        [Name("UR Number")]
        public string? URNumber { get; set; }

        [Name("Family Name")]
        public string? FamilyName { get; set; }

        [Name("First Name")]
        public string? FirstName { get; set; }

        [Name("DOB")]
        public string? DateOfBirth { get; set; }

        [Name("Expected Date of Delivery")]
        public string? ExpectedDateOfDelivery { get; set; }

        [Name("Email Address")]
        public string? EmailAddress { get; set; }

        [Name("Site ID")]
        public string? SiteID { get; set; }

        [Name("Activation Code")]
        public string? ActivationCode { get; set; }

        [Name("Mobile Phone")]
        public string? MobilePhone { get; set; }
    }
}
