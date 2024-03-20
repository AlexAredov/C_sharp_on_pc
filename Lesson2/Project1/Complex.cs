using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    class Complex
    {
        private double real_part;
        private double imaginary_part;

        public Complex(double real_part, double imaginary_part)
        {
            this.real_part = real_part;
            this.imaginary_part = imaginary_part;
        }

        public Complex(Complex complex)
        {
            real_part = complex.Re;
            imaginary_part = complex.Im;
        }

        public double Re
        {
            get
            {
                return real_part;
            }
        }

        public double Im
        {
            get
            {
                return imaginary_part;
            }
        }

        public double Abs()
        {
            return Math.Sqrt(Math.Pow(real_part, 2) + Math.Pow(imaginary_part, 2));
        }
    }
}
