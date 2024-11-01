using Domain.Dto;
using Domain.Ports;
using Microsoft.AspNetCore.Components;

namespace Presentation.Shared;

public partial class NavMenu : ComponentBase
{
    public ApplicationsDto Application { get; set; }

    [Inject]
    public IApplicationService ApplicationService { get; set; }

    public async Task GetApplicationsAsync()
    {
        Application = await ApplicationService.GetAplicacionesAsync();
    }
}
