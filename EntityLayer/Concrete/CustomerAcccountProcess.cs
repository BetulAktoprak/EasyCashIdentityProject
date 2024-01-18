using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class CustomerAcccountProcess
    {
        public int CustomerAcccountProcessID { get; set; }
        public string ProcessType { get; set; }
        public decimal Amount { get; set; }
        public DateTime ProcessDate { get; set; }
        public int? SenderID { get; set; }
        public int? ReceiverID { get; set; }
        public CustomerAcccount SenderCustomer { get; set; }
        public CustomerAcccount ReceiverCustomer { get; set; }
        public string Description { get; set; }
    }
}
