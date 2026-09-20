using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Double
{
    internal class Program2
    {
        static void Main(string[] args)
        {
            //WorkwithDouble();
            WorkwithDouble2();

            void WorkwithDouble()
            {
                double a = 5;
                double b = 4;
                double c = 2;
                double d = (a + b) / c;
                Console.WriteLine(d);
            }

            void WorkwithDouble2()
            {
                double a = 19;
                double b = 23;
                double c = 8;
                double d = (a + b) / c;
                Console.WriteLine(d);

                double max = double.MaxValue;
                double min = double.MinValue;
                Console.WriteLine($"The range of double is {min} to {max}");

                double third = 1.0 / 3.0;
                Console.WriteLine(third);
            }

            Console.ReadKey();
        }
    }
}
