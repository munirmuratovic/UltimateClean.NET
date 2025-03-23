using UltimateClean.Application;
using UltimateClean.Persistence;

namespace UltimateClean.WebApi.Configurations;

public static class ModuleRegistration
{
    public static IServiceCollection RegisterModules(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddApplicationServices(configuration);
        services.AddPersistenceServices(configuration);

        return services;
    }
}
