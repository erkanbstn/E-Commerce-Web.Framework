using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class ProductValidation : AbstractValidator<Product>
    {
        public ProductValidation()
        {
            RuleFor(b => b.Title).NotEmpty().WithMessage("Ürün İsmi Boş Geçilemez");
            RuleFor(b => b.Price).NotEmpty().WithMessage("Ürün Fiyatı Boş Geçilemez");
            RuleFor(b => b.Quantity).NotEmpty().WithMessage("Ürün Adeti Boş Geçilemez");
            RuleFor(b => b.Description).NotEmpty().WithMessage("Ürün Açıklaması Boş Geçilemez");
            RuleFor(b => b.Title).MaximumLength(50).WithMessage("Ürün Maximum 50 Karakter Olabilir");
            RuleFor(b => b.Title).MinimumLength(2).WithMessage("Ürün Minimum 3 Karakter Olabilir");
        }
    }
}
