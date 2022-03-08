using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class CategoryValidation : AbstractValidator<Category>
    {
        public CategoryValidation()
        {
            RuleFor(b=>b.CategoryName).NotEmpty().WithMessage("Kategori Adı Boş Geçilemez.");
            RuleFor(b=>b.CategoryName).MaximumLength(51).WithMessage("Kategori Maksimum 50 Karakter Olabilir.");
            RuleFor(b=>b.CategoryName).MinimumLength(2).WithMessage("Kategori Minimum 3 Karakter Olabilir.");
        }
    }
}
