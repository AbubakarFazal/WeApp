using Microsoft.AspNetCore.Mvc;

namespace BusinessElite.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
