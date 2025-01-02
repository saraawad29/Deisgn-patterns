using System;
using System.Collections.Generic;

namespace PatternCommand
{
    public class SolderCommande : CommandeSolder
    {
        private double tauxRemise;
        private Dictionary<Vehicule, double> anciensPrix = new Dictionary<Vehicule, double>();

        public SolderCommande(List<Vehicule> vehicules, double tauxRemise) : base(vehicules)
        {
            this.tauxRemise = tauxRemise;
        }

        public override void Execute()
        {
            Console.WriteLine("Application d'une remise de " + (tauxRemise * 100) + "% sur les véhicules.");
            foreach (var vehicule in vehicules)
            {
                anciensPrix[vehicule] = vehicule.PrixVente; // Sauvegarde du prix actuel
                vehicule.ModifierPrix(1 - tauxRemise);      // Appliquer la remise
            }
        }

        public override void Undo()
        {
            Console.WriteLine("Annulation de la remise sur les véhicules.");
            foreach (var vehicule in vehicules)
            {
                if (anciensPrix.ContainsKey(vehicule))
                {
                    vehicule.PrixVente = anciensPrix[vehicule]; // Restaurer le prix
                }
            }
        }

        public override void Redo()
        {
            Console.WriteLine("Rétablissement de la remise.");
            Execute(); // Réappliquer la commande
        }
    }
}
