using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Osobyy
{
    public class Osoba
    {
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public DateTime Date { get; set; }
        public Osoba Matka { get; set; }
        public Osoba Ojciec { get; set; }
        public string Miejsce { get; set; }
        public override string ToString()
        {
            return  Imie+ " "+ Nazwisko;
        }

     
        public Osoba(String imie, string nazwisko,DateTime date,string miejsce)
        {
            Imie = imie;
            Nazwisko = nazwisko;
            Date = date;
            Miejsce = miejsce;
        }



    }
}
