using Company.API.Entities;
using FluentValidation;
using FluentValidation.AspNetCore;

namespace Company.API.Validators
{
    public class ServiceValidator : AbstractValidator<Service>
    {
        public ServiceValidator()
        {
            RuleFor(x => x.Title).NotEmpty().WithMessage("Başlık alanı boş bırakılamaz.").MaximumLength(50);
            RuleFor(x => x.DescriptionFirst).NotEmpty().WithMessage("Açıklama alanı boş bırakılamaz.").MaximumLength(200);

        }
    }
}
