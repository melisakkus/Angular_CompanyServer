using Company.API.DTOs.ProductDtos;
using FluentValidation;

namespace Company.API.Validators.ProductValidator
{
    public class UpdateProductValidator : AbstractValidator<UpdateProductDto>
    {
        public UpdateProductValidator()
        {
            RuleFor(x => x.ProductName).NotEmpty().WithMessage("Ürün adı boş bırakılamaz.")
                                       .MinimumLength(3).WithMessage("Ürün adı en az 3 karakter olmalıdır.")
                                       .MaximumLength(100).WithMessage("Ürün adı en fazla 100 karakter olmalıdır.");

            RuleFor(x => x.ImageUrl).NotEmpty().WithMessage("Ürün görsel url boş bırakılamaz");
            RuleFor(x => x.Description).NotEmpty().WithMessage("Ürün açıklaması boş bırakılamaz");
            RuleFor(x => x.CategoryId).NotEmpty().WithMessage("Ürün kategorisi boş bırakılamaz");
        }
    }
}
