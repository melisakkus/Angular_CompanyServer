using Company.API.DTOs.BrandDtos;
using FluentValidation;

namespace Company.API.Validators.BrandValidator
{
    public class UpdateBrandValidator : AbstractValidator<UpdateBrandDto>
    {
        public UpdateBrandValidator() 
        {
            RuleFor(x => x.ImageUrl)
        .NotEmpty().WithMessage("Resim linki boş bırakılamaz.");
        }
    }
}
