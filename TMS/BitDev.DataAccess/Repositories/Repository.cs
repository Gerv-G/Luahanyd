using System;
using System.Collections.Generic;
using System.Linq;
using BitDev.PersistentEntities;
using Dapper.Contrib.Extensions;
using Npgsql;

namespace BitDev.DataAccess.Repositories
{
    public class Repository<TEntity, TPersistentEntity> : IRepository<TEntity, TPersistentEntity>
        where TEntity : class
        where TPersistentEntity : PersistentEntity<TEntity>
    {
        private readonly NpgsqlTransaction _transaction;

        public Repository(NpgsqlTransaction transaction)
        {
            _transaction = transaction;
        }

        private NpgsqlConnection Connection => _transaction.Connection;

        public void Add(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public void Update(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public TEntity Get(int id)
        {
            return Connection.Get<TPersistentEntity>(id, _transaction)
                .ToEntity();
        }

        public IEnumerable<TEntity> GetAll()
        {
            var employees = new List<TEntity>();

            var employeePersistenEntities = Connection
                .GetAll<TPersistentEntity>(_transaction)
                .ToList();

            employeePersistenEntities.ForEach(x =>
            {
                employees.Add(x.ToEntity());
            });

            return employees;
        }
    }
}
