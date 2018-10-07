using System.Collections.Generic;
using BitDev.DataAccess.Infrastructure;
using BitDev.DataAccess.UnitOfWork;
using BitDev.DomainEntities;

namespace BitDev.DomainServices
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IConnectionFactory _connectionFactory = new ConnectionFactory();

        public EmployeeService() {}

        public Employee GetByEmployeeId(int id)
        {
            using (var unitOfWork = new UnitOfWork(_connectionFactory))
            {
                return unitOfWork.EmployeeRepository.Get(id);
            }
        }

        public IEnumerable<Employee> GetAll()
        {
            using (var unitOfWork = new UnitOfWork(_connectionFactory))
            {
                return unitOfWork.EmployeeRepository.GetAll();
            }
        }
    }
}
