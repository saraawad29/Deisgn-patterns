using System;
using System.Collections.Generic;

abstract class Contrat
{
    public string NomClient { get; set; }
    public DateTime DateDebut { get; set; }
    public decimal Montant { get; set; }
    public List<string> Annexes { get; set; } = new List<string>();

    public abstract Contrat Clone();
}