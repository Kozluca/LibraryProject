using Microsoft.AspNetCore.Mvc;

namespace LibraryProject.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
