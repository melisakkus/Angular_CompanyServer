using Company.API.DTOs.CategoryDtos;
using FluentValidation;

namespace Company.API.Validators.CategoryValidator
{
    public class CreateCategoryValidator : AbstractValidator<CreateCategoryDto>
    {
        public CreateCategoryValidator()
        {
            RuleFor(x => x.CategoryName).NotEmpty().WithMessage("Kategori ismi boş bırakılamaz.").
                                                     MaximumLength(50);
        }
    }
}
