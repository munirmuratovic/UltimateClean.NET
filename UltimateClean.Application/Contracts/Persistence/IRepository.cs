using UltimateClean.Application.Models;
using UltimateClean.Domain.Entities;

namespace UltimateClean.Application.Contracts.Persistence;

public interface IRepository<TEntity, TSearchObject>
    where TEntity : Entity
    where TSearchObject : BaseSearchObject
{
    Task<TEntity> GetByIdAsync(uint id);
    Task<List<TEntity>> GetAllAsync();
    Task<List<TEntity>> GetAsync(TSearchObject search);
    Task<TEntity> AddAsync(TEntity entity);
    Task<TEntity> UpdateAsync(TEntity entity);
    Task DeleteAsync(uint id);
    Task<int> CountAsync(TSearchObject search);
}
