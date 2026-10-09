using LinqEtSeedEF.Models;

namespace GenerationControleurs.ViewModels
{
    public class RestaurantsStatsVM
    {
        public RestaurantsStatsVM(IEnumerable<Restaurant> restaurants)
        {
            RestaurantStatsVM = restaurants.Select(r => new RestaurantStatsVM(r)).ToList();
            NbCommandes = restaurants.Sum(r => r.Commandes.Count);
            NbPlatsVendus = restaurants.Sum(r => r.Plats.Sum(p => p.CommandesPlats.Sum(cp => cp.Quantite)));
            PrixTotalCommandes = restaurants.Sum(r => r.Commandes.Sum(c => c.CommandesPlats.Sum(cp => cp.Plat.Prix * cp.Quantite)));
            PrixMaxCommande = restaurants.Max(r => r.Commandes.Max(c => c.CommandesPlats.Sum(cp => cp.Plat.Prix * cp.Quantite)));
            MaxNiveauPiquant = restaurants.Max(r => r.Plats.Max(p => p.NiveauPiquant != null ? p.NiveauPiquant.Value : 0));
        }

        public int NbCommandes { get; set; }
        public int NbPlatsVendus { get; set; }
        public decimal PrixTotalCommandes { get; set; }
        public decimal PrixMaxCommande { get; set; }
        public int MaxNiveauPiquant { get; set; }

        public IEnumerable<RestaurantStatsVM> RestaurantStatsVM { get; set; }
    }
}
