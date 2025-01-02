class ContratHabitation : Contrat
{
    public string AdresseHabitation { get; set; }

    public override Contrat Clone()
    {
        return (ContratHabitation)this.MemberwiseClone();
    }
}