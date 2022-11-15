using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace First.Controllers
{
    public class BlogController : Controller
    {
        BlogManager bm = new BlogManager(new EfBlogRepository());
        public IActionResult Index()
        {
            var values = bm.GetBlogsWithCategory();
            return View(values);
        }
        public IActionResult BlogReadAll(int id)
        {
            ViewBag.Id = id;    
            var values = bm.GetBlogId(id);
            return View(values);
        }
        public IActionResult BlogListByWriter()
        {
            var values = bm.GetBlogWithWriter(1);
            return View(values);  
        }
    }
}
