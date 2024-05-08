using Microsoft.AspNetCore.Mvc;

namespace EasyCash_proje_Edenyity.PresentationLayer.ViewComponets.Customer
{
    public class _CustomerLayoutScriptPartial:ViewComponent
    {
        public IViewComponentResult Invoke() 
        { 
            return View();
        }
    }
}
