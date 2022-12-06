using ASP.NETIntro.Models;

namespace ASP.NETIntro.Contracts
{
    public interface ITestService
    {
        string GetProduct(TestModel testModel);
    }
}
