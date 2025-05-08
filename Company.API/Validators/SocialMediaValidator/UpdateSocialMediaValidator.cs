using Company.API.DTOs.SocialMediaDtos;
using FluentValidation;

namespace Company.API.Validators.SocialMediaValidator
{
    public class UpdateSocialMediaValidator : AbstractValidator<UpdateSocialMediaDto>
    {
        public UpdateSocialMediaValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Sosyal medya adı boş bırakılamaz.").MaximumLength(50);
            RuleFor(x => x.Url).NotEmpty().WithMessage("Sosyal medya linki boş bırakılamaz.");
            RuleFor(x => x.Icon).NotEmpty().WithMessage("Ikon boş bırakılamaz.");
        }
    }    
}
