namespace Company.API.DTOs.ServiceDtos
{
    public class UpdateServiceDto
    {
        public int ServiceId { get; set; }
        public string? Title { get; set; }
        public string? DescriptionFirst { get; set; }
    }
}
