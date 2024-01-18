using BusinessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace PresentationLayer.Controllers
{
    public class MyLastProcessController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly ICustomerAccountProcessService _customerAccountProcessService;

        public MyLastProcessController(UserManager<AppUser> userManager, ICustomerAccountProcessService customerAccountProcessService)
        {
            _userManager = userManager;
            _customerAccountProcessService = customerAccountProcessService;
        }

        public async Task<IActionResult> Index()
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            var context = new Context();
            var id = context.CustomerAcccounts.Where(x => x.CustomerAcccountID == user.Id && x.CustomerAcccountCurrency == "Türk Lirası").Select(y => y.CustomerAcccountID).FirstOrDefault();
            var values = _customerAccountProcessService.TMyLastProcess(id);
            return View(values);
        }
    }
}
