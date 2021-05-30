using System;

namespace Taschenrechner
{
    class Program
    {

        static void Main(string[] args)
        {
            RechnerModel model = new RechnerModel();            
            ConsoleView view = new ConsoleView(model);

            // Eingabe der beiden Zahlen
            string ersteZahlAlsString = view.HoleBenutzereingabe("Bitte gib die erste Zahl ein: ");
            string zweiteZahlAlsString = view.HoleBenutzereingabe("Bitte gib die zweite Zahl ein: ");
            // Eingabe der Rechenoperation
            string rechenoperator = view.HoleBenutzereingabe("Bitte gib einen Rechenoperator ein (+ oder - oder * oder /): ");
            
            // Wandel Text in Gleitkommazahlen
            // TODO: Auslagern in Methode, wenn Struktur umfangreicher geworden ist
            double ersteZahl = Convert.ToDouble(ersteZahlAlsString);
            double zweiteZahl = Convert.ToDouble(zweiteZahlAlsString);

            // Berechnung ausführen
            model.Berechne(ersteZahl, zweiteZahl, rechenoperator);

            // Ausgabe des Resultats
            view.GibResultatAus(zweiteZahl, rechenoperator);

            Console.WriteLine();
            view.HoleBenutzereingabe("Zum Beenden bitte - Return - drücken");
        }


 
    }
}
