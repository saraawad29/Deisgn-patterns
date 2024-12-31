public class FormulaireAppletImpl : FormulaireImpl
{
    public void DessineTexte(string texte)
    {
        Console.WriteLine($"[Applet] {texte}");
    }

    public string GereZoneTexte()
    {
        Console.Write("[Applet] Saisir une valeur : ");
        return Console.ReadLine()!;
    }
}