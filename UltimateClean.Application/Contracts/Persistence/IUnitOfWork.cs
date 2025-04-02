namespace UltimateClean.Application.Contracts.Persistence;

public interface IUnitOfWork
{
    IPostRepository PostRepository { get; }
    
    Task<int> SaveChangesAsync();
}
