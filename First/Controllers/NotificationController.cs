using Microsoft.AspNetCore.Mvc;

namespace First.Controllers
{
    public class NotificationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
