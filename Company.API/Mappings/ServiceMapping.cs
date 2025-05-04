using AutoMapper;
using Company.API.DTOs.ServiceDtos;
using Company.API.Entities;

namespace Company.API.Mappings
{
    public class ServiceMapping : Profile
    {
        public ServiceMapping()
        {
            CreateMap<Service, CreateServiceDto>().ReverseMap();
            CreateMap<Service, UpdateServiceDto>().ReverseMap();
            CreateMap<Service, ResultServiceDto>().ReverseMap();
        }
    }   
}
