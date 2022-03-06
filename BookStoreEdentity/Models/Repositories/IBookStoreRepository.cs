using System.Collections.Generic;

namespace BookStoreEdentity.Models.Repositories
{
    public interface IBookStoreRepository<TEntity>
    {
        IList<TEntity> List();
        TEntity Find(int id);
        void Add(TEntity entity);
        void Update(TEntity entity,int Id);
        void Delete(int id);
    }
}
