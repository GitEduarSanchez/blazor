using Domain.Entity;

namespace Domain.Ports;

public interface IWeatherForecastService
{
    Task<WeatherForecastEntity[]> GetForecastAsync(DateOnly startDate);
}
