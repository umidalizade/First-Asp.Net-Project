using Microsoft.AspNetCore.Mvc;

namespace First.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
