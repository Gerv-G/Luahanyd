using System;
using DomainEntities;
using Npgsql;

namespace DomainServices
{
    public class EmployeeService
    {
        public EmployeeService(NpgsqlConnection connection)
        {
            DatabaseConnection = connection;
        }

        public NpgsqlConnection DatabaseConnection { get; set; }

        public void Save(Employee employee)
        {
            DatabaseConnection.Open();

            var cmd = new NpgsqlCommand(
                "INSERT INTO payroll.employees (EmployeeNumber, FirstName, MiddleName, " +
                "LastName, Gender, BirthDate, MobileNumber, TelephoneNumber, EmailAddress, " +
                "HomeAddress, HomePhoneNumber, SssNumber, BirNumber, TaxIdentificationNumber, " +
                $"PhilHealthNumber, HdmfNumber) VALUES ('{employee.EmployeeNumber}', '{employee.FirstName}', " +
                $"'{employee.MiddleName}', '{employee.LastName}', {Convert.ToBoolean(employee.Gender)}, " +
                $"'{employee.BirthDate}', '{employee.MobileNumber}', '{employee.TelephoneNumber}', " +
                $"'{employee.EmailAddress}', '{employee.HomeAddress}', '{employee.HomePhoneNumber}', " +
                $"'{employee.SssNumber}', '{employee.BirNumber}', '{employee.TaxIdentificationNumber}', " +
                $"'{employee.PhilHealthNumber}', '{employee.HdmfNumber}')", DatabaseConnection);

            cmd.ExecuteReader();

            DatabaseConnection.Close();
        }
    }
}
