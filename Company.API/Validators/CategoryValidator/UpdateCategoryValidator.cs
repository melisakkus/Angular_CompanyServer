using Company.API.DTOs.CategoryDtos;
using FluentValidation;

namespace Company.API.Validators.CategoryValidator
{
    public class UpdateCategoryValidator : AbstractValidator<UpdateCategoryDto>
    {
        public UpdateCategoryValidator()
        {
            RuleFor(x => x.CategoryName).NotEmpty().WithMessage("Kategori ismi boş bırakılamaz.").
                                         MaximumLength(50);
        }
    }
}
