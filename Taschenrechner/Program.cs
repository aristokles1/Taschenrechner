using System;

namespace Taschenrechner
{
    class Program
    {

        static void Main(string[] args)
        {
            // User Story "Addieren": Als Benutzer möchte ich zwei Zahlen eingeben, um deren Summe berechnen zu lassen.

            // Eingabe der beiden Zahlen
            string ersteZahlAlsString = HoleBenutzereingabe("Bitte gib die erste Zahl ein: ");
            string zweiteZahlAlsString = HoleBenutzereingabe("Bitte gib die zweite Zahl ein: ");

            // Wandel Text in Gleitkommazahlen
            // TODO: Auslagern in Methode, wenn Struktur umfangreicher geworden ist
            double ersterZahl = Convert.ToDouble(ersteZahlAlsString);
            double zweiteZahl = Convert.ToDouble(zweiteZahlAlsString);

            // Berechnung ausführen
            double ergebnis = Addiere(ersterZahl, zweiteZahl);

            // Ausgabe
            Console.WriteLine("Das Ergebnis ist: {0}", ergebnis);
            Console.WriteLine();
            HoleBenutzereingabe("Zum Beenden bitte - Return - drücken");
        }

        static string HoleBenutzereingabe(string ausgabeText)
        {
            Console.Write(ausgabeText);
            string zahl = Console.ReadLine();

            return zahl;
        }

        static double Addiere(double ersterSummand, double zweiterSummand)
        {
            double summe = ersterSummand + zweiterSummand;

            return summe;
        }

        static double Subtrahiere(double minuend, double subtrahend)
        {
            double differenz = minuend - subtrahend;

            return differenz;
        }

        static void WarteAufBenutzereingabe()
        {
            Console.WriteLine();
            Console.Write("Zum Beenden bitte - Return - drücken");
            Console.ReadLine();
        }
    }
}
