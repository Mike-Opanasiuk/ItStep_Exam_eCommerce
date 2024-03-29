﻿using Core.Entities.Abstract;

namespace Infrastructure.Repositories;

public interface IRepository<TEntity> where TEntity : IEntity
{
    IQueryable<TEntity> GetAll();
    Task<TEntity> FindAsync(Guid id);
    Task<TEntity> InsertAsync(TEntity entity);
    TEntity Update(TEntity entity);
    Task DeleteAsync(Guid id);
}