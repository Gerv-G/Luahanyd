using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BitDev.DataTransferObjects;
using BitDev.DomainEntities;
using BitDev.Enums;

namespace BitDev.EntityFactories
{
    public class EmployeeFactory : IEmployeeFactory
    {
        public Employee CreateEmployee(EmployeeDto employeeDto)
        {
            return new Employee
            {
                Id = employeeDto.Id,
                EmployeeNumber = employeeDto.EmployeeNumber,
                FirstName = employeeDto.FirstName,
                MiddleName = employeeDto.MiddleName,
                LastName = employeeDto.LastName,
                Gender = (Gender)employeeDto.Gender, 
                BirthDate = employeeDto.BirthDate,
                MobileNumber = employeeDto.MobileNumber,
                TelephoneNumber = employeeDto.TelephoneNumber,
                EmailAddress = employeeDto.EmailAddress,
                HomeAddress = employeeDto.HomeAddress,
                SssNumber = employeeDto.SssNumber,
                BirNumber = employeeDto.BirNumber,
                TaxIdentificationNumber = employeeDto.TaxIdentificationNumber,
                PhilHealthNumber = employeeDto.PhilHealthNumber,
                HdmfNumber = employeeDto.HdmfNumber
            };
        }
    }
}
