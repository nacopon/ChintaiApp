using ChintaiApp.Server.Data;
using ChintaiApp.Shared.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ChintaiApp.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BuildingsController : ControllerBase
    {
        private readonly AppDbContext context;

        public BuildingsController(AppDbContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Book>>> ListAsync()
        {
            var buildings = await context.Buildings.ToListAsync();
            return Ok(buildings);
        }
    }
}
