using Domain.Ports;

namespace Infraestructure.Adapter.Counter;

public class CounterService : ICounterService
{
    private int _count;

    public int GetCount() => _count;

    public Task IncrementCountAsync()
    {
        _count++;
        return Task.CompletedTask;
    }
}
