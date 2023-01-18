using First.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;

namespace First.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class WriterController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult WriterList()
        {
            var jsonWriters = JsonConvert.SerializeObject(writers);
            return Json(jsonWriters);
        }

        public IActionResult GetWriterById(int writerId)
        {
            var findWriter = writers.FirstOrDefault(x => x.Id == writerId);
            var jsonWriters = JsonConvert.SerializeObject(findWriter);
            return Json(jsonWriters);   
        }

        public static List<WriterClass> writers = new List<WriterClass>
        {
            new WriterClass
            {
                Id = 1,
                Name =  "Umid"
            },
            new WriterClass
            {
                Id = 2,
                Name =  "Xayal"
            },
            new WriterClass
            {
                Id = 3,
                Name =  "Thomas"
            },
        };
    }
}
