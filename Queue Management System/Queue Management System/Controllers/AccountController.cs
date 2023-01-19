using Microsoft.AspNetCore.Mvc;

namespace Queue_Management_System.Controllers
{
    public class AccountController : Controller
    {

        public IActionResult Login()
        {
            return View();
        }

    }
}
