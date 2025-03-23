using UltimateClean.Application.Contracts.Persistence;
using UltimateClean.Persistence.Data;
using UltimateClean.Persistence.Repositories;

namespace UltimateClean.Persistence;

public class UnitOfWork(MyDbContext context) : IUnitOfWork
{
    public IPostRepository PostRepository => new PostRepository(context);
}
