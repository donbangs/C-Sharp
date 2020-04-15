using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct
{
    class Point
    {
        public override string ToString()
        {
            return x.ToString() + " , " + y.ToString() + " , " + z.ToString();
        }
        public double x;
        public double y;
        public double z;

        public Point(double x,double y ,double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
    }
}
