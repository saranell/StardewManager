using Microsoft.AspNetCore.Mvc;

namespace StardewManager.Controllers
{
    public class FarmController : Controller
    {
        [HttpGet]
        [Route("/Farm")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
