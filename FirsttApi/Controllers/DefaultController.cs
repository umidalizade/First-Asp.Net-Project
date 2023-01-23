using FirsttApi.DataAccessLayer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace FirsttApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DefaultController : ControllerBase
    {
        [HttpGet]
        public IActionResult WorkerList()
        {
            using var c = new Context();
            var values = c.Workers.ToList();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult AddWorker(Worker worker)
        {
            using var c= new Context();
            c.Workers.Add(worker);
            c.SaveChanges();
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetWorkerById(int id)
        {
            using var c = new Context();
            var worker = c.Workers.Find(id);
            if(worker == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(worker);
            }
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteWorker(int id)
        {
            using var c = new Context();
            var worker = c.Workers.Find(id);
            if (worker == null)
            {
                return NotFound();
            }
            else
            {
                c.Remove(worker);
                c.SaveChanges();
                return Ok();
            }
        }
        [HttpPut]
        public IActionResult UpdateWorker(Worker worker)
        {
            using var c = new Context();
            var w = c.Find<Worker>(worker.Id);
            if(w == null)
            {
                return NotFound();
            }
            else
            {
                w.Name = worker.Name;
                c.SaveChanges();
                return Ok();
            }
        }
    }
}
