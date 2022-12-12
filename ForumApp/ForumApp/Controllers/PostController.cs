using ForumApp.Data;
using ForumApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ForumApp.Controllers
{
    public class PostController : Controller
    {
        private readonly ForumDbContext context;
        public PostController(ForumDbContext _context)
        {
            this.context = _context;
        }
        public async Task<IActionResult> Index()
        {
            var model = await this.context.Posts
                .Select(p => new PostViewModel()
                {
                    Id = p.Id,
                    Title= p.Title,
                    Content= p.Content,
                })
                .ToListAsync();
            return View();
        }
    }
}
