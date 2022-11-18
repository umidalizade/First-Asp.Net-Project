using Microsoft.AspNetCore.Mvc;

namespace First.Controllers
{
    public class DashboardController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
