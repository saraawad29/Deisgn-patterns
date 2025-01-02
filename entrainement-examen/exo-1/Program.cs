// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


class Program
{
    static void Main(string[] args)
    {
        // Example for Particulier
        IDocumentFactory particulierFactory = new ParticulierDocumentFactory();
        IBankDocument ribParticulier = particulierFactory.CreateRIB();
        IBankDocument attestationParticulier = particulierFactory.CreateAttestation();
        ribParticulier.Generate();
        ribParticulier.PrintLogo();
        attestationParticulier.Generate();
        attestationParticulier.PrintLogo();

        Console.WriteLine();

        // Example for Professionnel
        IDocumentFactory professionnelFactory = new ProfessionnelDocumentFactory();
        IBankDocument ribProfessionnel = professionnelFactory.CreateRIB();
        IBankDocument attestationProfessionnel = professionnelFactory.CreateAttestation();
        ribProfessionnel.Generate();
        ribProfessionnel.PrintLogo();
        attestationProfessionnel.Generate();
        attestationProfessionnel.PrintLogo();
    }
}