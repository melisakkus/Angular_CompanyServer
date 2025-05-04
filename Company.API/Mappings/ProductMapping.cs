using AutoMapper;
using Company.API.DTOs.ProductDtos;
using Company.API.Entities;

namespace Company.API.Mappings
{
    public class ProductMapping : Profile
    {
        public ProductMapping()
        {
            CreateMap<Product, CreateProductDto>().ReverseMap();
            CreateMap<Product, UpdateProductDto>().ReverseMap();
            CreateMap<Product, ResultProductDto>().ReverseMap();
        }
    }
}
