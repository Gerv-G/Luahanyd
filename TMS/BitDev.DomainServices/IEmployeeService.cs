using System.Collections.Generic;
using BitDev.DomainEntities;

namespace BitDev.DomainServices
{
    public interface IEmployeeService
    {
        IEnumerable<Employee> GetAllEmployees();
    }
}
