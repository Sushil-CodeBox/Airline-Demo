using Microsoft.AspNetCore.Mvc;

namespace AirlineManagement.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
