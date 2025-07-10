using Microsoft.AspNetCore.Mvc;

namespace CoreMVCEmptyStarter.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult About()
        {
            return View();
        }
    }
}
