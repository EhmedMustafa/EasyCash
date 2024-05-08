using EasyCash_proje_Edenyity.BusinessLayer.Abstrack;
using EasyCash_proje_Edenyity.DataAccessLayer.Concrete;
using EasyCash_proje_Edenyity.DtoLayer.Dtos.CurtomerAccountProcessDtos;
using EasyCash_proje_Edenyity.EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace EasyCash_proje_Edenyity.PresentationLayer.Controllers
{
    public class SendMoneyController : Controller
    {
        private readonly ICustomerAccountProcessService _customerAccountProcessService;
        private readonly UserManager<AppUser> _userManager;

        public SendMoneyController(UserManager<AppUser> userManager, ICustomerAccountProcessService customerAccountProcessService)
        {
            _userManager = userManager;
            _customerAccountProcessService = customerAccountProcessService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task <IActionResult> Index(SendMoneyForCustomerAccountProcessDto sendMoneyForCustomerAccountProcessDto)
        {
            var context = new Context();

            var user=_userManager.FindByNameAsync(User.Identity.Name);
            var receiverAccountNumberId = context.customerAccounts.Where
               (x => x.CustomerAccountNumber == sendMoneyForCustomerAccountProcessDto.ReceiverAccountNumber).Select(x => x.CustomerAccountİd).FirstOrDefault();

            sendMoneyForCustomerAccountProcessDto.SenderId = user.Id;
            sendMoneyForCustomerAccountProcessDto.ProcessDate = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            sendMoneyForCustomerAccountProcessDto.ProcessType = "Baki";
            sendMoneyForCustomerAccountProcessDto.ReceiverId = receiverAccountNumberId;

            return RedirectToAction("Index", "Ehmed");

           
        }
    }
}
