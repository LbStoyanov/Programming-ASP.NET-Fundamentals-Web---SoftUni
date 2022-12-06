using ASP.NETIntro.Contracts;
using ASP.NETIntro.Models;

namespace ASP.NETIntro.Services
{
    public class TestService : ITestService
    {
        public string GetProduct(TestModel testModel)
        {
            return testModel.Product;
        }
    }
}
