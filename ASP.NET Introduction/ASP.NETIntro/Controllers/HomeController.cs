using ASP.NETIntro.Contracts;
using ASP.NETIntro.Models;
using ASP.NETIntro.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Microsoft.AspNetCore.Authorization;

namespace ASP.NETIntro.Controllers
{
    public class HomeController : BaseController
    {
        private readonly ILogger<HomeController> _logger;

        private readonly ITestService testService;

        public HomeController(ILogger<HomeController> logger, ITestService testService)
        {
            this._logger = logger;
            this.testService = testService;
            
        }

        [AllowAnonymous]
        public IActionResult Index()
        {
            return View();
        }

        [AllowAnonymous]
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

        //[HttpPost]
        //public IActionResult Test(int testModel)
        //{

        //    if (!ModelState.IsValid)
        //    {
        //        return View(testModel);
        //    }

        //    Dependency Injection
        //    string product = testService.GetProduct(testModel);

        //    "www.google/ProducesDefaultResponseTypeAttribute/testmodel"
        //        { "id":"testmodel"}
        //    { "response:{id,name}"}

        //    Каква е разликата ако се изпълни вместо горния ред този: sting product = testModel.Product;???????

        //    return RedirectToAction(nameof(Index));
        //}

        [AllowAnonymous]
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}