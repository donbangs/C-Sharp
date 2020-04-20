using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    class Slownik
    {

        public Dictionary<string, string> diki = new Dictionary<string, string>();
        public Dictionary<int, string> dikiAng = new Dictionary<int, string>();
        public List<string> lista = new List<string>();
        public int x=0;
        public int y=0;
        public int[] tab = new int[20];
        public int ilosc = 12;
        public int iloscLiczb=0;
        public Random losuj = new Random();
        public int pobierz;
        public int wyszukiwanie { get; set; }
 
        public int liczba;
       


        public void WpisaneSlowa()
        {
            diki.Add("car", "samochód");
            dikiAng.Add(1, "car");

            diki.Add("apple", "jablko");
            dikiAng.Add(2, "apple");

            diki.Add("cat", "kot");
            dikiAng.Add(3, "cat");

            diki.Add("dog", "pies");
            dikiAng.Add(4, "dog");

            diki.Add("run", "biegac");
            dikiAng.Add(5, "run");

            diki.Add("water", "woda");
            dikiAng.Add(6, "water");

            diki.Add("download", "pobierz");
            dikiAng.Add(7, "download");

            diki.Add("peach", "brzoskwinia");
            dikiAng.Add(8, "peach");

            diki.Add("rabbit", "krolik");
            dikiAng.Add(9, "rabbit");

            diki.Add("cow", "krowa");
            dikiAng.Add(10, "cow");

            diki.Add("farmer", "rolnik");
            dikiAng.Add(11, "farmer");

            wyszukiwanie = 0;


        }

        public void Dodaj(string ang, string pol)
        {

            diki.Add(ang, pol);
            dikiAng.Add(ilosc, ang);
            ilosc++;
        }
        public string Wyszukaj(string ang)
        {
            return diki[ang];

        }
        public string Test()
        {
            pobierz = losuj.Next(1, ilosc);
         
                for (x = 0; x < tab.Length; x++)
                {
                    if (tab[x] == pobierz)
                    {
                        iloscLiczb = 0;
                        x = -1;
                        pobierz = losuj.Next(1, ilosc);
                    }
                    else
                    {
                        iloscLiczb++;
                    }
                    if (iloscLiczb == (ilosc))
                    {
                        break;
                    }

                }
           
            
            tab[y] = pobierz;
            y++;


           
        
            
            return dikiAng[pobierz];

        }





        public string Sprawdz(string ang, string pol)
        {
            if (diki[ang] == pol)
            {
                return "Dobrze aby tak dalej";
            }
            else
            {
                return "Zle musisz jeszcze pocwiczyc";
            }

        }
        public void Ilosc()
        {
            wyszukiwanie++;
        }
        public void Historia(string szukaj)
        {
            lista.Add(szukaj);

        }
        public void czysc()
        {

            lista.Clear();
            wyszukiwanie = 0;
        }
        public string zwroc(int x)
        {
             return lista[x];
          
        }








}
}
