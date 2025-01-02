class GestionnaireConcret2 : Gestionnaire
{
    public override void Demande(string requete)
    {
        if (requete == "Type2")
        {
            Console.WriteLine("GestionnaireConcret2 traite la requête : " + requete);
        }
        else
        {
            base.Demande(requete);
        }
    }
}