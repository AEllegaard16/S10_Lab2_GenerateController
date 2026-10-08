using LinqEtSeedEF.Models;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;

namespace GenerationControleurs.ViewModels
{
    public class RestaurantStatsVM
    {
        public RestaurantStatsVM(Restaurant restaurant)
        {
            // TODO: Écrire la logique nécessaire pour remplir les propriétés de cette vue
            Nom = restaurant.Nom;
            NbCommandes = restaurant.Commandes.Count;
            NbPlatsVendus = restaurant.Plats.Sum(p => p.CommandesPlats.Sum(cp => cp.Quantite));
            PrixTotalCommandes = restaurant.Commandes.Sum(c => c.CommandesPlats.Sum(cp => cp.Plat.Prix * cp.Quantite));
            PrixMaxCommande = restaurant.Commandes.Max(c => c.CommandesPlats.Sum(cp => cp.Plat.Prix * cp.Quantite));
            MaxNiveauPiquant = restaurant.Plats.Max(p => p.NiveauPiquant) ?? 0;
        }

        public string Nom { get; set; }
        public int NbCommandes { get; set; }
        public int NbPlatsVendus { get; set; }
        public decimal PrixTotalCommandes { get; set; }
        public decimal PrixMaxCommande { get; set; }
        public int MaxNiveauPiquant { get; set; }

    }
}
