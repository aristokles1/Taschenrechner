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
            double ersteZahl = view.HoleZahlVomBenutzer();
            string rechenoperator = view.HoleOperatorVomBenutzer();
            double zweiteZahl = view.HoleZahlVomBenutzer();

            // Berechnung ausführen
            model.Berechne(ersteZahl, zweiteZahl, rechenoperator);

            // Ausgabe
            view.GibResultatAus(zweiteZahl, rechenoperator);
            view.WarteAufEndeDurchBenutzer();
        }
    }
}
