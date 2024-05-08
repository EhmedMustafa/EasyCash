using EasyCash_proje_Edenyity.EntityLayer.Concrete;
using EasyCash_proje_Edenyity.PresentationLayer.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace EasyCash_proje_Edenyity.PresentationLayer.Controllers
{
	public class ConfirmMailController : Controller
	{
		
		private readonly UserManager<AppUser> _userManager;

        public ConfirmMailController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
		public IActionResult index()
		{
            var value = TempData["Mail"];
			ViewBag.v = value;
            //  confirmMailViewModel.Mail = value.ToString();
            return View();
        }

		[HttpPost]

		public async Task <IActionResult> index(ConfirmMailViewModel confirmMailViewModel) 
		{
            
			var user = await _userManager.FindByEmailAsync(confirmMailViewModel.Mail);
			if (user.ConfirmCode == confirmMailViewModel.ConfirmCode)
			{
				user.EmailConfirmed = true;
				await _userManager.UpdateAsync(user);
				return RedirectToAction("Index","Login");
			}
            return View();
		}
	}
}
