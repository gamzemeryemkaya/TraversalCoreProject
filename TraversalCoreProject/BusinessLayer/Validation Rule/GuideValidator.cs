using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Validation_Rule
{
    public class GuideValidator : AbstractValidator<Guide>
    {
        public GuideValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Lütfen bir ad giriniz");
            RuleFor(x => x.Description).NotEmpty().WithMessage("Lütfen açıklama giriniz");
            RuleFor(x => x.Image).NotEmpty().WithMessage("Lütfen rehberin görselini giriniz");
            RuleFor(x => x.Name).MaximumLength(30).WithMessage("Lütfen 30 karakterden daha kısa bir isim giriniz");
            RuleFor(x => x.Name).MinimumLength(7).WithMessage("lütfen 8 karakterden daha uzun bir isim giriniz");
        }
    }
}
