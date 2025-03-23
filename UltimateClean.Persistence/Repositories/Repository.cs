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

    public Task<TEntity> AddAsync(TEntity entity)
    {
        throw new NotImplementedException();
    }

    public Task<int> CountAsync(TSearchObject search)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<List<TEntity>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<List<TEntity>> GetAsync(TSearchObject search)
    {
        throw new NotImplementedException();
    }

    public Task<TEntity> GetByIdAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<TEntity> UpdateAsync(TEntity entity)
    {
        throw new NotImplementedException();
    }
}
