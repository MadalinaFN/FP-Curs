using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems_pool_3___probleme_cu_tablouri
{
    class Program
    {
        static void Main(string[] args)
        {
            RotireStanga();
        }

        /// <summary>
        /// Rotire. Se da un vector cu n elemente. 
        /// Rotiti elementele vectorului cu o pozitie spre stanga. 
        /// Prin rotire spre stanga primul element devine ultimul, al doilea devine primul etc.
        /// </summary>
        private static void RotireStanga()
        {
            int n = 10;
            int[] v = new int[n];

            Random rnd = new Random();
            for (int i = 0; i < v.Length; i++)
            {
                v[i] = rnd.Next(0, 100);
            }

            Console.WriteLine("Inainte:");
            foreach (var item in v)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();

            int aux;
            aux = v[0];
            for (int i = 1; i < v.Length; i++)
            {
                v[i - 1] = v[i];
            }
            v[v.Length - 1] = aux;

            Console.WriteLine("Dupa:");
            foreach (var item in v)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
        }
    }
}
