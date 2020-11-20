using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems_pool_2___probleme_cu_secvente
{
    class Program
    {
        static void Main(string[] args)
        {
            nrpare();
        }

        /// <summary>
        /// Se da o secventa de n numere. Sa se determine cate din ele sunt pare.
        /// </summary>
        private static void nrpare()
        {
            int n, x, contor = 0;

            Console.WriteLine("Cate numere are sirul?");
            n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Introduceti al {i}-lea numar");
                x = int.Parse(Console.ReadLine());

                if (x % 2 == 0)
                    contor++;
            }
            Console.WriteLine($"Sunt {contor} numere pare in aceasta secventa de numere");
        }
    }
}
