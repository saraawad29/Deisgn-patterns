public class FormulaireImmatriculationLuxembourg : FormulaireImmatriculation
{
    private string? Immatriculation;

    public FormulaireImmatriculationLuxembourg(FormulaireImpl impl) : base(impl) { }

    public override void Affiche()
    {
        Impl.DessineTexte("Formulaire d'immatriculation - Luxembourg");
        Impl.DessineTexte("Numéro d'immatriculation existant : " + (Immatriculation ?? "Non spécifié"));
    }

    public override void GereSaisie()
    {
        Immatriculation = Impl.GereZoneTexte();
    }
}