using Company.API.DTOs.SocialMediaDtos;
using FluentValidation;

namespace Company.API.Validators.SocialMediaValidator
{
    public class CreateSocialMediaValidator : AbstractValidator<CreateSocialMediaDto>
    {
        public CreateSocialMediaValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Sosyal medya adı boş bırakılamaz.").MaximumLength(50);
            RuleFor(x => x.Url).NotEmpty().WithMessage("Sosyal medya linki boş bırakılamaz.");
            RuleFor(x => x.Icon).NotEmpty().WithMessage("Ikon boş bırakılamaz.");
        }
    }}
