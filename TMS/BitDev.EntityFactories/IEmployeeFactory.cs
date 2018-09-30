using BitDev.DataTransferObjects;
using BitDev.DomainEntities;

namespace BitDev.EntityFactories
{
    public interface IEmployeeFactory
    {
        Employee CreateEmployee(EmployeeDto employeeDto);
    }
}
