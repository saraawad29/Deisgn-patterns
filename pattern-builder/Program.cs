// See https://aka.ms/new-console-template for more information
Console.WriteLine("patterns builder");
Console.WriteLine("Choisissez le format des documents : 1 (HTML) ou 2 (PDF)");
string choix = Console.ReadLine();
ConstructeurLiasseVehicule constructeur;

if (choix == "1")
{
    constructeur = new ConstructeurLiasseVehiculeHtml();
}
else
{
    constructeur = new ConstructeurLiasseVehiculePdf();
}

// Instanciation du directeur
Vendeur vendeur = new Vendeur(constructeur);

// Construction du produit (liasse) pour un client
Liasse liasse = vendeur.Construit("Client XYZ");

// Impression de la liasse
liasse.Imprime();


