using Microsoft.AspNetCore.Mvc;
using StardewManager.Data;
using StardewManager.Models;

namespace StardewManager.Controllers
{
    public class FarmController : Controller
    {
        private StardewManagerContext _context;

        public FarmController(StardewManagerContext context)
        {
            _context = context;
        }

        
        [HttpGet]
        [Route("/Farm")]
        public IActionResult Index()
        {
            List<Farm> farms = _context.Farms.ToList();

            return View(farms);
        }
    }
}
