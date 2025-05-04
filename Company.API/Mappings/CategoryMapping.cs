using AutoMapper;
using Company.API.DTOs.CategoryDtos;
using Company.API.Entities;

namespace Company.API.Mappings
{
    public class CategoryMapping : Profile
    {
        public CategoryMapping()
        {
            CreateMap<Category, CreateCategoryDto>().ReverseMap();
            CreateMap<Category, UpdateCategoryDto>().ReverseMap();
            CreateMap<Category, ResultCategoryDto>().ReverseMap();
        }
    }

}
