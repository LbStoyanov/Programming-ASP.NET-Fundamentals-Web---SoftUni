using ASP.NETIntro.Core.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace ASP.NETIntro.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService productService;

        public ProductController(IProductService productService)
        {
            this.productService= productService;
        }

        /// <summary>
        /// List all products
        /// </summary>
        /// <returns></returns>
        public async Task<IActionResult> Index()
        {
            var products = await productService.GetAll();
            return View();
        }
    }
}
