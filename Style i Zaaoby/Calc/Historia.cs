using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
    class Historia
    {
      public  double x { get; set; }
      public  double z { get; set; }
      public  double wynik { get; set; }

        public override string ToString()
        {
            return x.ToString() +" "+ z.ToString()+" "+ wynik.ToString();
        }

        public Historia(double x,double z,double wynik)
        {
            this.x = x;
            this.z = z;
            this.wynik = wynik;
        }
    }
}
