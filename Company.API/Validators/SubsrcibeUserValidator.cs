using Company.API.Entities;
using FluentValidation;

namespace Company.API.Validators
{
    public class SubsrcibeUserValidator : AbstractValidator<SubscribeUser>
    {
        public SubsrcibeUserValidator() 
        {
            RuleFor(x => x.Email).NotEmpty().WithMessage("Email alanı boş bırakılamaz.").MaximumLength(50);
        }
    }
}
