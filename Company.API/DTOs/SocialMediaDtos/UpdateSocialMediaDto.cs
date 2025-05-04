namespace Company.API.DTOs.SocialMediaDtos
{
    public class UpdateSocialMediaDto
    {
        public int SocialMediaId { get; set; }
        public string? Name { get; set; }
        public string? Icon { get; set; }
        public string? Url { get; set; }
    }
}
