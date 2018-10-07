using System;
using BitDev.DomainEntities;
using BitDev.DomainServices;

namespace EmployeeEncoder
{
    public class Program
    {
        public static void Main(string[] args)
        {
            EmployeeService employeeService = new EmployeeService();

            Console.WriteLine("---------------------- Employee Encoder System v1 ----------------------");

            //var employee = AddEmployee();

            var kier = employeeService.GetByEmployeeId(1);

            var employees = employeeService.GetAll();

            //DisplayEmployee(employee);
        }

        public static Employee AddEmployee()
        {
            var employee = new Employee();

            Console.WriteLine("------------ Please fill up the following required details! ------------");
            Console.Write("Enter Employee Number: ");
            employee.EmployeeNumber = Console.ReadLine();
            Console.Write("Enter First Name: ");
            employee.FirstName = Console.ReadLine();
            Console.Write("Enter Middle Name: ");
            employee.MiddleName = Console.ReadLine();
            Console.Write("Enter Last Name: ");
            employee.LastName = Console.ReadLine();
            Console.Write("Enter Gender(0-Female, 1-Male): \n");
            //employee.Gender = Gender.Male;
            Console.Write("Enter Birth Date(yyyy-mm-dd): ");
            employee.BirthDate = Convert.ToDateTime(Console.ReadLine());
            Console.Write("Enter Mobile Number: ");
            employee.MobileNumber = Console.ReadLine();
            Console.Write("Enter Telephone Number: ");
            employee.TelephoneNumber = Console.ReadLine();
            Console.Write("Enter Email Address: ");
            employee.EmailAddress = Console.ReadLine();
            Console.Write("Enter Home Address: ");
            employee.HomeAddress = Console.ReadLine();
            Console.Write("Enter Home Phone Number: ");
            employee.HomePhoneNumber = Console.ReadLine();
            Console.Write("Enter SSS Number: ");
            employee.SssNumber = Console.ReadLine();
            Console.Write("Enter BIR Number: ");
            employee.BirNumber = Console.ReadLine();
            Console.Write("Enter Tax Identification Number: ");
            employee.TaxIdentificationNumber = Console.ReadLine();
            Console.Write("Enter PhilHealth Number: ");
            employee.PhilHealthNumber = Console.ReadLine();
            Console.Write("Enter HDMF Number: ");
            employee.HdmfNumber = Console.ReadLine();

            return employee;
        }

        private static void DisplayEmployee(Employee employee)
        {
            Console.WriteLine("------------------------- Employee Information -------------------------");
            Console.WriteLine("Employee Number: " + employee.EmployeeNumber);
            Console.WriteLine("First Name: " + employee.FirstName);
            Console.WriteLine("Middle Name: " + employee.MiddleName);
            Console.WriteLine("Last Name: " + employee.LastName);
            Console.WriteLine("Birth Date: " + employee.BirthDate);
            Console.WriteLine("Mobile Number: " + employee.MobileNumber);
            Console.WriteLine("Telephone Number: " + employee.TelephoneNumber);
            Console.WriteLine("Email Address: " + employee.EmailAddress);
            Console.WriteLine("Home Address: " + employee.HomeAddress);
            Console.WriteLine("Home Phone Number: " + employee.HomePhoneNumber);
            Console.WriteLine("SSS Number: " + employee.SssNumber);
            Console.WriteLine("BIR Number: " + employee.BirNumber);
            Console.WriteLine("Tax Indentification Number: " + employee.TaxIdentificationNumber);
            Console.WriteLine("PhilHealth Number: " + employee.PhilHealthNumber);
            Console.WriteLine("HDMF Number: " + employee.HdmfNumber);
        }
    }
}
