using System.Reflection;

namespace Übungstest;

public class Rabattaktion
{
    public string Name
    {
        get => name;
        set
        {
            if (value.Length != 0) name = value;
            else throw new Exception("name ist leer");
        }
    }
    public bool IstJetzt
    {
        get => istJetzt;
        set => istJetzt = value;
    }

    public DateTime StartDatum
    {
        get => startDatum;
        set
        {
            if (value.Date < endDatum.Date) startDatum = value;
            else throw new Exception("enddatum ist grösser");
        } 
    }

    public DateTime EndDatum
    {
        get => endDatum;
        set => endDatum = value;
    }

    public Artikel Artikel
    {
        get => artikel;
        set
        {
            artikel = value;
            umsatz += value.preis * prozent;
        }
    }

    public double Umsatz
    {
        get => umsatz;
    }

    public double Prozent
    {
        get => prozent;
        set => prozent = 1 - (value / 100);
    }


    private string name;
    private bool istJetzt;  
    private DateTime startDatum;
    private DateTime endDatum;
    private Artikel artikel;
    private double umsatz;
    private double prozent;
    
    
}