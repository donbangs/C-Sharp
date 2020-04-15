using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delagaty
{
    class Delegaty
    {
        public int x;
        public int y;
        public delegate double DelOperacja(double l1);
        public delegate double potega(double a);
      
        public Delegaty()
        {
            x = -1;
            y =-1;
        }

        public static double Dodawanie(double liczba, double liczba2)
        {
            return liczba + liczba2;
        }
        public static double odejmowanie(double liczba, double liczba2)
        {
            return liczba - liczba2;
        }
        public static double mnozenie(double liczba1, double liczba2)
        {
            return liczba1 * liczba2;
        }
        public static double dzielenie(double liczba, double liczba2)
        {
            return liczba / liczba2;
        }

        public static double x2(double liczba)
        {
            return liczba * liczba;
        }
        public static double x3(double liczba)
        {
            return liczba * liczba * liczba;
        }

        public static double x4(double liczba)
        {
            return liczba * liczba * liczba * liczba;
        }

        public  potega zwroc(int x)
        {
            if (x == 2)
            {
               return  new potega(x2);
            }
            else if (x == 3)
            {
                return new potega(x3);
            }
            else
            {
                return new potega(x4);
            }

        }
    
        public double[] Operacja(DelOperacja operacja,double [] tab)
        {

            for (int x = 0; x < tab.Length; x++)
            {
                tab[x] = operacja(tab[x]);

            }


            return tab;

        }


    }
}
