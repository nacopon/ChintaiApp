using ChintaiApp.Server.Data;
using ChintaiApp.Shared.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ChintaiApp.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServicesController : ControllerBase
    {
        private readonly AppDbContext context;

        public ServicesController(AppDbContext context)
        {
            this.context = context;
        }

        // GET: api/<ServicesController>
        [HttpGet]
        public async Task<ActionResult<List<Service>>> ListAsync()
        {
            var services = await context.Services.ToListAsync();
            return Ok(services);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Service>> GetAsync(int id)
        {
            var service = await context.Services.FindAsync(id);

            if (service == null)
            {
                return NotFound();
            }

            return Ok(service);
        }

        [HttpPost]
        public async Task<ActionResult<Service>> CreateAsync(Service service)
        {
            if (service.ServiceId != 0)
            {
                return BadRequest();
            }

            var now = DateTime.Now;
            service.CreatedAt = now;
            service.UpdatedAt = now;
            context.Services.Add(service);
            await context.SaveChangesAsync();

            return CreatedAtAction("Get", new { id = service.ServiceId }, service);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateAsync(Service service)
        {
            if (await context.Services.AsNoTracking().SingleOrDefaultAsync(s => s.ServiceId == service.ServiceId) == null)
            {
                return NotFound();
            }

            service.UpdatedAt = DateTime.Now;
            context.Entry(service).State = EntityState.Modified;
            await context.SaveChangesAsync();
            return NoContent();
        }
    }
}
