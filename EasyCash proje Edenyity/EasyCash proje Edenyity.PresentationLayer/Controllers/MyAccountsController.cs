using EasyCash_proje_Edenyity.DtoLayer.Dtos.AppUserDtos;
using EasyCash_proje_Edenyity.EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace EasyCash_proje_Edenyity.PresentationLayer.Controllers
{
    [Authorize]
    public class MyAccountsController : Controller
    {
        
        private readonly UserManager<AppUser> _userManager;
        public MyAccountsController(UserManager<AppUser> userManager)
        {
                _userManager = userManager;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var Values = await _userManager.FindByNameAsync(User.Identity.Name);
            AppUserEditDto appUserEditDto = new AppUserEditDto();
            appUserEditDto.Name = Values.Name;
            appUserEditDto.SurName = Values.SurName;
            appUserEditDto.District = Values.District;
            appUserEditDto.City = Values.City;
            appUserEditDto.Email = Values.Email;
            appUserEditDto.PhoneNumber = Values.PhoneNumber;
            appUserEditDto.ImageUrl = Values.ImageUrl;

            return View(appUserEditDto);
        }

        [HttpPost]
        public async Task<IActionResult> index(AppUserEditDto appUserEditDto) 
        {
            if (appUserEditDto.Pasword==appUserEditDto.ConFirmPasword)
            {
                var user = await _userManager.FindByNameAsync(User.Identity.Name);
                user.PhoneNumber = appUserEditDto.PhoneNumber;
                user.SurName = appUserEditDto.SurName;
                user.City = appUserEditDto.City;
                user.District = appUserEditDto.District;
                user.Name = appUserEditDto.Name;
                user.ImageUrl = "test";
                user.Email = appUserEditDto.Email;
                user.PasswordHash = _userManager.PasswordHasher.HashPassword(user,appUserEditDto.Pasword);
                var result = await _userManager.UpdateAsync(user);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index","Login");
                }
            }
            return View();
        }
    }
}
