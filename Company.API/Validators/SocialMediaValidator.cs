using Company.API.Entities;
using FluentValidation;

namespace Company.API.Validators
{
    public class SocialMediaValidator : AbstractValidator<SocialMedia>
    {
        public SocialMediaValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Sosyal medya adı boş bırakılamaz.").MaximumLength(50);
            RuleFor(x => x.Url).NotEmpty().WithMessage("Sosyal medya linki boş bırakılamaz.");
            RuleFor(x => x.Icon).NotEmpty().WithMessage("Ikon boş bırakılamaz.");
        }
    }

}
