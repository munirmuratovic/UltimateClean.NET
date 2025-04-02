using System;
using System.Net;
using System.Reflection;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using UltimateClean.Persistence.Data;

namespace UltimateClean.Persistence.Extensions;

public static class DbExtensions
{
    public static void ApplyConfigurationsForEntitiesInContext(this ModelBuilder modelBuilder)
    {
        var types = modelBuilder.Model.GetEntityTypes().Select(x => x.ClrType).ToHashSet();

        modelBuilder.ApplyConfigurationsFromAssembly(
            Assembly.GetExecutingAssembly(),
            x => x.GetInterfaces().Any(i =>
                i.IsGenericType &&
                i.GetGenericTypeDefinition() == typeof(IEntityTypeConfiguration<>) &&
                types.Contains(i.GenericTypeArguments[0])
            )
        );
    }

    public static IHost Seed(this IHost host)
    {
        using var scope = host.Services.CreateScope();
        var services = scope.ServiceProvider;

        try
        {
            var context = services.GetRequiredService<MyDbContext>();
            context.Database.Migrate();
            // Seed data here if needed
        }
        catch (Exception ex)
        {
            var logger = services.GetRequiredService<ILogger<IHost>>();
            logger.LogError(ex, "An error occurred while seeding the database.");
        }

        return host;
    }
}
