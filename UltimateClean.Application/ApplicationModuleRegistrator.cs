using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using UltimateClean.Application.Contracts.Services;

namespace UltimateClean.Application;

public static class ApplicationModuleRegistrator
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration configuration)
    {
        // add services here
        services.AddScoped<IPostService, PostService>();

        // add orchestrators here


        // add automapper here if needed

        return services;
    }
}
