public class ParticulierDocumentFactory : IDocumentFactory
{
    public IBankDocument CreateRIB() => new ReleveIdentiteBancaireSimplifie();
    public IBankDocument CreateAttestation() => new AttestationCompteStandard();
}

public class ProfessionnelDocumentFactory : IDocumentFactory
{
    public IBankDocument CreateRIB() => new ReleveIdentiteBancaireDetaille();
    public IBankDocument CreateAttestation() => new AttestationCompteLegalisee();
}