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

        public RechnerModel()
        {
            Resultat = 0;
        }

        public void Berechne(double Zahl1, double Zahl2, string operation)
        {
            switch (operation)
            {
                case "+":
                    Resultat = Addiere(Zahl1, Zahl2);
                    break;

                case "-":
                    Resultat = Subtrahiere(Zahl1, Zahl2);
                    break;

                case "/":
                    // Division durch 0 abfangen
                    if (Zahl2 != 0)
                    {
                        Resultat = Dividiere(Zahl1, Zahl2);
                    }
                    break;
                case "*":
                    Resultat = Multipliziere(Zahl1, Zahl2);
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
