﻿namespace Company.API.DTOs.ProductDtos
{
    public class CreateProductDto
    {
        public string? ProductName { get; set; }
        public string? ImageUrl { get; set; }
        public string? Description { get; set; }

        public int CategoryId { get; set; }
    }
    
}
