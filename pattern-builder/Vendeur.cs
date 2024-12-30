public class Vendeur
{
    private ConstructeurLiasseVehicule constructeur;

    public Vendeur(ConstructeurLiasseVehicule constructeur)
    {
        this.constructeur = constructeur;
    }

    public Liasse Construit(string client)
    {
        constructeur.ConstruitBonDeCommande(client);
        constructeur.ConstruitDemandeImmatriculation(client);
        return constructeur.Liasse; // Récupération de la liasse construite
    }
}
