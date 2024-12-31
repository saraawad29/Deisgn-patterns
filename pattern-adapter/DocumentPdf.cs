public class DocumentPdf : Document
{
    private readonly ComposantPdf outilPdf = new ComposantPdf();
    private string contenu;

    public void SetContenu(string contenu)
    {
        this.contenu = contenu;
        outilPdf.PdfFixeContenu(contenu);
    }

    public void Dessine()
    {
        outilPdf.PdfPrepareAffichage();
        outilPdf.PdfRafraichit();
        outilPdf.PdfTermineAffichage();
    }

    public void Imprime()
    {
        outilPdf.PdfEnvoieImprimante();
    }
}