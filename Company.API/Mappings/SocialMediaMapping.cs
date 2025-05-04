using AutoMapper;
using Company.API.DTOs.SocialMediaDtos;
using Company.API.DTOs.SubscribeUserDtos;
using Company.API.Entities;
using Company.API.Mappings;

namespace Company.API.Mappings
{
    public class SocialMediaMapping : Profile
    {
        public SocialMediaMapping()
        {
            CreateMap<SocialMedia, CreateSocialMediaDto>().ReverseMap();
            CreateMap<SocialMedia, UpdateSocialMediaDto>().ReverseMap();
            CreateMap<SocialMedia, ResultSocialMediaDto>().ReverseMap();
        }
    }
}
