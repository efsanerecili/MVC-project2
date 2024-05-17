using Microsoft.AspNetCore.Mvc;

namespace MVC_Project2.Contollers
{
    public class HomeController : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }
    }
}
