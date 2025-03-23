using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using UltimateClean.Application.Contracts.Persistence;
using UltimateClean.Persistence.Data;

namespace UltimateClean.Persistence;

public static class PersistenceModuleRegistrator
{
    public static IServiceCollection AddPersistenceServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddScoped<IUnitOfWork, UnitOfWork>();

        var postgresDbConnectionString = configuration.GetConnectionString("DefaultConnection");
        services.AddDbContext<MyDbContext>(options => options.UseNpgsql(postgresDbConnectionString));

        return services;
    }
}
