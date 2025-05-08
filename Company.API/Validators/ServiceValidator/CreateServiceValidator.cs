using Company.API.DTOs.ServiceDtos;
using FluentValidation;

namespace Company.API.Validators.ServiceValidator
{
    public class CreateServiceValidator : AbstractValidator<CreateServiceDto>
    {
        public CreateServiceValidator() 
        {
            RuleFor(x => x.Title).NotEmpty().WithMessage("Başlık alanı boş bırakılamaz.").MaximumLength(50);
            RuleFor(x => x.Description).NotEmpty().WithMessage("Açıklama alanı boş bırakılamaz.").MaximumLength(200);
            RuleFor(x => x.Icon).NotEmpty().WithMessage("Icon alanı boş bırakılamaz.").MaximumLength(200);
        }
    }
}
