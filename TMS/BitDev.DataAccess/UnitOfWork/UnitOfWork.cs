using BitDev.DataAccess.Infrastructure;
using BitDev.DataAccess.Repositories;
using Npgsql;

namespace BitDev.DataAccess.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IConnectionFactory _connectionFactory;
        private NpgsqlConnection _connection;
        private NpgsqlTransaction _transaction;
        private EmployeeRepository _employeeRepository;

        public UnitOfWork(IConnectionFactory connectionFactory)
        {
            _connectionFactory = connectionFactory;
            _connection = _connectionFactory.GetConnection();
            _transaction = _connection.BeginTransaction();
        }

        public EmployeeRepository EmployeeRepository => 
            _employeeRepository ?? (_employeeRepository = new EmployeeRepository(_transaction));

        public void Complete()
        {
            try
            {
                _transaction.Commit();
            }
            catch
            {
                _transaction.Rollback();
            }
            finally
            {
                _transaction.Dispose();
                _transaction = _connectionFactory
                    .GetConnection()
                    .BeginTransaction();
                ResetRepositories();
            }
        }

        public void Dispose()
        {
            if (_transaction != null)
            {
                _transaction.Dispose();
                _transaction = null;
            }

            if (_connection == null) return;
            _connection.Dispose();
            _connection = null;
        }

        private void ResetRepositories()
        {
            _employeeRepository = null;
        }
    }
}
