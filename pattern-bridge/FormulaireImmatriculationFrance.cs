public class FormulaireImmatriculationFrance : FormulaireImmatriculation
{
    private string? Immatriculation;

    public FormulaireImmatriculationFrance(FormulaireImpl impl) : base(impl) { }

    public override void Affiche()
    {
        Impl.DessineTexte("Formulaire d'immatriculation - France");
        Impl.DessineTexte("Numéro d'immatriculation existant : " + (Immatriculation ?? "Non spécifié"));
    }

    public override void GereSaisie()
    {
        Immatriculation = Impl.GereZoneTexte();
    }
}