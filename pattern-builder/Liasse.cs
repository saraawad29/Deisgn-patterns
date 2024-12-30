public abstract class Liasse
{
    protected List<string> documents = new List<string>();

    public abstract void AjouteDocument(string document);
    public abstract void Imprime();
}

public class LiasseHtml : Liasse
{
    public override void AjouteDocument(string document)
    {
        if (!string.IsNullOrEmpty(document))
            documents.Add(document);
    }

    public override void Imprime()
    {
        Console.WriteLine("Liasse HTML :");
        foreach (var document in documents)
            Console.WriteLine(document);
    }
}

public class LiassePdf : Liasse
{
    public override void AjouteDocument(string document)
    {
        if (!string.IsNullOrEmpty(document))
            documents.Add(document);
    }

    public override void Imprime()
    {
        Console.WriteLine("Liasse PDF :");
        foreach (var document in documents)
            Console.WriteLine(document);
    }
}
