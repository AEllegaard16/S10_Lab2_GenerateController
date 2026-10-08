using Microsoft.AspNetCore.Mvc;

namespace GenerationControleurs.Controllers
{
    public class StatsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
