using Application.Handle.Applications;
using Domain.Ports;
using Domain.Services.Applications;
using Microsoft.Extensions.DependencyInjection;

namespace Application.DependencyInjectionService;

public static class DependencyInjectionService
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddScoped<IApplicationService, ApplicationHandle>();
        services.AddScoped<ApplicationService>();
        return services;
    }
}
