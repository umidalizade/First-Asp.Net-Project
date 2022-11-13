using First.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace First.ViewComponents
{
    public class CommentList : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var commentValues = new List<UserComment>
            {
                new UserComment
                {
                    Id = 1,
                    UserName = "Umid"
                },
                new UserComment
                {
                    Id = 2,
                    UserName = "Khayal"
                },
                new UserComment
                {
                    Id=3,
                    UserName = "Janico"
                }
            };
            return View(commentValues);
        } 
    }
}
