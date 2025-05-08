using Company.API.DTOs.SubscribeUserDtos;
using Company.API.Entities;
using FluentValidation;

namespace Company.API.Validators.SubsrcibeUserValidator
{
    public class UpdateSubsrcibeUserValidator : AbstractValidator<UpdateSubscribeUserDto>
    {
        public UpdateSubsrcibeUserValidator()
        {
            RuleFor(x => x.Email).NotEmpty().WithMessage("Email alanı boş bırakılamaz.").MaximumLength(50);
        }
    }    
}
