using Company.API.Entities;
using FluentValidation;

namespace Company.API.Validators
{
    public class AboutValidator : AbstractValidator<About>
    {
        public AboutValidator() 
        {
            RuleFor(x=>x.Title).NotEmpty().WithMessage("Başlık alanı boş bırakılamaz.").MaximumLength(50);
            RuleFor(x=>x.DescriptionFirst).NotEmpty().WithMessage("Açıklama alanı boş bırakılamaz.");
            RuleFor(x=>x.DescriptionLast).NotEmpty().WithMessage("Açıklama alanı boş bırakılamaz.");
            RuleFor(x=>x.Item1).NotEmpty().WithMessage("Bu alan boş bırakılamaz.").MaximumLength(150);
            RuleFor(x=>x.Item2).NotEmpty().WithMessage("Bu alan boş bırakılamaz.").MaximumLength(150);
            RuleFor(x=>x.Item3).NotEmpty().WithMessage("Bu alan boş bırakılamaz.").MaximumLength(150);
            
        }
    }
}
