﻿using Microsoft.AspNetCore.Mvc;

namespace EasyCash_proje_Edenyity.PresentationLayer.ViewComponets.Customer
{
    public class _CustomerLayoutNavbarPartial:ViewComponent
    {
        public IViewComponentResult Invoke() 
        {
            return View();
        }

    }
}