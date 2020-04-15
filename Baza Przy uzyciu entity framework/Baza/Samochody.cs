using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baza
{
    class Samochody
    {
        public override string ToString()
        {
            return Marka+"   "+Model+ " Id: "+SamochodyId;
        }
        public int SamochodyId { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }
        public int KonieMechaniczne { get; set; }
        public string Rok { get; set; }
        public ICollection<Klienci> Kliencis { get; set; }
    }
}
