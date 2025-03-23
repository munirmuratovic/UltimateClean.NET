using UltimateClean.Application.Models;
using UltimateClean.Domain.Entities;

namespace UltimateClean.Application.Contracts.Persistence;

public interface IPostRepository : IRepository<Post, BaseSearchObject>
{

}
