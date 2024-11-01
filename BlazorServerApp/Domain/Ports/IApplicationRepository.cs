using Domain.Entity;

namespace Domain.Ports;

public interface IApplicationRepository
{
    Task<ApplicationsEntity> GetAplicacionesRepositoryAsync();
}
