using Core.Entities.Abstract;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.UnitOfWork.Repositories;

public class Repository<TEntity> : IRepository<TEntity> where TEntity : class, IEntity
{
    protected ApplicationDbContext _context { get; }
    public Repository(ApplicationDbContext context)
    {
        _context = context;
    }

    public virtual async Task<TEntity> FindAsync(Guid id)
    {
        return await _context.FindAsync<TEntity>(id);
    }
    public virtual async Task<TEntity> InsertAsync(TEntity entity)
    {
        var insert = await _context.Set<TEntity>().AddAsync(entity);
        return insert.Entity;
    }
    public virtual TEntity Update(TEntity entity)
    {
        _context.Entry(entity).State = EntityState.Modified;
        return entity;
    }

    public virtual async Task DeleteAsync(Guid id)
    {
        _context.Remove(await FindAsync(id));
    }

    public IQueryable<TEntity> GetAll()
    {
        return _context.Set<TEntity>();
    }
}