public abstract class FormulaireImmatriculation
{
    protected FormulaireImpl Impl;

    protected FormulaireImmatriculation(FormulaireImpl impl)
    {
        Impl = impl;
    }

    public abstract void Affiche();
    public abstract void GereSaisie();
}