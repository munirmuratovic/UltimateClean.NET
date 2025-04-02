using Microsoft.EntityFrameworkCore;
using UltimateClean.Domain.Entities;
using UltimateClean.Persistence.Extensions;

namespace UltimateClean.Persistence.Data;

public class MyDbContext : DbContext
{
    public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
    {
    }

    // Define DbSets for your entities
    public DbSet<Post> Posts { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsForEntitiesInContext();
        base.OnModelCreating(modelBuilder);
    }
}
