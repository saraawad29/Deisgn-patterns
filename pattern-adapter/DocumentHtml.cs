public class DocumentHtml : Document
{
    private string contenu;

    public void SetContenu(string contenu)
    {
        this.contenu = contenu;
    }

    public void Dessine()
    {
        Console.WriteLine($"<HTML> Dessin du contenu : {contenu}</HTML>");
    }

    public void Imprime()
    {
        Console.WriteLine($"<HTML> Impression du contenu : {contenu}</HTML>");
    }
}
