namespace Übungstest;
class Test
{
    static void Main(string[] args)
    {
        // Aufgabe 1
        DateTime date = new DateTime(22, 5, 01);
        Hilfsklassen hilfsklassen = new Hilfsklassen();
        Console.WriteLine(hilfsklassen.DatumZuSaison(date));
        
        // Aufgabe 2

        Artikel Schal = new Artikel(name: "schal", preis: 44.5);
        Artikel Ring = new Artikel(name: "Ring", preis: 25.9);
        Artikel Schuh = new Artikel(name: "Adidas", preis: 100.9);
      
        Rabattaktion aktion = new Rabattaktion();

        aktion.Name = "Rabatt";
        aktion.IstJetzt = true;
        aktion.EndDatum = new DateTime(2022, 4, 30);
        aktion.StartDatum = new DateTime(2022, 3, 1);
        aktion.Prozent = 20;
        aktion.Artikel = Schal;
        aktion.Artikel = Ring;
        aktion.Artikel = Schuh;
        
        Console.WriteLine(aktion.Umsatz);
    }
}