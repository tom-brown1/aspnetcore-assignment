using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Queue_Management_System.Controllers
{
    public class QueueController : Controller
    {

        [HttpGet]
        public IActionResult CheckinPage()
        {
            return View();
        }



        [HttpGet]
        public IActionResult WaitingPage()
        {
            return View();
        }



        [Authorize, HttpGet]
        public IActionResult ServicePoint()
        {
            return View();
        }


    }
}
