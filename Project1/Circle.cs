using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    class Circle: Figura
    {
        private double radius;
        public Circle(double radius)
        {
            this.radius = radius;
        }
        public double Radius { get => radius; set => radius = value; }

        public double perimeter()
        {
            return 2 * Math.PI * radius;
        }

        public double square()
        {
            return Math.PI * Math.Pow(radius, 2);
        }
    }
}
