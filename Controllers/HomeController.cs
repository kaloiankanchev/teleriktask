using Microsoft.AspNetCore.Mvc;

namespace TelerikThomas.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

  

        public IActionResult Ticket()
        {
           

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
