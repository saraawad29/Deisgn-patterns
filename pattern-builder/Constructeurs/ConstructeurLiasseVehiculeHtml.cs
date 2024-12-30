using System;

public class ConstructeurLiasseVehiculeHtml : ConstructeurLiasseVehicule
{
    public ConstructeurLiasseVehiculeHtml()
    {
        liasse = new LiasseHtml(); // Produit spécifique au format HTML
    }

    public override void ConstruitBonDeCommande(string client)
    {
        liasse.AjouteDocument($"Bon de commande HTML pour : {client}");
    }

    public override void ConstruitDemandeImmatriculation(string client)
    {
        liasse.AjouteDocument($"Demande d'immatriculation HTML pour : {client}");
    }
}
