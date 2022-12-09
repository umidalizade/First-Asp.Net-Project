using BusinessLayer.Concrete;
using DataAccessLayer.Concreate;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace First.ViewComponents.Writer
{
    public class WriterAboutOnDashboard : ViewComponent
    {
        WriterManager wm = new WriterManager(new EfWriterRepository());
        Context c = new Context();
        [Authorize]
        public IViewComponentResult Invoke()
        {
            var userMail = User.Identity.Name;
            var writerId = c.Writers.Where(x=>x.WriterMail == userMail).Select(y=>y.WriterId).FirstOrDefault();
            var values = wm.GetWriterById(writerId);
            return View(values);  
        }
    }
}
