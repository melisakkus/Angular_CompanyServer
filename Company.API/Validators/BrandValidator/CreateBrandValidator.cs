using Company.API.DTOs.BrandDtos;
using FluentValidation;

namespace Company.API.Validators.BrandValidator
{
    public class CreateBrandValidator : AbstractValidator<CreateBrandDto>
    {
        public CreateBrandValidator()
        {
            RuleFor(x => x.ImageUrl)
                .NotEmpty().WithMessage("Resim linki boş bırakılamaz.");
        }
    }
}
