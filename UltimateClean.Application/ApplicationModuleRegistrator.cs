using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace UltimateClean.Application;

public static class ApplicationModuleRegistrator
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration configuration)
    {
        // add services here


        // add orchestrators here


        // add automapper here if needed

        return services;
    }
}
