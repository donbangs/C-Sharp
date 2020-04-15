using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13
{
    class Point3D : IComparable
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        public Point3D(double x, double y, double z)
        {
            X = x; Y = y; Z = z;
        }
        public override string ToString()
        {
            return "X:" + X.ToString() + " Y:" + Y.ToString() + " Z:" + Z.ToString();
        }

        public int CompareTo(object obj)
        {
            if (obj == null) return 1;
            Point3D p = obj as Point3D;
            switch (X.CompareTo(p.X))
            {
                case -1: return -1;
                case 0:
                    switch (Y.CompareTo(p.Y))
                    {
                        case -1:
                            return -1;
                        case 0:
                            switch (Z.CompareTo(p.Z))
                            {
                                case -1:
                                    return -1;
                                case 0:
                                    return 0;
                                case 1:
                                    return 1;
                            }
                            break;
                        case 1:
                            return 1;
                    }
                    break;
                case 1: return 1;
            }
            throw new NotImplementedException();
        }
    }
}
