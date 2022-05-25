using Core.Entities.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.UnitOfWork.Repositories.Base
{
    public abstract class Repository<TEntity,TKey> : IRepository<TEntity,TKey> where TEntity : class, IEntity
    {
        protected ApplicationDbContext _ctx { get; }
        public Repository(ApplicationDbContext ctx)
        {
            _ctx = ctx;
        }

        public virtual async Task<TEntity> FindAsync(TKey id)
        {
            return await _ctx.FindAsync<TEntity>(id);
        }
        public virtual async Task<TEntity> InsertAsync(TEntity entity)
        {
            var insert = await _ctx.Set<TEntity>().AddAsync(entity);
            return insert.Entity;
        }
        public virtual TEntity Update(TEntity entity)
        {
            _ctx.Entry(entity).State = EntityState.Modified;
            return entity;
        }

        public virtual async Task DeleteAsync(TKey id)
        {
            _ctx.Remove(await FindAsync(id));
        }

        public IQueryable<TEntity> GetAll()
        {
            return _ctx.Set<TEntity>();
        }
    }
}
