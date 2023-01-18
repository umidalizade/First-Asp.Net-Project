using First.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace First.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ChartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult CategoryChart()
        {
            List<CategoryClass> list = new List<CategoryClass>();

            list.Add(new CategoryClass
            {
                categoryname = "Technology",
                categorycount = 10
            });

            list.Add(new CategoryClass
            {
                categoryname = "Game",
                categorycount = 8
            });

            list.Add(new CategoryClass
            {
                categoryname = "Sport",
                categorycount = 17
            });
            list.Add(new CategoryClass
            {
                categoryname = "Life",
                categorycount = 34
            });
            list.Add(new CategoryClass
            {
                categoryname = "Cars",
                categorycount = 27
            });

            return Json(new { jsonlist = list });
        }
    }
}
