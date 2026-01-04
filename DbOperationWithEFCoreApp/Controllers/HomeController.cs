using Microsoft.AspNetCore.Mvc;

namespace DbOperationWithEFCoreApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
