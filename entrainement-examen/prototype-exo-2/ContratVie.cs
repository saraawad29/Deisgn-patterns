class ContratVie : Contrat
{
    public int AgeBeneficiaire { get; set; }

    public override Contrat Clone()
    {
        return (ContratVie)this.MemberwiseClone();
    }
}