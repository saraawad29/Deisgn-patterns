using System;
using System.Collections.Generic;

namespace PatternCommand
{
    public abstract class CommandeSolder
    {
        protected List<Vehicule> vehicules;

        protected CommandeSolder(List<Vehicule> vehicules)
        {
            this.vehicules = vehicules;
        }

        public abstract void Execute(); // Appliquer la commande
        public abstract void Undo();    // Annuler la commande
        public abstract void Redo();    // Rétablir la commande
    }
}
