class GestionnaireConcret1 : Gestionnaire
{
    public override void Demande(string requete)
    {
        if (requete == "Type1")
        {
            Console.WriteLine("GestionnaireConcret1 traite la requête : " + requete);
        }
        else
        {
            base.Demande(requete);
        }
    }
}