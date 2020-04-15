using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct
{
    struct Point3C
    {

        public override string ToString()
        {
            return x.ToString() + " , " + y.ToString() + " , " + z.ToString();
        }

      public  double x;
      public double y;
      public double z;


        public Point3C(double a, double b, double c)   
        {
            x = a;
            y = b;
            z = c;
         
        }

       
    }

}
