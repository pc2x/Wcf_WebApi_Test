

using AutoMapper;
using pc2x.Application.Core.DomainModels;
using pc2x.Application.Repositories.EntityFramework.Entities;

namespace pc2x.Application.Repositories.Mappers
{
    public static class AutoMapperConfiguration
    {
        public static void Configure()
        {
            Mapper.Initialize(x =>
                x.AddProfile<MappingProfile>());
        }
    }

    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<PaisEntity, PaisModel>();
        }
    }
}
