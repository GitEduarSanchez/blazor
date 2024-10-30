using Domain.Ports;
using Microsoft.AspNetCore.Components;

namespace Presentation.Pages;

public partial class Counter : ComponentBase
{
    [Inject]
    private ICounterService _counterService { get; set; }

    private int counter;

    public async Task CounterAsync()
    {
        if (_counterService != null)
        {
            counter = await Task.FromResult(_counterService.GetCount());
        }
    }
    public async Task IncrementCountAsync()
    {
        if (_counterService != null)
        {
            await _counterService.IncrementCountAsync();
            counter = await Task.FromResult(_counterService.GetCount());
        }
    }
}
