using DtoLayer.Dtos.AppUserDtos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules.AppUserValidationRules
{
    public class AppUserRegisterValidator : AbstractValidator<AppUserRegisterDto>
    {

        public AppUserRegisterValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Adı boş geçilemez").MaximumLength(30).WithMessage("En fazla 30 karakter girebilirsiniz").MinimumLength(2).WithMessage("En az 2 karakter giriniz");
            RuleFor(x => x.Surname).NotEmpty().WithMessage("Soyadı boş geçilemez");
            RuleFor(x => x.Username).NotEmpty().WithMessage("Kullanıcı adı boş geçilemez");
            RuleFor(x => x.Email).NotEmpty().WithMessage("Mail alanı boş geçilemez").EmailAddress().WithMessage("Geçerli bir mail adresi giriniz");
            RuleFor(x => x.Password).NotEmpty().WithMessage("Şifre boş geçilemez");
            RuleFor(x => x.ConfirmPassword).NotEmpty().WithMessage("Şifre tekrarı boş geçilemez").Equal(y => y.Password).WithMessage("Parolalarınız eşleşmemektedir");
        }
    }
}
