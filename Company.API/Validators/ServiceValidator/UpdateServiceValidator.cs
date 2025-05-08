using Company.API.DTOs.ServiceDtos;
using FluentValidation;

namespace Company.API.Validators.ServiceValidator
{
    public class UpdateServiceValidator : AbstractValidator<UpdateServiceDto>
    {
        public UpdateServiceValidator() 
        {
            RuleFor(x => x.Title).NotEmpty().WithMessage("Başlık alanı boş bırakılamaz.").MaximumLength(50);
            RuleFor(x => x.Description).NotEmpty().WithMessage("Açıklama alanı boş bırakılamaz.").MaximumLength(200);
        }
    }
}
