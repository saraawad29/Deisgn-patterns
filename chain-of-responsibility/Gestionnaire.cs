abstract class Gestionnaire
{
    protected Gestionnaire suivant; // Référence au prochain gestionnaire dans la chaîne

    public void SetSuivant(Gestionnaire suivant)
    {
        this.suivant = suivant;
    }

    public virtual void Demande(string requete)
    {
        if (suivant != null)
        {
            suivant.Demande(requete);
        }
        else
        {
            Console.WriteLine("Requête non traitée.");
        }
    }
}