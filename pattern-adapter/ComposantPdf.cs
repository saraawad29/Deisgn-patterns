public class ComposantPdf
{
    public void PdfFixeContenu(string contenu)
    {
        Console.WriteLine($"PDF : Contenu fixé -> {contenu}");
    }

    public void PdfPrepareAffichage()
    {
        Console.WriteLine("PDF : Préparation de l'affichage...");
    }

    public void PdfRafraichit()
    {
        Console.WriteLine("PDF : Rafraîchissement...");
    }

    public void PdfTermineAffichage()
    {
        Console.WriteLine("PDF : Terminaison de l'affichage.");
    }

    public void PdfEnvoieImprimante()
    {
        Console.WriteLine("PDF : Envoi à l'imprimante.");
    }
}