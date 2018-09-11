using System;

namespace DomainEntities
{
    public class Employee
    {
        public Employee()
        {

        }

        public string EmployeeNumber { get; set; }

        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public string LastName { get; set; }

        public Gender Gender { get; set; }

        public DateTime BirthDate { get; set; }

        public string MobileNumber { get; set; }

        public string TelephoneNumber { get; set; }

        public string EmailAddress { get; set; }

        public string HomeAddress { get; set; }

        public string HomePhoneNumber { get; set; }

        public string SssNumber { get; set; }

        public string BirNumber { get; set; }

        public string TaxIdentificationNumber { get; set; }

        public string PhilHealthNumber { get; set; }

        public string HdmfNumber { get; set; }

    }
}
