namespace Übungstest{

class Hilfsklassen
{
    public string DatumZuSaison(DateTime datum)
    {
        switch (datum.Month)
        {
            case 12:
                return "Winter";
            case 1:
                return "Winter";
            case 2:
                return "Winter";
            case 3:
                return "Frühling";
            case 4:
                return "Frühling";
            case 5:
                return "Frühling";
            case 6:
                return "Sommer";
            case 7:
                return "Sommer";
            case 8:
                return "Sommer";
            case 9:
                return "Herbst";
            case 10:
                return "Herbst";
            case 11:
                return "Herbst";
            default:
                return "Gebe ein gültiges Datum mit einem gültigen monat (01-12) an";
        }
    }
}

}