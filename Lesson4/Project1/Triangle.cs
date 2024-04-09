using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    class Triangle: Figura
    {
        private double side;
        public Triangle(double side)
        {
            this.side = side;
        }
        public double Side { get => side; set => side = value; }

        public double perimeter()
        {
            return 3 * side;
        }

        public double square()
        {
            return (Math.Sqrt(3)*Math.Pow(side, 2)) / 4;
        }
    }
}
