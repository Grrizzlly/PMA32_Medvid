using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Goldendivision
{
    class Program
    {
        static void Main(string[] args)
        {
            //f(x)=3x^4-10x^4+21x^2+12x 
            //e=0.00000 
            Console.WriteLine("enter a:");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("enter b:");
            double b = double.Parse(Console.ReadLine());
            double eps = 0.00001;
            //double c = (a + b) / 2; 
            double c = 0;
            double x = 0;
            int i = 0;
            while (Math.Abs(b - a) > eps)
            {
                c = (a + b) / 2;
                if (f_(c) == 0)
                {
                    x = c;
                }
                if (f_(c) > 0)
                {
                    a = a;
                    b = c;
                }
                if (f_(c) < 0)
                {
                    a = c;
                    b = b;
                }
                i++;
            }
            Console.WriteLine("iteration is:" + i);
            Console.WriteLine("a:" + a);
            Console.WriteLine("b:" + b);
            Console.WriteLine("c:" + c);
            Console.WriteLine("_______________________________________");
            x = (a + b) / 2;
            Console.WriteLine("the result is:" + x);
            Console.ReadKey();
        }
        public static double f(double x)
        {
            double res = 3 * Math.Pow(x, 4) - 10 * Math.Pow(x, 3) + 21 * Math.Pow(x, 2) + 12 * x;
            return res;
        }
        public static double f_(double x)
        {
            double res = 12 * Math.Pow(x, 3) - 30 * Math.Pow(x, 2) + 42 * x + 12;
            // double res = 2 * x + 3 * Math.Log(x); 
            return res;
        }
    }
}
