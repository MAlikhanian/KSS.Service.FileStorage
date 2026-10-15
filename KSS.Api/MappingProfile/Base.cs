using AutoMapper;
using KSS.Entity;
using KSS.Dto;

namespace KSS.Api.MappingProfile
{
    public class BaseMappingProfile : Profile
    {
        public BaseMappingProfile()
        {
            CreateMap<StoredFile, StoredFileDto>().ReverseMap();
            CreateMap<StoredFileAddDto, StoredFile>();
        }
    }
}
