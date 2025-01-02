class ContratAutomobile : Contrat
{
    public string Immatriculation { get; set; }

    public override Contrat Clone()
    {
        return (ContratAutomobile)this.MemberwiseClone();
    }
}