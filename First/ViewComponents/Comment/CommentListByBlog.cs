using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace First.ViewComponents.Comment
{
    public class CommentListByBlog : ViewComponent
    {
            CommentManager cm = new CommentManager(new EfCommentRepository());
        public IViewComponentResult Invoke(int id)
        {
            //ViewBag.Id = id;
            var values = cm.GetAllList(id);
            return View(values);  
        }
    }
}
