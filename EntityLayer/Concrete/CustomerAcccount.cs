using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class CustomerAcccount
    {
        public int CustomerAcccountID { get; set; }
        public string CustomerAcccountNumber { get; set; }
        public string CustomerAcccountCurrency { get; set; }
        public decimal CustomerAcccountBalance { get; set; }
        public string BankBranch { get; set; }
        public int AppUserID { get; set; }
        public AppUser AppUser { get; set; }
        public List<CustomerAcccountProcess> CustomerSender {  get; set; }
        public List<CustomerAcccountProcess> CustomerReceiver {  get; set; }
    }
}
