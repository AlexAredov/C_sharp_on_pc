using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    class Square: Figura
    {
        private double side;
        public Square(double side)
        {
            this.side = side;
        }
        public double Side { get => side; set => side = value; }

        public double perimeter()
        {
            return 4 * side;
        }

        public double square()
        {
            return side * side;
        }
    }
}
