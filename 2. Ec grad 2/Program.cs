using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Ec_grad_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Rezolvati ecuatia de gradul 2 cu o necunoscuta: ax^2 + bx + c = 0, unde a, b si c sunt date de intrare. 
            // Tratati toate cazurile posibile.

            double a, b, c, x1, x2, rad;

            Console.WriteLine("Introduceti valoarea pentru a");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti valoarea pentru b");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti valoarea pentru c");
            c = int.Parse(Console.ReadLine());

            rad = Math.Sqrt((b * b) - (4 * a * c));
            x1 = ((-b) + rad) / (2 * a);
            x2 = ((-b) - rad) / (2 * a);

            Console.WriteLine($"Rezultatele ecuatiei sunt {x1} si {x2}");
        }
    }
}
