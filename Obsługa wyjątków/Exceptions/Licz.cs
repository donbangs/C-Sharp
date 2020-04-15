using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class Licz
    {
        public double obwod_trojkata(string q, string w, string e)
        {
            double a;
            double b;
            double c;

            bool result = double.TryParse(q,out a);
            bool result2 = double.TryParse(w,out b);
            bool result3 = double.TryParse(e,out c);

            if (result == true && result2 == true && result3 == true)
            {

                if (a < b + c && b < a + c && c < b + a)
                {
                    return a + b + c;
                }
                else
                {
                    throw new FormatException();
                }
            }
            else {
                throw new FormatException();
            }
          
        }
        public double pole_kwadratu(string q, string w)
        {
            double a;
            double b;

            bool result = double.TryParse(q, out a);
            bool result2 = double.TryParse(w, out b);
            if (result == true && result2 == true)
            {
                if (a == b)
                {
                    return a * a;
                }
                else
                {
                    throw new FormatException();
                }
            }
            else
            {
                throw new FormatException();
            }
        }
        public double dzielenie(string q, string w)
        {
            double a;
            double b;

            bool result = double.TryParse(q, out a);
            bool result2 = double.TryParse(w, out b);
            if (result == true && result2 == true)
            {
                if (b != 0)
                {
                    return a / b;
                }
                else
                {
                    throw new FormatException();
                }
            }
            else {
                throw new FormatException();
            }

        }
        public double mnozenie(string q, string w)
        {
            double a;
            double b;

            bool result = double.TryParse(q, out a);
            bool result2 = double.TryParse(w, out b);
            if (result == true && result2 == true)
            {
                return a * b;
            }
            else {

                throw new FormatException();
            }
        }



    }
}
