namespace Domain.Ports;

public interface ICounterService
{
    int GetCount();
    Task IncrementCountAsync();
}
