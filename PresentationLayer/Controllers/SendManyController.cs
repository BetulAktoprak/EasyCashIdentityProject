using BusinessLayer.Abstract;
using DataAccessLayer.Concrete;
using DtoLayer.Dtos.CustomerAccountProcessDtos;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace PresentationLayer.Controllers
{
    public class SendManyController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly ICustomerAccountProcessService _customerAccountProcessService;

      
        public SendManyController(UserManager<AppUser> userManager, ICustomerAccountProcessService customerAccountProcessService) 
        {
            _userManager = userManager;
            _customerAccountProcessService = customerAccountProcessService;
        }

        [HttpGet]
        public IActionResult Index(string mycurrency)
        {
            ViewBag.currency = mycurrency;
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(SendMoneyForCustomerAccountProcessDto sendMoneyForCustomerAccountProcessDto)
        {
            var context = new Context();
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            var receiverAccountNumberID = context.CustomerAcccounts.Where(x => x.CustomerAcccountNumber == sendMoneyForCustomerAccountProcessDto.ReceiverAccountNumber).Select(y => y.CustomerAcccountID).FirstOrDefault();

            var senderAccountNumberID = context.CustomerAcccounts.Where(x => x.AppUserID == user.Id).Where(y => y.CustomerAcccountCurrency == "Türk Lirası").Select(z => z.CustomerAcccountID).FirstOrDefault();

            var values = new CustomerAcccountProcess();
            values.ProcessDate = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            values.SenderID = senderAccountNumberID;
            values.ProcessType = "Havale";
            values.ReceiverID = receiverAccountNumberID;
            values.Amount = sendMoneyForCustomerAccountProcessDto.Amount;
            _customerAccountProcessService.TInsert(values);
            values.Description = sendMoneyForCustomerAccountProcessDto.Description;

            return RedirectToAction("Index","Login");
        }
    }
}
