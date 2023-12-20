using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Queue_Management_System.Controllers
{
    [Authorize]
    public class AdminController : Controller
    {

        [HttpGet]
        public IActionResult Dashboard()
        {
            return View();
        }

    }
}
