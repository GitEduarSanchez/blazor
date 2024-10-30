using Domain.Entity;

namespace Domain.Ports;

public interface IApplicationService
{
    Task<ApplicationsEntity> GetAplicacionesAsync();
}
