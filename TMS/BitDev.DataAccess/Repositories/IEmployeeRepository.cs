using System.Collections.Generic;
using BitDev.DataTransferObjects;
using BitDev.DomainEntities;

namespace BitDev.DataAccess.Repositories
{
    public interface IEmployeeRepository
    {
        IEnumerable<Employee> GetAllEmployees();
    }
}
