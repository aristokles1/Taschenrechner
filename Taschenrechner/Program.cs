using System;

namespace Taschenrechner
{
    class Program
    {

        static void Main(string[] args)
        {
            // User Story "Addieren": Als Benutzer möchte ich zwei Zahlen eingeben, um deren Summe berechnen zu lassen.

            
            double resultat = 0;


            // Eingabe der beiden Zahlen
            string ersteZahlAlsString = HoleBenutzereingabe("Bitte gib die erste Zahl ein: ");
            string zweiteZahlAlsString = HoleBenutzereingabe("Bitte gib die zweite Zahl ein: ");
            // Eingabe der Rechenoperation
            string rechenoperator = HoleBenutzereingabe("Bitte gib die Rechenoperation ein (+ oder -): ");
            
            // Wandel Text in Gleitkommazahlen
            // TODO: Auslagern in Methode, wenn Struktur umfangreicher geworden ist
            double ersteZahl = Convert.ToDouble(ersteZahlAlsString);
            double zweiteZahl = Convert.ToDouble(zweiteZahlAlsString);

            // Berechnung ausführen
            switch (rechenoperator)
            {
                case "+":
                    resultat = Addiere(ersteZahl, zweiteZahl);
                    Console.WriteLine("Das Resultat ist: {0}", resultat);
                    break;

                case "-":
                    resultat = Subtrahiere(ersteZahl, zweiteZahl);
                    Console.WriteLine("Das Resultat ist: {0}", resultat);
                    break;

                case "/":
                case "*":
                    Console.WriteLine("Dieser Rechenoperator wird in Kürze unterstützt!");
                    break;

                default:  
                    Console.WriteLine("Du hast einen ungültigen Rechenoperator eingegeben!");
                    break;
             
            }


            // Ausgabe
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
    }
}
