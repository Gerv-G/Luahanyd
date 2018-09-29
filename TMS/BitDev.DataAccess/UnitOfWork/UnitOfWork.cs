using System;
using BitDev.DataAccess.Infrastructure;
using BitDev.DataAccess.Repositories;

namespace BitDev.DataAccess.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IConnectionFactory _connectionFactory;

        public UnitOfWork(IConnectionFactory connectionFactory)
        {
            _connectionFactory = connectionFactory;
            Employees = new EmployeeRepository(_connectionFactory);
        }

        public IEmployeeRepository Employees { get; private set; }

        public int Complete()
        {
            throw new NotImplementedException();

        }

        public void Dispose()
        {
            _connectionFactory.GetConnection().Dispose();
        }
    }
}
