using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace DuyuruProjesi.Core.Services
{
    public interface IService<TEntity> where TEntity : class
    {
        Task<IEnumerable<TEntity>> GetAllAsync();
        Task<TEntity> GetByIdAsync(int id);
        Task<TEntity> AddAsync(TEntity entity);
        Task<IEnumerable<TEntity>> AddRangeAsync(IEnumerable<TEntity> entities);
        void Update(TEntity entity);
        void Remove (TEntity entity);
        Task<IEnumerable<TEntity>> Where(Expression<Func<TEntity,bool>> predicate);
        Task<TEntity> FindAsync(Expression<Func<TEntity,bool>> predicate);
    }
}