using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tumakov2
{
    internal class Rectangle: Point
    {
        public int a { get; set; }
        public int b { get; set; }
        public Rectangle(int a, int b)
        {
            this.a = a;
            this.b = b;
        }

        public int Srectangle(int a, int b)
        {
            
            int S = a * b;
            return S;
        }
    }
}
