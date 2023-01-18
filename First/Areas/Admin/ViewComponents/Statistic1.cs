using BusinessLayer.Concrete;
using DataAccessLayer.Concreate;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Xml.Linq;

namespace First.Areas.Admin.ViewComponents
{
    public class Statistic1:ViewComponent
    {
        BlogManager bm = new BlogManager(new EfBlogRepository());
        Context c = new Context();
        public IViewComponentResult Invoke()
        {
            ViewBag.v1 = bm.GetList().Count();
            ViewBag.v2 = c.Contacts.Count();
            ViewBag.v3 = c.Comments.Count();
            string api = "0b42be68d28b89e4dc5e1659fcd3492e";
            string connection = "https://api.openweathermap.org/data/2.5/weather?q=Baku&lang=en&units=metric&mode=xml&appid=" + api;
            XDocument document = XDocument.Load(connection);
            ViewBag.v4 = document.Descendants("temperature").ElementAt(0).Attribute("value").Value;
            ViewBag.v5 = document.Descendants("city").ElementAt(0).Attribute("name").Value;
            return View();  
        }

    }
}
