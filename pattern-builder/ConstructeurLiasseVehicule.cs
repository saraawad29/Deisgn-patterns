public abstract class ConstructeurLiasseVehicule
{
    protected Liasse liasse;

    public Liasse Liasse => liasse; // Accès au produit final

    public abstract void ConstruitBonDeCommande(string client);
    public abstract void ConstruitDemandeImmatriculation(string client);
}
