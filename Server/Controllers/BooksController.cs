using ChintaiApp.Server.Data;
using ChintaiApp.Shared.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ChintaiApp.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly AppDbContext context;

        public BooksController(AppDbContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Book>>> ListAsync()
        {
            var books = await context.Books.ToListAsync();
            return Ok(books);
        }

        //追加
        [HttpGet("{id}")]
        public async Task<ActionResult<Book>> GetAsync(int id)
        {
            var book = await context.Books.SingleOrDefaultAsync(b => b.BookId.Equals(id));

            if (book == null)
            {
                return NotFound();
            }

            return Ok(book);
        }
    }
}
