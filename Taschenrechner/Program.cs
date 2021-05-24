using System;

namespace Taschenrechner
{
    class Program
    {
        static void Main(string[] args)
        {
            // User Story "Addieren": Als Benutzer möchte ich zwei Zahlen eingeben, um deren Summe berechnen zu lassen.

            // Eingabe der beiden Summanden
            Console.Write("Bitte gib den ersten Summanden ein: ");
            string ersterSummand = Console.ReadLine();
            Console.Write("Bitte gib den zweiten Summanden ein: ");
            string zweiterSummand = Console.ReadLine();

            // Wandel Text in Gleitkommazahlen
            double ersterSummandAlsZahl = Convert.ToDouble(ersterSummand);
            double zweiterSummandAlsZahl = Convert.ToDouble(zweiterSummand);

            // Berechnung ausführen
            double summe = Addiere(ersterSummandAlsZahl, zweiterSummandAlsZahl);

            // Ausgabe
            Console.WriteLine("Die Summe ist: {0}", summe);
            WarteAufBenutzereingabe();
        }

        static double Addiere(double ersterSummand, double zweiterSummand)
        {
            double summe = ersterSummand + zweiterSummand;
            return summe;
        }

        static void WarteAufBenutzereingabe()
        {
            Console.WriteLine();
            Console.Write("Zum Beenden bitte - Return - drücken");
            Console.ReadLine();
        }
    }
}
