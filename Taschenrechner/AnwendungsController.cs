using System;

namespace Taschenrechner
{
    class AnwendungsController
    {
        private ConsoleView view;
        private RechnerModel model;

        public AnwendungsController(ConsoleView view, RechnerModel model)
        {
            this.view = view;
            this.model = model;
        }

        public void Ausfuehren()
        {
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
