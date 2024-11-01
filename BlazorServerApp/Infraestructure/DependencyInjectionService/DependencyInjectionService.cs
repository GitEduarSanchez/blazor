using Domain.Ports;
using Infraestructure.Adapter.Aplications;
using Microsoft.Extensions.DependencyInjection;

namespace Infraestructure.DependencyInjectionService;

public static class DependencyInjectionService
{
    public static IServiceCollection AddInfraestruture(this IServiceCollection services)
    {
        services.AddTransient<IApplicationRepository, ApplicationsService>();
        return services;
    }
}
