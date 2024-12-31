public class FormulaireHtmlImpl : FormulaireImpl
{
    public void DessineTexte(string texte)
    {
        Console.WriteLine($"[HTML] {texte}");
    }

    public string GereZoneTexte()
    {
        Console.Write("[HTML] Saisir une valeur : ");
        return Console.ReadLine()!;
    }
}