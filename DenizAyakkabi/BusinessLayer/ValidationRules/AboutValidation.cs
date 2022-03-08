using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
   public class AboutValidation: AbstractValidator<About>
    {
        public AboutValidation()
        {
            RuleFor(b => b.Description).NotEmpty().WithMessage("Açıklama Boş Geçilemez.");
            RuleFor(b => b.Description2).NotEmpty().WithMessage("Kategori Maksimum 50 Karakter Olabilir.");
            RuleFor(b => b.Title1).NotEmpty().WithMessage("Başlık Minimum 3 Karakter Olabilir.");
            RuleFor(b => b.Title2).NotEmpty().WithMessage("Başlık Minimum 3 Karakter Olabilir.");
            RuleFor(b => b.Title3).NotEmpty().WithMessage("Başlık Minimum 3 Karakter Olabilir.");
        }
    }
}
