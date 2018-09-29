using System.Collections.Generic;
using BitDev.DataAccess.Infrastructure;
using BitDev.DomainEntities;
using Dapper;
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
            //var query = "SELECT * FROM payroll.employees;";

            return _connectionFactory.GetConnection().GetAll<Employee>();
        }
    }
}
