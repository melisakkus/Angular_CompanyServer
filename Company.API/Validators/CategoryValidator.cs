using Company.API.Entities;
using FluentValidation;

namespace Company.API.Validators
{
    public class CategoryValidator : AbstractValidator<Category>
    {
        public CategoryValidator()
        {
            RuleFor(x => x.CategoryName).NotEmpty().WithMessage("Kategori ismi boş bırakılamaz.").
                                         MaximumLength(50);
        }
    }

}
