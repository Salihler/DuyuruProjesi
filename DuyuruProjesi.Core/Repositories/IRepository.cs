using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace DuyuruProjesi.Core.Repositories
{
    public interface IRepository<TEntity> where TEntity : class
    {
        Task<IEnumerable<TEntity>> GetAllAsync();
        Task<TEntity> GetByIdAsync(int id);
        Task AddAsync(TEntity entity);
        Task AddRangeAsync(IEnumerable<TEntity> entities);
        TEntity Update(TEntity entity);
        void Remove (TEntity entity);
        void RemoveRange (IEnumerable<TEntity> entities);
        Task<IEnumerable<TEntity>> Where(Expression<Func<TEntity,bool>> predicate);
        Task<TEntity> FindAsync(Expression<Func<TEntity,bool>> predicate);

    }
}