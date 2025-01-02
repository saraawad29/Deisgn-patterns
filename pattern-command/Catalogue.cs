using System;
using System.Collections.Generic;

namespace PatternCommand
{
    public class Catalogue
    {
        private Stack<CommandeSolder> commandesEffectuees = new Stack<CommandeSolder>();

        public void LancerCommande(CommandeSolder commande)
        {
            commande.Execute();
            commandesEffectuees.Push(commande); // Stocker la commande exécutée
        }

        public void AnnulerDerniereCommande()
        {
            if (commandesEffectuees.Count > 0)
            {
                var commande = commandesEffectuees.Pop();
                commande.Undo(); // Annuler la dernière commande
            }
            else
            {
                Console.WriteLine("Aucune commande à annuler.");
            }
        }

        public void RetablirCommande(CommandeSolder commande)
        {
            commande.Redo(); // Rétablir la commande
            commandesEffectuees.Push(commande);
        }
    }
}
