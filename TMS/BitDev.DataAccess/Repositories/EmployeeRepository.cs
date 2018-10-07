using BitDev.DomainEntities;
using BitDev.PersistentEntities;
using Npgsql;

namespace BitDev.DataAccess.Repositories
{
    public class EmployeeRepository : Repository<Employee, EmployeePersistentEntity>, IEmployeeRepository
    {
        private readonly NpgsqlTransaction _transaction;

        public EmployeeRepository(NpgsqlTransaction transaction) 
            : base(transaction)
        {
            _transaction = transaction;
        }

        private NpgsqlConnection Connection => _transaction.Connection;
    }
}
