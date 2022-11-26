using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tumakov2
{
    internal class Circle: Point
    {
        public double R { get; set; }
        public double Scircle(double R)
        {
            double S = Math.PI * Math.Pow(R, 2);
            return S;
        }
    }
}
