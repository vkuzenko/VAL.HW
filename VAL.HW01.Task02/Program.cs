using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VAL.HW01.Task02
{
    class Program
    {
        static void Main(string[] args)
        {
            if (false)
            {
                int a = 10;
                Console.WriteLine($"a = {a}");
            }

            if (false)
            {
                double a = 5, b = 7, s, p;
                s = a * b;
                p = (a + b) * 2;
                Console.WriteLine($"a = {a}, b = {b}, s = {s}, p = {p}");
            }

            if (true)
            {
                const double pi = 3.14;
                double r = 90, s, l;
                s = pi * Math.Pow(r, 2);
                l = 2 * pi * r;
                Console.WriteLine($"r = {r}, l = {l}, s = {s}");
            }

            Console.ReadLine();
        }
    }
}
