using Microsoft.EntityFrameworkCore;
using UltimateClean.Application.Contracts.Persistence;
using UltimateClean.Persistence.Data;
using UltimateClean.Persistence.Repositories;

namespace UltimateClean.Persistence;

public class UnitOfWork(MyDbContext context) : IUnitOfWork, IDisposable
{
    public IPostRepository PostRepository => new PostRepository(context);

    public Task<int> SaveChangesAsync()
    {
        try
        {
            return context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException ex)
        {
            // Handle concurrency exception
            throw new Exception("Concurrency error occurred while saving changes.", ex);
        }
        catch (DbUpdateException ex)
        {
            // Handle update exception
            throw new Exception("An error occurred while updating the database.", ex);
        }
        catch (Exception ex)
        {
            // Handle other exceptions
            throw new Exception("An error occurred while saving changes.", ex);
        }
    }

    public void Dispose()
    {
        context.Dispose();
        GC.SuppressFinalize(this);
    }
}
