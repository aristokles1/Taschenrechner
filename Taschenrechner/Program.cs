using System;

namespace Taschenrechner
{
    class Program
    {
        // METHODE DEFINIEREN in 7 Schritten
        // 1. (optional) Modifizierer definieren
        // 2. Datentyp des Rückgabewertes definieren
        // 3. Methodennamen definieren
        // 4. Runde Klammern an den Methodennamen anfügen
        // 5. Überlegen welche Parameter benötigt werden (optional diese definieren)
        // 6. Geschweifte Klammern einfügen
        // 7. Methode implementieren (Anweisungen in den Methodenrumpf schreiben)

        static void Main(string[] args)
        {
            // User Story "Addieren": Als Benutzer möchte ich zwei Zahlen eingeben, um deren Summe berechnen zu lassen.

            // Eingabe der beiden Summanden
            string ersterSummand = HoleSummanden("Bitte gib den ersten Summanden ein: ");
            string zweiterSummand = HoleSummanden("Bitte gib den zweiten Summanden ein: ");

            // Wandel Text in Gleitkommazahlen
            double ersterSummandAlsZahl = Convert.ToDouble(ersterSummand);
            double zweiterSummandAlsZahl = Convert.ToDouble(zweiterSummand);

            // Berechnung ausführen
            double summe = Addiere(ersterSummandAlsZahl, zweiterSummandAlsZahl);

            // Ausgabe
            Console.WriteLine("Die Summe ist: {0}", summe);
            WarteAufBenutzereingabe();
        }

        static string HoleSummanden(string ausgabeText)
        {
            Console.Write(ausgabeText);
            string summand = Console.ReadLine();

            return summand;
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
