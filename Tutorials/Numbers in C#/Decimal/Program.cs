using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decimal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal min = decimal.MinValue;
            decimal max = decimal.MaxValue;
            Console.WriteLine($"The range of the decimal type is {min} to {max}");

            double a = 1.0;
            double b = 3.0;
            Console.WriteLine(a / b);

            decimal c = 1.0M;
            decimal d = 3.0M;
            Console.WriteLine(c / d);

            //Circle calculator

            double r = 2.5;

            Console.WriteLine(Math.Pow(r, 2) * Math.PI);

            Console.ReadKey();
        }
    }
}
