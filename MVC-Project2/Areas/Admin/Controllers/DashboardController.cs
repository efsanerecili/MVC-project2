using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MVC_Project2.Areas.Admin.Controllers
{
    public class DashboardController : Controller
    {

        [Area("Admin")]
      
        public IActionResult Index()
        {
            return View();
        }
    }
}
