using DataAccessLayer.Concreate;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace First.Areas.Admin.ViewComponents
{
    public class Statistic2: ViewComponent
    {
        Context c = new Context();      
        public IViewComponentResult Invoke()
        {
            ViewBag.v1 = c.Blogs.OrderByDescending(x => x.BlogId).Select(x => x.BlogTitle).Take(1).FirstOrDefault();
            return View();  
        }
    }
}
