using Domain.Entity;
using Domain.Ports;
using Microsoft.AspNetCore.Components;

namespace Presentation.Pages;

public partial class FetchData : ComponentBase
{
    public WeatherForecastEntity[]? Forecasts { get; private set; }

    [Inject]
    private IWeatherForecastService? _forecastService { get; set; }

    public async Task LoadForecastsAsync()
    {
        await Task.Delay(2000);

        if (_forecastService != null)
        {
            Forecasts = await _forecastService.GetForecastAsync(DateOnly.FromDateTime(DateTime.Now));
        }
    }
}