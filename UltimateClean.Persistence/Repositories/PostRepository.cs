using UltimateClean.Application.Contracts.Persistence;
using UltimateClean.Application.Models;
using UltimateClean.Domain.Entities;
using UltimateClean.Persistence.Data;

namespace UltimateClean.Persistence.Repositories;

internal class PostRepository(MyDbContext context) : Repository<Post, BaseSearchObject>(context), IPostRepository
{

}
