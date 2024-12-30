using System;

public class ConstructeurLiasseVehiculePdf : ConstructeurLiasseVehicule
{
    public ConstructeurLiasseVehiculePdf()
    {
        liasse = new LiassePdf(); // Produit spécifique au format PDF
    }

    public override void ConstruitBonDeCommande(string client)
    {
        liasse.AjouteDocument($"Bon de commande PDF pour : {client}");
    }

    public override void ConstruitDemandeImmatriculation(string client)
    {
        liasse.AjouteDocument($"Demande d'immatriculation PDF pour : {client}");
    }
}

