using Microsoft.EntityFrameworkCore;
using UltimateClean.Application.Contracts.Persistence;
using UltimateClean.Application.Models;
using UltimateClean.Domain.Entities;

namespace UltimateClean.Persistence.Repositories;

public class Repository<TEntity, TSearchObject>(DbContext context) : IRepository<TEntity, TSearchObject>
    where TEntity : Entity
    where TSearchObject : BaseSearchObject, new()
{
    private readonly DbSet<TEntity> _entities = context.Set<TEntity>();

    public virtual int DefaultPageSize => 10;
    public virtual int DefaultPageNumber => 1;
    public virtual int DefaultPageCount => 1;
    public virtual int DefaultTotalCount => 0;

    public Task<TEntity> AddAsync(TEntity entity)
    {
        _entities.Add(entity);
        return Task.FromResult(entity);
    }

    public Task<int> CountAsync(TSearchObject search)
    {
        var query = _entities.AsQueryable();

        if (search != null)
        {
            // Apply search filters here
        }

        return Task.FromResult(query.Count());
    }

    public Task DeleteAsync(uint id)
    {
        var entity = _entities.Find(id);
        if (entity != null)
        {
            _entities.Remove(entity);
        }
        return Task.CompletedTask;
    }

    public Task<List<TEntity>> GetAllAsync()
    {
        return Task.FromResult(_entities.ToList());
    }

    public Task<List<TEntity>> GetAsync(TSearchObject search)
    {
        var query = _entities.AsQueryable();

        if (search != null)
        {
            // Apply search filters here
        }

        return Task.FromResult(query.ToList());
    }

    public Task<TEntity> GetByIdAsync(uint id)
    {
        var entity = _entities.Find(id);
        if (entity == null)
        {
            throw new KeyNotFoundException($"Entity with ID {id} was not found.");
        }
        return Task.FromResult(entity);
    }

    public Task<TEntity> UpdateAsync(TEntity entity)
    {
        var existingEntity = _entities.Find(entity.Id);
        if (existingEntity == null)
        {
            throw new KeyNotFoundException($"Entity with ID {entity.Id} was not found.");
        }

        context.Entry(existingEntity).CurrentValues.SetValues(entity);
        return Task.FromResult(existingEntity);
    }
}
