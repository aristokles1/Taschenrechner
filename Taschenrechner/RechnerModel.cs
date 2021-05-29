using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taschenrechner
{
    class RechnerModel
    {
        public double Berechne(double Zahl1, double Zahl2, string operation)
        {
            double resultat = 0;

            switch (operation)
            {
                case "+":
                    resultat = Addiere(Zahl1, Zahl2);
                    break;

                case "-":
                    resultat = Subtrahiere(Zahl1, Zahl2);
                    break;

                case "/":
                    // Division durch 0 abfangen
                    if (Zahl2 != 0)
                    {
                        resultat = Dividiere(Zahl1, Zahl2);
                    }
                    break;
                case "*":
                    resultat = Multipliziere(Zahl1, Zahl2);
                    break;

                default:
                    break;
            }
            return resultat;
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
