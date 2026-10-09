using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using GenerationControleurs.ViewModels;
using LinqEtSeedEF.Models;

namespace GenerationControleurs.Controllers
{
    public class StatsController : Controller
    {
        private readonly GenerationControleursContext _context;

        public StatsController(GenerationControleursContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            List<Restaurant> restaurants = await _context.Restaurant.Include(r => r.Commandes).ThenInclude(c => c.CommandesPlats).ThenInclude(cp => cp.Plat)
                .Include(r => r.Plats).ThenInclude(p => p.CommandesPlats).ToListAsync();
            return View(new RestaurantsStatsVM(restaurants));
        }
    }
}
