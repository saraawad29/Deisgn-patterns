public class ReleveIdentiteBancaireSimplifie : IBankDocument
{
    public void Generate() => Console.WriteLine("Génération du RIB simplifié pour Particulier.");
    public void PrintLogo() => Console.WriteLine("Ajout du logo de la banque sur le RIB simplifié.");
}

public class AttestationCompteStandard : IBankDocument
{
    public void Generate() => Console.WriteLine("Génération de l'attestation standardisée pour Particulier.");
    public void PrintLogo() => Console.WriteLine("Ajout du logo de la banque sur l'attestation standardisée.");
}