using Company.API.Entities;
using FluentValidation;

namespace Company.API.Validators
{
    public class BannerValidator : AbstractValidator<Banner>
    {
        public BannerValidator() 
        {
            RuleFor(x=>x.Title).NotEmpty().WithMessage("Başlık boş bırakılamaz").MaximumLength(50);
            RuleFor(x=>x.Description).NotEmpty().WithMessage("Açıklama boş bırakılamaz").MaximumLength(200);
        }
    }
}
