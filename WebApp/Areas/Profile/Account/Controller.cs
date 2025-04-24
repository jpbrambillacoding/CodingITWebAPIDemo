using Microsoft.AspNetCore.Mvc;

namespace WebApp.Areas.Profile.Account
{
    [Area("Profile")]
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
