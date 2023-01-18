using Microsoft.AspNetCore.Mvc;

namespace First.Areas.Admin.ViewComponents
{
    public class Statistic3 : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();  
        }
    }
}
