﻿namespace Company.API.DTOs.BannerDtos
{
    public class ResultBannerDto
    {
        public int BannerId { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? ImageUrl { get; set; }
    }
}
