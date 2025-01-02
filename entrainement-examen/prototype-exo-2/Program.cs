// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

class Program
{
    static void Main(string[] args)
    {
        // Exemple de contrat habitation
        var contratBaseHabitation = new ContratHabitation
        {
            NomClient = "Jean Dupont",
            DateDebut = DateTime.Now,
            Montant = 1000m,
            AdresseHabitation = "123 Rue Principale",
            Annexes = new List<string> { "Annexe1", "Annexe2" }
        };

        // Création d'une copie
        var contratPersonnalise = (ContratHabitation)contratBaseHabitation.Clone();
        contratPersonnalise.NomClient = "Marie Curie"; // Personnalisation du nom
        contratPersonnalise.AdresseHabitation = "456 Avenue Centrale";

        // Affichage
        Console.WriteLine($"Contrat Base : {contratBaseHabitation.NomClient}, {contratBaseHabitation.AdresseHabitation}");
        Console.WriteLine($"Contrat Clone : {contratPersonnalise.NomClient}, {contratPersonnalise.AdresseHabitation}");
    }
}
