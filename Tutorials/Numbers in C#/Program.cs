using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numbers_in_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // WorkWithIntegers();
            // WorkWithIntegers2();

            void WorkWithIntegers()
            {
            // int
            int a = 18;
            int b = 6;
            int c = a + b;
            Console.WriteLine(c);

            Console.WriteLine();
            Console.ReadKey();


            // subtraction
            c = a - b;
            Console.WriteLine(c);

            // multiplication
            c = a * b;
            Console.WriteLine(c);

            // division
            c = a / b;
            Console.WriteLine(c);

            // Mixing
            c = a + b - 12 * 17;
            Console.WriteLine(c);

            Console.WriteLine();
            Console.ReadKey();
            }

            void WorkWithIntegers2()
            {
            int a = 5;
            int b = 4;
            int c = 2;
            int d = a + b * c;
            Console.WriteLine(d);

            Console.WriteLine();
            Console.ReadKey();
            }


        }
    }
}
