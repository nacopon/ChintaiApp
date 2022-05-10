using ChintaiApp.Server.Data;
using ChintaiApp.Shared.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ChintaiApp.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly AppDbContext context;

        public UsersController(AppDbContext context)
        {
            this.context = context;
        }

        // GET: api/<UsersController>
        [HttpGet]
        public async Task<ActionResult<List<User>>> ListAsync()
        {
            var users = await context.Users.ToListAsync();
            return Ok(users);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<User>> GetAsync(int id)
        {
            var user = await context.Users.FindAsync(id);

            if (user == null)
            {
                return NotFound();
            }

            return Ok(user);
        }

        [HttpPost]
        public async Task<ActionResult<User>> CreateAsync(User user)
        {
            if (user.UserId != 0)
            {
                return BadRequest();
            }

            var now = DateTime.Now;
            user.CreatedAt = now;
            user.UpdatedAt = now;
            context.Users.Add(user);
            await context.SaveChangesAsync();

            return CreatedAtAction("Get", new { id = user.UserId }, user);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateAsync(User user)
        {
            if (await context.Users.AsNoTracking().SingleOrDefaultAsync(u => u.UserId == user.UserId) == null)
            {
                return NotFound();
            }

            user.UpdatedAt = DateTime.Now;
            context.Entry(user).State = EntityState.Modified;
            await context.SaveChangesAsync();
            return NoContent();
        }
    }
}
