using System;

namespace PatternCommand
{
    public class Vehicule
    {
        public string Nom { get; set; }
        public double PrixVente { get; set; }
        public DateTime DateEntreeStock { get; set; }

        public Vehicule(string nom, double prixVente, DateTime dateEntreeStock)
        {
            Nom = nom;
            PrixVente = prixVente;
            DateEntreeStock = dateEntreeStock;
        }

        public void ModifierPrix(double coefficient)
        {
            PrixVente *= coefficient;
            Console.WriteLine($"Nouveau prix du véhicule {Nom}: {PrixVente:F2}€");
        }
    }
}
