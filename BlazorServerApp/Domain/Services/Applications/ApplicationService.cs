using Domain.Entity;
using Domain.Ports;

namespace Domain.Services.Applications;

public class ApplicationService(IApplicationRepository applicationRepository)
{
    public async Task<ApplicationsEntity> GetAplicacionesAsync()
    {
        return await applicationRepository.GetAplicacionesRepositoryAsync();
    }
}
