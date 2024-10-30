using Domain.Ports;
using Infraestructure.Adapter.WeatherForecast;
using Microsoft.Extensions.DependencyInjection;

namespace Infraestructure.DependencyInjectionService;

public static class DependencyInjectionService
{
    public static IServiceCollection AddInfraestruture(this IServiceCollection services)
    {
       
        services.AddTransient<IWeatherForecastService, WeatherForecastService>();

        return services;
    }
}
