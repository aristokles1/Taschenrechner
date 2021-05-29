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
            RechnerModel model = new RechnerModel();
            model.Berechne(ersteZahl, zweiteZahl, rechenoperator);

            // Ausgabe des Resultats
            ResultatAusgeben(model.Resultat, zweiteZahl, rechenoperator);

            Console.WriteLine();
            HoleBenutzereingabe("Zum Beenden bitte - Return - drücken");
        }

        static string HoleBenutzereingabe(string ausgabeText)
        {
            Console.Write(ausgabeText);
            string zahl = Console.ReadLine();

            return zahl;
        }
                          

        static void ResultatAusgeben(double ergebnis, double Zahl2, string operand)
        {
            // Division durch 0 anmerken
            if ((Zahl2 == 0) && (operand == "/"))
            {
                Console.WriteLine("Division durch 0 ist nicht definiert, Kollege!");
            }
            // Kein gültiger Rechenoperand anmerken
            else if ((operand != "+") && (operand != "-") && (operand != "*") && (operand != "/"))
            {
                Console.WriteLine("Du hast keinen gültigen Rechenoperator eingegeben!");
            }
            else
            {
            Console.WriteLine("Das Resultat ist: {0}", ergebnis);
            }
        }

 
    }
}
