using System.Collections.Generic;
using System.Linq;
using BitDev.DataAccess.Infrastructure;
using BitDev.DataTransferObjects;
using BitDev.DomainEntities;
using BitDev.EntityFactories;
using Dapper.Contrib.Extensions;

namespace BitDev.DataAccess.Repositories
{
    public class EmployeeRepository : Repository<Employee>, IEmployeeRepository
    {
        private readonly IConnectionFactory _connectionFactory;

        public EmployeeRepository(IConnectionFactory connection)
        {
            _connectionFactory = connection;
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            var employeeFactory = new EmployeeFactory();

            var employees = new List<Employee>();

            var employeeDtos =  _connectionFactory
                .GetConnection()
                .GetAll<EmployeeDto>()
                .ToList();

            employeeDtos.ForEach(x =>
            {
                employees.Add(employeeFactory.CreateEmployee(x));
            });

            return employees;
        }
    }
}
