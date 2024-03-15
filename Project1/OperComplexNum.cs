using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    static class OperComplexNum
    {
        public static Complex Addition(Complex num1, Complex num2)
        {
            return new Complex(
                num1.Re + num2.Re, 
                num1.Im + num2.Im);
        }

        public static Complex Addition(Complex num1, double num2)
        {
            return new Complex(
                num1.Re + num2,
                num1.Im);
        }

        public static Complex Subtraction(Complex num1, Complex num2)
        {
            return new Complex(
                num1.Re - num2.Re, 
                num1.Im - num2.Im);
        }

        public static Complex Subtraction(Complex num1, double num2)
        {
            return new Complex(
                num1.Re - num2, 
                num1.Im);
        }

        public static Complex Subtraction(double num1, Complex num2)
        {
            return new Complex(
                num1 - num2.Re,
                num2.Im);
        }

        public static Complex Multiplication(Complex num1, Complex num2)
        {
            return new Complex(
                (num1.Re * num2.Re) - (num1.Im * num2.Im), 
                (num1.Re * num2.Im) + (num1.Im * num2.Re));
        }

        public static Complex Multiplication(Complex num1, double num2)
        {
            return new Complex(
                num1.Re * num2, 
                num1.Im * num2);
        }

        public static Complex Division(Complex num1, Complex num2)
        {
            return new Complex(
                ((num1.Re * num2.Re) + (num1.Im * num2.Im)) / (Math.Pow(num2.Re, 2) + Math.Pow(num2.Im, 2)),
                ((num1.Im * num2.Re) + (num1.Re * num2.Im)) / (Math.Pow(num2.Re, 2) + Math.Pow(num2.Im, 2)));
        }

        public static Complex Division(Complex num1, double num2)
        {
            return new Complex(
                num1.Re / num2, 
                num1.Im / num2);
        }

        public static Complex Division(double num1, Complex num2)
        {
            return new Complex(
                num1 / num2.Re,
                num1 / num2.Im);
        }

        public static Complex OperCompNum(Complex num1, Complex num2, string sign)
        {
            switch (sign)
            {
                case "+":
                    return OperComplexNum.Addition(num1, num2);
                case "-":
                    return OperComplexNum.Subtraction(num1, num2);
                case "*":
                    return OperComplexNum.Multiplication(num1, num2);
                case "/":
                    return OperComplexNum.Division(num1, num2);
                default:
                    return null;
            }
        }

        public static Complex OperCompNum(Complex num1, double num2, string sign)
        {
            switch (sign)
            {
                case "+":
                    return OperComplexNum.Addition(num1, num2);
                case "-":
                    return OperComplexNum.Subtraction(num1, num2);
                case "*":
                    return OperComplexNum.Multiplication(num1, num2);
                case "/":
                    return OperComplexNum.Division(num1, num2);
                default:
                    return null;
            }
        }

        public static Complex OperCompNum(double num1, Complex num2, string sign)
        {
            switch (sign)
            {
                case "+":
                    return Addition(num2, num1);
                case "-":
                    return Subtraction(num1, num2);
                case "*":
                    return Multiplication(num2, num1);
                case "/":
                    return Division(num1, num2);
                default:
                    return null;
            }
        }
    }
}
