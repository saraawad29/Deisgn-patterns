public abstract class ConstructeurLiasseVehicule
{
    protected Liasse liasse; // composition : mecanisme qui permet a une classe
    //de contenir une instance de cette meme classe d'une autre

    public Liasse Liasse => liasse; // Accès au produit final

    public abstract void ConstruitBonDeCommande(string client);
    public abstract void ConstruitDemandeImmatriculation(string client);

    public Liasse Resultat()
    {
        return liasse;
    }
}
