using CsvHelper.Configuration.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patient_BulkImport_Formatter.Models
{
    public class JMPatient
    {
        [Name("Patient UR")]
        public string? PatientUR { get; set; }

        [Name("Given Name")]
        public string? GivenName { get; set; }

        [Name("Surname")]
        public string? Surname { get; set; }

        [Name(" Due Date")]
        public string? DueDate { get; set; }

        [Name("Email Address")]
        public string? EmailAddress { get; set; }

        [Name("Address")]
        public string? Address { get; set; }

        [Name("Phone No.")]
        public string? PhoneNo { get; set; }
    }
}
