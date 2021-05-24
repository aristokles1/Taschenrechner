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
            string rechenoperator = HoleBenutzereingabe("Bitte gib einen Rechenoperator ein (+ oder - oder * oder /): ");
            
            // Wandel Text in Gleitkommazahlen
            // TODO: Auslagern in Methode, wenn Struktur umfangreicher geworden ist
            double ersteZahl = Convert.ToDouble(ersteZahlAlsString);
            double zweiteZahl = Convert.ToDouble(zweiteZahlAlsString);

            // Berechnung ausführen
            resultat = BerechnungDurchfuehren(ersteZahl, zweiteZahl, rechenoperator);

            // Ausgabe
            ResultatAusgeben(resultat, zweiteZahl, rechenoperator);
            Console.WriteLine();
            HoleBenutzereingabe("Zum Beenden bitte - Return - drücken");
        }

        static string HoleBenutzereingabe(string ausgabeText)
        {
            Console.Write(ausgabeText);
            string zahl = Console.ReadLine();

            return zahl;
        }
        
        static double BerechnungDurchfuehren(double Zahl1, double Zahl2, string operand)
        {
            double ergebnis = 0;

            switch (operand)
            {
                case "+":
                    ergebnis = Addiere(Zahl1, Zahl2);
                    break;


                case "-":
                    ergebnis = Subtrahiere(Zahl1, Zahl2);
                    break;

                case "/":
                    if (Zahl2 != 0)
                    {
                        ergebnis = Dividiere(Zahl1, Zahl2);
                    }
                    break;
                case "*":
                    ergebnis = Multipliziere(Zahl1, Zahl2);
                    break;

                default:
                    break;

            }
                return ergebnis;
        }                   

        static void ResultatAusgeben(double ergebnis, double Zahl2, string operand)
        {
            if ((Zahl2 == 0) && (operand == "/"))
            {
                Console.WriteLine("Division durch 0 ist nicht definiert, Kollege!");
            }
            else if ((operand != "+") && (operand != "-") && (operand != "*") && (operand != "/"))
            {
                Console.WriteLine("Du hast keinen gültigen Rechenoperator eingegeben!");
            }
            else
            {
            Console.WriteLine("Das Resultat ist: {0}", ergebnis);
            }

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

        static double Multipliziere(double ersterFaktor, double zweiterFaktor)
        {
            double produkt = ersterFaktor * zweiterFaktor;

            return produkt;
        }

        static double Dividiere(double dividend, double divisor)
        { 
            double quotient = dividend / divisor;

            return quotient;           
        }
    }
}
