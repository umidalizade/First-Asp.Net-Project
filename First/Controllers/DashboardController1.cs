using DataAccessLayer.Concreate;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace First.Controllers
{
    public class DashboardController1 : Controller
    {
        public IActionResult Index()
        {
            Context c=new Context();
            ViewBag.TB = c.Blogs.Count().ToString();
            ViewBag.TB2=c.Blogs.Where(x=>x.WriterId==1).Count().ToString();
            ViewBag.TC = c.Categories.Count().ToString();
            return View();
        }
    }
}
