using AutoMapper;
using Company.API.DTOs.BrandDtos;
using Company.API.Entities;

namespace Company.API.Mappings
{
    public class BrandMapping : Profile
    {
        public BrandMapping() 
        {
            CreateMap<Brand,ResultBrandDto>().ReverseMap();
            CreateMap<Brand,UpdateBrandDto>().ReverseMap();
            CreateMap<Brand,CreateBrandDto>().ReverseMap();
        }
    }
}
