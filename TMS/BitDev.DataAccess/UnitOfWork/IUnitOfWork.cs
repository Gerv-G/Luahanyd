using System;
using BitDev.DataAccess.Repositories;

namespace BitDev.DataAccess.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        EmployeeRepository EmployeeRepository { get; }
        void Complete();
    }
}
