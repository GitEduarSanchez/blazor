using AutoMapper;
using Domain.Dto;
using Domain.Entity;

namespace Application.Mapper;

public class ApplicationsMapper : Profile
{
    protected ApplicationsMapper()
    {
        CreateMap<ApplicationsEntity, ApplicationsDto>();
    }
}
