using LinqEtSeedEF.Models;

namespace GenerationControleurs.ViewModels
{
    public class RestaurantsStatsVM
    {
        public RestaurantsStatsVM(IEnumerable<Restaurant> restaurants)
        {
            // TODO: Écrire la logique nécessaire pour remplir les propriétés de cette vue
            // TODO: Il va falloir créer un RestaurantStatsVM pour chaque restaurant
        }

        public int NbCommandes { get; set; }
        public int NbPlatsVendus { get; set; }
        public decimal PrixTotalCommandes { get; set; }
        public decimal PrixMaxCommande { get; set; }
        public int MaxNiveauPiquant { get; set; }

        public IEnumerable<RestaurantStatsVM> RestaurantStatsVM { get; set; }
    }
}
