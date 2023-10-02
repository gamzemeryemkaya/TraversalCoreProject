using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Validation_Rule
{
    public class AboutValidator: AbstractValidator<About>
    {
        public AboutValidator()
        { 
        RuleFor(x => x.Description).NotEmpty().WithMessage("Açıklma kısmı  boş geçilemez");
        RuleFor(x => x.Image1).NotEmpty().WithMessage("Görsel alanı boş geçilemez");
        RuleFor(x => x.Description).MinimumLength(5).WithMessage("Açıklama alanı en az 5 karakterden oluşmak zorundadır");
        RuleFor(x => x.Description).MaximumLength(100).WithMessage("Açıklama en fazla 100 karakterden oluşmak zorundadır");
        }
    }
}
