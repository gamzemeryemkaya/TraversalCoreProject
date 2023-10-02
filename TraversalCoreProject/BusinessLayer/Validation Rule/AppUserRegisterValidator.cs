using DTOLayer.DTOs.AppUserDTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Validation_Rule
{
    public class AppUserRegisterValidator : AbstractValidator<AppUserRegisterDTOs>
    {
        public AppUserRegisterValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Lütfen ad alanını doldurunuz");
            RuleFor(x => x.Surname).NotEmpty().WithMessage("Lütfen Soyad alanını doldurunuz");
            RuleFor(x => x.Mail).NotEmpty().WithMessage("Mail alanı boş geçilemez");
            RuleFor(x => x.Username).NotEmpty().WithMessage("Lütfen Kullanıcı adı alanını doldurunuz");
            RuleFor(x => x.Password).NotEmpty().WithMessage("Şifre alanı boş geçilemez");
            RuleFor(x => x.ConfirmPassword).NotEmpty().WithMessage("Şifre doğrulama alanı boş geçilemez");
            RuleFor(x => x.Username).MinimumLength(5).WithMessage("Kullanıcı adı 5 karakterden az olamaz");
            RuleFor(x => x.Username).MaximumLength(20).WithMessage(" Kullanıcı adı en fazla 20 karakter olmalıdır");
            RuleFor(x => x.Password).Equal(y => y.ConfirmPassword).WithMessage("Şifreler aynı değil");
        }
    }
}
