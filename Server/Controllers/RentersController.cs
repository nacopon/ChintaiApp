using ChintaiApp.Server.Data;
using ChintaiApp.Shared.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ChintaiApp.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RentersController : ControllerBase
    {
        private readonly AppDbContext context;

        public RentersController(AppDbContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Renter>>> ListAsync()
        {
            var renters = await context.Renters.ToListAsync();
            return Ok(renters);

        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Renter>> GetAsync(int id)
        {
            var renter = await context.Renters.FindAsync(id);

            if (renter == null)
            {
                return NotFound();
            }

            return Ok(renter);
        }

        [HttpPost]
        public async Task<ActionResult<User>> CreateAsync(Renter renter)
        {
            if (renter.RenterId != 0)
            {
                return BadRequest();
            }

            var now = DateTime.Now;
            renter.CreatedAt = now;
            renter.UpdatedAt = now;
            context.Renters.Add(renter);
            await context.SaveChangesAsync();

            return CreatedAtAction("Get", new { id = renter.RenterId }, renter);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateAsync(Renter renter)
        {
            if (await context.Renters.AsNoTracking().SingleOrDefaultAsync(r => r.RenterId == renter.RenterId) == null)
            {
                return NotFound();
            }

            renter.UpdatedAt = DateTime.Now;
            context.Entry(renter).State = EntityState.Modified;
            await context.SaveChangesAsync();
            return NoContent();
        }
    }
}
