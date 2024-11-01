using AutoMapper;
using Domain.Dto;
using Domain.Entity;

namespace Application.Mapper;

public class ApplicationsMapper : Profile
{
    public ApplicationsMapper()
    {
        CreateMap<ApplicationEntity, ApplicationDto>()
                .ForMember(dest => dest.SubCategory, opt => opt.MapFrom(src => src.Subcategory))
                .ForMember(dest => dest.Url, opt => opt.MapFrom(src => src.Url.ToString()));

        CreateMap<CategoryEntity, CategoryDto>()
            .ForMember(dest => dest.Applications, opt => opt.MapFrom(src => src.Applications));

        CreateMap<ApplicationsEntity, ApplicationsDto>()
            .ForMember(dest => dest.Categories, opt => opt.MapFrom(src => src.Categories));
    }
}
