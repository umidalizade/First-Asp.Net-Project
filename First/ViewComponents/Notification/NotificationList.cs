using Microsoft.AspNetCore.Mvc;

namespace First.ViewComponents.Notification
{
    public class NotificationList : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();  
        }
    }
}
