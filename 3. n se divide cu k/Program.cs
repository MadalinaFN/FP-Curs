using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.n_se_divide_cu_k
{
    class Program
    {
        static void Main(string[] args)
        {
            // Determinati daca n se divide cu k, unde n si k sunt date de intrare.

            int n, k, x;

            Console.WriteLine("Introduceti valoarea pentru n");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti valoarea pentru k");
            k = int.Parse(Console.ReadLine());

            x = n / k;

            if (n % k == 0)
            {
                Console.WriteLine($"N se divide cu K, iar rezultatul este {x}");
            }
            else
            {
                Console.WriteLine("N nu se divide cu K");
            }
        }
    }
}
