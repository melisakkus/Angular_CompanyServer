using Company.API.Entities;
using FluentValidation;

namespace Company.API.Validators
{
    public class BrandValidator : AbstractValidator<Brand>
    {
        public BrandValidator()
        {
            RuleFor(x => x.ImageUrl)
                .NotEmpty().WithMessage("Resim linki boş bırakılamaz.");
              
        }
    }
}
