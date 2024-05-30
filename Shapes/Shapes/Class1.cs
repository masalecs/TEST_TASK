using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Shape
    {

        public double TrianglePlosh(int x, int y, int z)
        {
            if ((x+y<z) || (x+z<y) || (y+z < x))
            {
                return 0;
            }
            double plosh;
            if (Math.Pow(x,2) == Math.Pow(y,2) + Math.Pow(z,2))
            {
                plosh = (y * z) / 2;
                return plosh;
            }
            else if (Math.Pow(y, 2) == Math.Pow(x, 2) + Math.Pow(z, 2))
            {
                plosh = (x * z) / 2;
                return plosh;
            }
            else if (Math.Pow(z, 2) == Math.Pow(x, 2) + Math.Pow(y, 2))
            {
                plosh = (x * y) / 2;
                return plosh;
            }
            int p = (x + y + z) / 2;
            plosh = Math.Sqrt(p * (p - x) * (p - y) * (p - z));
            return plosh;
        }
        public double CirclePlosh(int rad)
        {
            return Math.PI * Math.Pow(rad, 2);
        }
    }
}
