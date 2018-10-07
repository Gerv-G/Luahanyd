using System;
using BitDev.DomainEntities;
using BitDev.Enums;
using Dapper.Contrib.Extensions;

namespace BitDev.PersistentEntities
{
    [Table("Payroll.Employees")]
    public class EmployeePersistentEntity : PersistentEntity<Employee>
    {
        [Key]
        public int Id { get; set; }

        public string EmployeeNumber { get; set; }

        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public string LastName { get; set; }

        public int Gender { get; set; }

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

        public override Employee ToEntity()
        {
            return new Employee
            {
                Id = Id,
                EmployeeNumber = EmployeeNumber,
                FirstName = FirstName,
                MiddleName = MiddleName,
                LastName = LastName,
                Gender = (Gender)Gender,
                BirthDate = BirthDate,
                MobileNumber = MobileNumber,
                TelephoneNumber = TelephoneNumber,
                EmailAddress = EmailAddress,
                HomeAddress = HomeAddress,
                HomePhoneNumber = HomePhoneNumber,
                SssNumber = SssNumber,
                BirNumber = BirNumber,
                TaxIdentificationNumber = TaxIdentificationNumber,
                PhilHealthNumber = PhilHealthNumber,
                HdmfNumber = HdmfNumber
            };
        }
    }
}
