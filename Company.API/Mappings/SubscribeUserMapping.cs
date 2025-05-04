using AutoMapper;
using Company.API.DTOs.SubscribeUserDtos;
using Company.API.Entities;

namespace Company.API.Mappings
{
    public class SubscribeUserMapping : Profile
    {
        public SubscribeUserMapping()
        {
            CreateMap<SubscribeUser,CreateSubscribeUserDto>().ReverseMap();
            CreateMap<SubscribeUser,UpdateSubscribeUserDto>().ReverseMap();
            CreateMap<SubscribeUser,ResultSubscribeUserDto>().ReverseMap();
        }
    }
}
