// See https://aka.ms/new-console-template for more information

using System;
//Console.WriteLine("Chain of responsibility");


class Program
{
    static void Main(string[] args)
    {
        // Création des objets dans la chaîne
        ObjetBase vehicule1 = new Vehicule();
        ObjetBase modele1 = new Modele();
        ObjetBase marque1 = new Marque();

        // Mise en place de la chaîne
        vehicule1.SetSuivant(modele1);
        modele1.SetSuivant(marque1);

        // Demande de description via Vehicule
        Console.WriteLine("Description obtenue : " + vehicule1.DonneDescription());


        // Création des gestionnaires
        Gestionnaire gestionnaire1 = new GestionnaireConcret1();
        Gestionnaire gestionnaire2 = new GestionnaireConcret2();

        // Mise en place de la chaîne
        gestionnaire1.SetSuivant(gestionnaire2);

        // Exécution des requêtes
        Console.WriteLine("Envoi d'une requête de Type1 :");
        gestionnaire1.Demande("Type1");

        Console.WriteLine("Envoi d'une requête de Type2 :");
        gestionnaire1.Demande("Type2");

        Console.WriteLine("Envoi d'une requête de Type3 :");
        gestionnaire1.Demande("Type3"); // Non traité
    }

}
