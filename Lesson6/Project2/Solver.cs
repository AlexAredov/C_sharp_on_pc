using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    class Solver
    {
        delegate K Solve<K>(double a, double b, double c);
        Solve<double[]> solve;
        string[] arr;

        public Solver(string s)
        {
            if (s.Any(x => !char.IsLetter(x)))
            {
                arr = s.Split(' ');
                if (arr.Length == 1)
                {
                    solve = new Solve<double[]>(Nol);
                }
                else if (arr.Length == 2)
                {
                    solve = new Solve<double[]>(Lin);
                }
                else if (arr.Length == 3)
                {
                    solve = new Solve<double[]>(Sq);
                }
            }
        }

        public double[] Sq(double a, double b, double c)
        {
            double[] l = new double[2];
            var discriminant = Math.Pow(b, 2) - 4 * a * c;
            if (discriminant < 0)
            {
                return null;
            }
            else
            {
                if (discriminant == 0) //квадратное уравнение имеет два одинаковых корня
                {
                    l[0] = -b / (2 * a);
                    l[1] = l[0];
                }
                else //уравнение имеет два разных корня
                {
                    l[0] = (-b + Math.Sqrt(discriminant)) / (2 * a);
                    l[1] = (-b - Math.Sqrt(discriminant)) / (2 * a);
                }
            }
            return l;
        }
        public double[] Lin(double a, double b, double c)
        {
            return new double[] { -b / a };
        }

        public double[] Nol(double a, double b, double c)
        {
            return new double[] { a };
        }

        public string output()
        {
            double[] res = null;
            if (arr.Length == 1)
            {
                res = solve(Convert.ToDouble(arr[0]), 0, 0);
            }
            else if (arr.Length == 2)
            {
                res = solve(Convert.ToDouble(arr[0]), Convert.ToDouble(arr[1]), 0);
            }
            else if (arr.Length == 3)
            {
                res = solve(Convert.ToDouble(arr[0]), Convert.ToDouble(arr[1]), Convert.ToDouble(arr[2]));
            }
            else
            {
                return "Данный набор коэффицентов не может определять уравнение";
            }
            string s = "";
            if (res != null)
            {
                foreach (double ss in res)
                {
                    s += ss.ToString() + " ";
                }
                return s;
            }
            else
            {
                return "Нет решений";
            }
        }
    }
}
