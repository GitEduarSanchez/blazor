using Domain.Dto;
using Domain.Entity;
using Domain.Ports;
using Domain.Services.Applications;

namespace Application.Handle.Applications;

public class ApplicationHadle(ApplicationService _applicationService) : IApplicationService
{
    public async Task<ApplicationsDto> GetAplicacionesAsync()
    {
        ApplicationsEntity respondeEntity = await _applicationService.GetAplicacionesAsync();
        List<CategoryEntity> categoryEntity = respondeEntity.Categories;
        List<CategoryDto> categoryDto = categoryEntity.Select(c => new CategoryDto(c.Name, c.Applications.Select(a => new ApplicationDto(a.Description, a.Icon, a.Name, a.Url.ToString(), a.Subcategory)).ToList())).ToList();
        return new ApplicationsDto(Categories:categoryDto );
    }
}
