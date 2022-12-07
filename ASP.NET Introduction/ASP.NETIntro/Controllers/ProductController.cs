using Microsoft.AspNetCore.Mvc;

namespace ASP.NETIntro.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
