using System;

namespace Taschenrechner
{
    class Program
    {

        static void Main(string[] args)
        {
            RechnerModel model = new RechnerModel();            
            ConsoleView view = new ConsoleView(model);

            // Eingabe
            string ersteZahlAlsString = view.HoleZahlVomBenutzer();
            string rechenoperator = view.HoleOperatorVomBenutzer();
            string zweiteZahlAlsString = view.HoleZahlVomBenutzer();
            
            // Wandel Text in Gleitkommazahlen
            // TODO: Auslagern in Methode, wenn Struktur umfangreicher geworden ist
            double ersteZahl = Convert.ToDouble(ersteZahlAlsString);
            double zweiteZahl = Convert.ToDouble(zweiteZahlAlsString);

            // Berechnung ausführen
            model.Berechne(ersteZahl, zweiteZahl, rechenoperator);

            // Ausgabe
            view.GibResultatAus(zweiteZahl, rechenoperator);
            Console.WriteLine();
            view.WarteAufEndeDurchBenutzer();
        }


 
    }
}
