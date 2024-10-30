using Domain.Entity;
using Domain.Ports;
using Microsoft.AspNetCore.Components;

namespace Presentation.Pages;

public partial class Applications : ComponentBase
{
    public ApplicationsEntity Application { get; set; }

    [Inject]
    public IApplicationService ApplicationService { get; set; }

    public async Task GetApplicationsAsync()
    {
        Application = await ApplicationService.GetAplicacionesAsync();
    }
}
