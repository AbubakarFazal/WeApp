using Microsoft.AspNetCore.Mvc;

namespace BusinessElite.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
