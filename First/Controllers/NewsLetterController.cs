using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrate;
using Microsoft.AspNetCore.Mvc;

namespace First.Controllers
{
    public class NewsLetterController : Controller
    {
        readonly NewsLetterManager nl = new NewsLetterManager(new EfNewsLetterRepository());
        
        [HttpGet]
        public PartialViewResult SubscribeMail()
        {
            return PartialView();
        }
        [HttpPost]
        public PartialViewResult SubscribeMail(NewsLetter mail)
        {
            mail.MailStatus = true;
            nl.AddNewsLetter(mail);
            return PartialView(nl);
        }
    }
}
