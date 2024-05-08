using EasyCash_proje_Edenyity.DtoLayer.Dtos.AppUserDtos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EasyCash_proje_Edenyity.BusinessLayer.ValidationRules.AppUserValidationRules
{
    public class AppUserRegisterValidator:AbstractValidator<AppUserRegisterDto>
    {
        public AppUserRegisterValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Ad bos ola bilmez!");
            RuleFor(x => x.SurName).NotEmpty().WithMessage("Soyad bos ola bilmez!");
            RuleFor(x => x.UserName).NotEmpty().WithMessage("Istifadeci adi bos ola bilmez!");
            RuleFor(x => x.Email).NotEmpty().WithMessage("Email bos ola bilmez!");
            RuleFor(x => x.PassWord).NotEmpty().WithMessage("Sifre bos ola bilmez!");
            RuleFor(x => x.ConfirmPassWord).NotEmpty().WithMessage("Tekrar sifre bos ola bilmez!");
            RuleFor(x => x.Name).MaximumLength(30).WithMessage("en coxu 30 herf olmalidi");
            RuleFor(x => x.Name).MinimumLength(3).WithMessage("En azi 3 herf olmalidi");
            RuleFor(x => x.ConfirmPassWord).Equal(x => x.PassWord).WithMessage("parollariniz eyni deyil");
            RuleFor(x => x.Email).EmailAddress().WithMessage("Zehmet olmasa islek Email qeyd edin");
        }
    }
}
