using Company.API.DTOs.SubscribeUserDtos;
using FluentValidation;

namespace Company.API.Validators.SubsrcibeUserValidator
{
    public class CreateSubsrcibeUserValidator : AbstractValidator<CreateSubscribeUserDto>
    {
        public CreateSubsrcibeUserValidator()
        {
            RuleFor(x => x.Email).NotEmpty().WithMessage("Email alanı boş bırakılamaz.").MaximumLength(50);
        }
    }
}
