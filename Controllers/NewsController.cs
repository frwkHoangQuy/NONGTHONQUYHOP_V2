using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
namespace WebApplication1.Controllers
{
    [EnableCors("MyPolicy")]
    [ApiController]
    [Route("[controller]")]
    public class NewsController : ControllerBase
    {
        private readonly AppDbContext _context;
        public NewsController(AppDbContext context)
        {
            _context = context;
        }
        [EnableCors("AllowOrigin")]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<News>>> getNews()
        {
            return await _context.News.ToListAsync();
        }
    }
}
