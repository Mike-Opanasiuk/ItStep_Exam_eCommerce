using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.UnitOfWork.Repositories.Base
{
    public interface IRepository<TEntity, TKey> where TEntity:IEntity
    {
        IQueryable<TEntity> GetAll();
        Task<TEntity> FindAsync(TKey id);
        Task<TEntity> InsertAsync(TEntity entity);
        TEntity Update(TEntity entity);
        Task DeleteAsync(TKey id);
    }
}
