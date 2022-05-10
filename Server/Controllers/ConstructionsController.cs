using ChintaiApp.Server.Data;
using ChintaiApp.Shared.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ChintaiApp.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConstructionsController : ControllerBase
    {
        private readonly AppDbContext context;

        public ConstructionsController(AppDbContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Construction>>> ListAsync()
        {
            var constructions = await context.Constructions.ToListAsync();
            return Ok(constructions);
        }


        [HttpGet("{id}")]
        public async Task<ActionResult<Construction>> GetAsync(int id)
        {
            var Construction = await context.Constructions.FindAsync(id);

            if (Construction == null)
            {
                return NotFound();
            }

            return Ok(Construction);
        }

        [HttpPost]
        public async Task<ActionResult<Construction>> CreateAsync(Construction construction)
        {
            if (construction.ConstructionId != 0)
            {
                return BadRequest();
            }

            var now = DateTime.Now;
            construction.CreatedAt = now;
            construction.UpdatedAt = now;
            context.Constructions.Add(construction);
            await context.SaveChangesAsync();

            return CreatedAtAction("Get", new { id = construction.ConstructionId }, construction);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateAsync(Construction construction)
        {
            if (await context.Constructions.AsNoTracking().SingleOrDefaultAsync(c => c.ConstructionId == construction.ConstructionId) == null)
            {
                return NotFound();
            }

            construction.UpdatedAt = DateTime.Now;
            context.Entry(construction).State = EntityState.Modified;
            await context.SaveChangesAsync();
            return NoContent();
        }
    }
}
