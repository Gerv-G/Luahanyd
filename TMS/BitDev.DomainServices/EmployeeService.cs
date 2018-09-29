using System;
using System.Collections.Generic;
using BitDev.DataAccess.UnitOfWork;
using BitDev.DomainEntities;
//using Npgsql;

namespace BitDev.DomainServices
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IUnitOfWork _unitOfWork;

        public EmployeeService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            return _unitOfWork.Employees.GetAllEmployees();
        }

        //public void Save(Employee employee)
        //{
        //    DatabaseConnection.Open();

        //    var cmd = new NpgsqlCommand(
        //        "INSERT INTO payroll.employees (EmployeeNumber, FirstName, MiddleName, " +
        //        "LastName, Gender, BirthDate, MobileNumber, TelephoneNumber, EmailAddress, " +
        //        "HomeAddress, HomePhoneNumber, SssNumber, BirNumber, TaxIdentificationNumber, " +
        //        $"PhilHealthNumber, HdmfNumber) VALUES ('{employee.EmployeeNumber}', '{employee.FirstName}', " +
        //        $"'{employee.MiddleName}', '{employee.LastName}', {Convert.ToBoolean(employee.Gender)}, " +
        //        $"'{employee.BirthDate}', '{employee.MobileNumber}', '{employee.TelephoneNumber}', " +
        //        $"'{employee.EmailAddress}', '{employee.HomeAddress}', '{employee.HomePhoneNumber}', " +
        //        $"'{employee.SssNumber}', '{employee.BirNumber}', '{employee.TaxIdentificationNumber}', " +
        //        $"'{employee.PhilHealthNumber}', '{employee.HdmfNumber}')", DatabaseConnection);

        //    cmd.ExecuteReader();

        //    DatabaseConnection.Close();
        //}
    }
}
