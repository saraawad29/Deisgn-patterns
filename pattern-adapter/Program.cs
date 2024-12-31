// See https://aka.ms/new-console-template for more information
Console.WriteLine("Pattern Adapter");
// Utilisation d'un document HTML
Document documentHtml = new DocumentHtml();
documentHtml.SetContenu("Rapport HTML");
documentHtml.Dessine();
documentHtml.Imprime();

// Utilisation d'un document PDF via l'Adapter
Document documentPdf = new DocumentPdf();
documentPdf.SetContenu("Rapport PDF");
documentPdf.Dessine();
documentPdf.Imprime();