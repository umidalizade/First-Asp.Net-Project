using ClosedXML.Excel;
using First.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.IO;

namespace First.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BlogController : Controller
    {
        public IActionResult ExportStaticExcelBloglist()
        {
            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("Blog List");
                worksheet.Cell(1, 1).Value = "Blog Id";
                worksheet.Cell(1, 2).Value = "Blog Name";

                int BlogRowCount = 2;
                foreach (var item in GetAllBlogList())
                {
                    worksheet.Cell(BlogRowCount, 1).Value = item.Id;
                    worksheet.Cell(BlogRowCount, 2).Value = item.Name;
                    BlogRowCount++;
                }
                using (var stream = new MemoryStream())
                {
                    workbook.SaveAs(stream);
                    var content = stream.ToArray();
                    return File(content, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "Blog1.xlsx");
                }
            }

        }
        public List<BlogModel> GetAllBlogList()
        {
            List<BlogModel> bm = new List<BlogModel>();
            {
                new BlogModel { Id = 1, Name = "C#" };
                new BlogModel { Id = 2, Name = "PHP" };
                new BlogModel { Id = 3, Name = "Java" };
            };
            return bm;
        }
        public IActionResult BlogExportToExcel()
        {
            return View();
        }
        public IActionResult ExportDynamicExcelBlogList()
        {
            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("Blog List");
                worksheet.Cell(1, 1).Value = "Blog Id";
                worksheet.Cell(1, 2).Value = "Blog Name";

                int BlogRowCount = 2;
                foreach (var item in GetAllBlogList())
                {
                    worksheet.Cell(BlogRowCount, 1).Value = item.Id;
                    worksheet.Cell(BlogRowCount, 2).Value = item.Name;
                    BlogRowCount++;
                }
                using (var stream = new MemoryStream())
                {
                    workbook.SaveAs(stream);
                    var content = stream.ToArray();
                    return File(content, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "Blog1.xlsx");
                }
            }
        }
        public List<BlogModel2> GetListAll()
        {

        }
    }
}
