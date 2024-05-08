using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCash_proje_Edenyity.EntityLayer.Concrete
{
    public class CustomerAccount//musteri hesabi
    {
        [Key]
        public int CustomerAccountİd { get; set; }
        public string CustomerAccountNumber { get; set; }
        public string CustomerAccountCurrency  { get; set; } // hansi valuta
        public decimal CustomerAccountBalance { get; set; } // musteri balansi
        public string BankBranch { get; set; } // bank filiali
        public int AppUserId { get; set; }
        public AppUser  appUser { get; set; }
        public List<CustomerAccountProcess> CustomerSender { get; set; }
        public List<CustomerAccountProcess> CustomerReceiver { get; set; }

    }
}
