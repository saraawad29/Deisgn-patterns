abstract class ObjetBase
{
    protected ObjetBase suivant; // Référence au prochain dans la chaîne

    public void SetSuivant(ObjetBase suivant)
    {
        this.suivant = suivant;
    }

    protected abstract string GetDescription();

    public string DonneDescription()
    {
        string resultat = this.GetDescription();
        if (resultat != null)
            return resultat;

        if (suivant != null)
            return suivant.DonneDescription();
        else
            return "Description par défaut"; // Description fallback
    }
}

class Vehicule : ObjetBase
{
    protected override string GetDescription()
    {
        // Implémentation spécifique pour Véhicule
        return "Description du véhicule";
    }
}

class Modele : ObjetBase
{
    protected override string GetDescription()
    {
        // Implémentation spécifique pour Modèle
        return "Description du modèle";
    }
}

class Marque : ObjetBase
{
    protected override string GetDescription()
    {
        // Implémentation spécifique pour Marque
        return null; // Exemple où aucune description n'est fournie
    }
}
