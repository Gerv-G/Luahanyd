using System;
using BitDev.DataAccess.Repositories;

namespace BitDev.DataAccess.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        IEmployeeRepository Employees { get; }

        int Complete();
    }
}
