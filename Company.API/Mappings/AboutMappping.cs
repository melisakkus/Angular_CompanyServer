using AutoMapper;
using Company.API.DTOs.AboutDtos;
using Company.API.Entities;

namespace Company.API.Mappings
{
    public class AboutMappping : Profile
    {
        public AboutMappping()
        {
            CreateMap<About, ResultAboutDto>().ReverseMap();
            CreateMap<About, UpdateAboutDto>().ReverseMap();
            CreateMap<About, CreateAboutDto>().ReverseMap();
        }
    }
}
