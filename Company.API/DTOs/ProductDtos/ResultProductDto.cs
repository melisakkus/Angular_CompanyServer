using Company.API.Entities;

namespace Company.API.DTOs.ProductDtos
{
    public class ResultProductDto
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }

        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
    }
}
