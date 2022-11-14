using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace First.Controllers
{
    //[Authorize]
    public class WriterController : Controller
    {
        //[Authorize]
        //[AllowAnonymous]
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult WriterProfile()
        {
            return View();
        }
        public IActionResult Test()
        {
            return View();
        }
    }
}
