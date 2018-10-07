
namespace BitDev.PersistentEntities
{
    public abstract class PersistentEntity<TEntity> where TEntity : class 
    {
        public abstract TEntity ToEntity();
    }
}
