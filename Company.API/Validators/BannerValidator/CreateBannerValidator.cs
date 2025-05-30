﻿using Company.API.DTOs.BannerDtos;
using FluentValidation;

namespace Company.API.Validators.BannerValidator
{
    public class CreateBannerValidator : AbstractValidator<CreateBannerDto>
    {
        public CreateBannerValidator()
        {
            RuleFor(x => x.Title).NotEmpty().WithMessage("Başlık boş bırakılamaz").MaximumLength(50);
            RuleFor(x => x.Description).NotEmpty().WithMessage("Açıklama boş bırakılamaz").MaximumLength(200);
            RuleFor(x => x.ImageUrl).NotEmpty().WithMessage("Görsel boş bırakılamaz");
        }
    }
}
