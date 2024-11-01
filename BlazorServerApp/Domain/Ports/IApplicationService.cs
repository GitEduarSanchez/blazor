using Domain.Dto;

namespace Domain.Ports;

public interface IApplicationService
{
    Task<ApplicationsDto> GetAplicacionesAsync();
}
