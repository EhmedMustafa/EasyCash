using Microsoft.AspNetCore.Mvc;

namespace EasyCash_proje_Edenyity.PresentationLayer.Controllers
{
    public class CustomerLayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
