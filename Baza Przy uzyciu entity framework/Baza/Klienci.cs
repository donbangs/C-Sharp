using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baza
{
    class Klienci
    {
        public override string ToString()
        {
            return Imie + " Id Samochodu "+ SamochodyId ;
        }
        public int KlienciId { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public string Pesel { get; set; }
        public string NumerDowodu { get; set; }
        

        public int SamochodyId { get; set; }
        public Samochody Samochody { get; set; }

    }
}
