using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taschenrechner
{
    class ConsoleView
    {
        private RechnerModel model;

        public ConsoleView(RechnerModel model)
        {
            this.model = model;
        }
        public string HoleBenutzereingabe(string ausgabeText)
        {
            Console.Write(ausgabeText);
            string zahl = Console.ReadLine();

            return zahl;
        }
        public void GibResultatAus(double Zahl2, string operand)
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
                Console.WriteLine("Das Resultat ist: {0}", model.Resultat);
            }
        }
    }
}
