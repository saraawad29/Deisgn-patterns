// See https://aka.ms/new-console-template for more information
Console.WriteLine("Pattern Bridge");
FormulaireImpl htmlImpl = new FormulaireHtmlImpl();
FormulaireImmatriculation formulaireFrance = new FormulaireImmatriculationFrance(htmlImpl);
formulaireFrance.Affiche();
formulaireFrance.GereSaisie();
formulaireFrance.Affiche();

FormulaireImpl appletImpl = new FormulaireAppletImpl();
FormulaireImmatriculation formulaireLuxembourg = new FormulaireImmatriculationLuxembourg(appletImpl);
formulaireLuxembourg.Affiche();
formulaireLuxembourg.GereSaisie();
formulaireLuxembourg.Affiche();