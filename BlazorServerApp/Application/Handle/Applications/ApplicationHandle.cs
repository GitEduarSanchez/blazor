using AutoMapper;
using Domain.Dto;
using Domain.Entity;
using Domain.Ports;
using Domain.Services.Applications;

namespace Application.Handle.Applications;

public class ApplicationHandle(ApplicationService _applicationService, IMapper _mapper) : IApplicationService
{
    public async Task<ApplicationsDto> GetAplicacionesAsync()
    {
        ApplicationsEntity respondeEntity = await _applicationService.GetAplicacionesAsync();
        return _mapper.Map<ApplicationsDto>(respondeEntity);
    }
}
