using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taschenrechner
{
    class RechnerModel
    {
        public double Resultat { get; private set; }
        public string Operation { get; set; }
        public double ErsteZahl { get; set; }
        public double ZweiteZahl { get; set; }

        public RechnerModel()
        {
            Resultat = 0;
            Operation = "unbekannt";
            ZweiteZahl = 0;
        }

        public void Berechne()
        {

            switch (Operation)
            {
                case "+":
                    Resultat = Addiere(ErsteZahl, ZweiteZahl);
                    break;

                case "-":
                    Resultat = Subtrahiere(ErsteZahl, ZweiteZahl);
                    break;

                case "/":
                    // Division durch 0 abfangen
                    if (ZweiteZahl != 0)
                    {
                        Resultat = Dividiere(ErsteZahl, ZweiteZahl);
                    }
                    break;
                case "*":
                    Resultat = Multipliziere(ErsteZahl, ZweiteZahl);
                    break;

                default:
                    break;
            }
        }

        private double Addiere(double ersterSummand, double zweiterSummand)
        {
            double summe = ersterSummand + zweiterSummand;

            return summe;
        }

        private double Subtrahiere(double minuend, double subtrahend)
        {
            double differenz = minuend - subtrahend;

            return differenz;
        }

        private double Multipliziere(double ersterFaktor, double zweiterFaktor)
        {
            double produkt = ersterFaktor * zweiterFaktor;

            return produkt;
        }

        private double Dividiere(double dividend, double divisor)
        {
            double quotient = dividend / divisor;

            return quotient;
        }
    }
}
