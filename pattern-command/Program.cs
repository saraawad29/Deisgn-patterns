// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;

namespace PatternCommand
{
    class Program
    {
        static void Main(string[] args)
        {
            // Création d'un catalogue et de quelques véhicules
            Catalogue catalogue = new Catalogue();
            var vehicule1 = new Vehicule("Peugeot 308", 15000, DateTime.Now.AddMonths(-6));
            var vehicule2 = new Vehicule("Renault Clio", 12000, DateTime.Now.AddMonths(-12));
            var vehicules = new List<Vehicule> { vehicule1, vehicule2 };

            // Création d'une commande de remise
            var commandeRemise = new SolderCommande(vehicules, 0.10); // Remise de 10%

            Console.WriteLine("\n>>> Lancer la commande de remise");
            catalogue.LancerCommande(commandeRemise);

            Console.WriteLine("\n>>> Annuler la commande de remise");
            catalogue.AnnulerDerniereCommande();

            Console.WriteLine("\n>>> Rétablir la commande de remise");
            catalogue.RetablirCommande(commandeRemise);
        }
    }
}