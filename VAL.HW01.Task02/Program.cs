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

            if (false)
            {
                const double pi = 3.14;
                double r = 90, s, l;
                s = pi * Math.Pow(r, 2);
                l = 2 * pi * r;
                Console.WriteLine($"r = {r}, l = {l}, s = {s}");
            }

            if (true)
            {
                int a = 1, b = 2, c = 3, d; //1,2,3 > 3,1,2

                Console.WriteLine($"{a},{b},{c}");

                d = b;
                b = a;

                a = c;
                c = d;

                Console.WriteLine($"{a},{b},{c}");
            }

            Console.ReadLine();
        }
    }
}
