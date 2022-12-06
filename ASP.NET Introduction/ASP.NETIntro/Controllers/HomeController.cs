using ASP.NETIntro.Contracts;
using ASP.NETIntro.Models;
using ASP.NETIntro.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ASP.NETIntro.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly ITestService testService;

        public HomeController(ILogger<HomeController> logger, ITestService testService)
        {
            this._logger = logger;
            this.testService = testService;
            
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Test()
        {
            var model = new TestModel();
            return View(model);
        }

        [HttpPost]
        public IActionResult Test(TestModel testModel)
        {

            if (!ModelState.IsValid)
            {
                return View(testModel);
            }

            //Dependency Injection
            string product = testService.GetProduct(testModel);

            //Каква е разликата ако се изпълни вместо горния ред този: sting product = testModel.Product;???????

            return RedirectToAction(nameof(Index));
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}