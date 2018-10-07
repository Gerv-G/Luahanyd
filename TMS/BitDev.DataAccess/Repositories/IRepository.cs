using System.Collections.Generic;

namespace BitDev.DataAccess.Repositories
{
    public interface IRepository<TEntity, TPersistentEntity> 
        where TEntity : class
        where TPersistentEntity : class
    {
        void Add(TEntity entity);

        void Update(TEntity entity);

        void Delete(TEntity entity);

        TEntity Get(int id);

        IEnumerable<TEntity> GetAll();
    }
}
