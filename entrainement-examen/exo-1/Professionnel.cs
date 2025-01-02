public class ReleveIdentiteBancaireDetaille : IBankDocument
{
    public void Generate() => Console.WriteLine("Génération du RIB détaillé avec SIRET pour Professionnel.");
    public void PrintLogo() => Console.WriteLine("Ajout du logo de la banque sur le RIB détaillé.");
}

public class AttestationCompteLegalisee : IBankDocument
{
    public void Generate() => Console.WriteLine("Génération de l'attestation légalisée avec mentions spécifiques.");
    public void PrintLogo() => Console.WriteLine("Ajout du logo de la banque sur l'attestation légalisée.");
}