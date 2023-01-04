using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ASP.NETIntro.Controllers
{
    [Authorize]
    public class BaseController : Controller
    {
        
    }
}
