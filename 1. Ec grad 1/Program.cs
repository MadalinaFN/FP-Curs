using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Ec_grad_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Rezolvati ecuatia de gradul 1 cu o necunoscuta: ax+b = 0, unde a si b sunt date de intrare.

            int a, b, x;

            Console.WriteLine("Introduceti valoarea pentru a");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti valoarea pentru b");
            b = int.Parse(Console.ReadLine());

            x = - (b / a);

            Console.WriteLine($"Rezultatul ecuatiei este {x}");
        }
    }
}
