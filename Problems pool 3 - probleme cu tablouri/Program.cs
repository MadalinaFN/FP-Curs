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
            //RotireStanga();
            //RotireStangaK();
            //InsertionSort();
            //SelectionSort();
        }

        /// <summary>
        /// Sortare selectie. Implementati algoritmul de sortare (Selection Sort).
        /// </summary>
        private static void SelectionSort()
        {
            int[] arr = InitArray(8, 0, 100);

            Console.WriteLine("Inainte:");
            PrintArray(arr);

            int aux;
            for (int i = 0; i < arr.Length; i++)
            {
                int k = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[k])
                    {
                        k = j;
                    }
                }
                aux = arr[k];
                arr[k] = arr[i];
                arr[i] = aux;
            }
            Console.WriteLine("Dupa:");
            PrintArray(arr);
        }

        /// <summary>
        /// Sortare prin insertie. Implementati algoritmul de sortare (Insertion Sort).
        /// </summary>
        private static void InsertionSort()
        {
            int[] arr = InitArray(8, 0, 100);

            Console.WriteLine("Inainte:");
            PrintArray(arr);

            int aux;
            for (int i = 1; i < arr.Length; i++)
            {
                for (int k = i; k > 0 && arr[k] < arr[k - 1]; k--)
                {
                    aux = arr[k];
                    arr[k] = arr[k - 1];
                    arr[k - 1] = aux;
                }
            }
            Console.WriteLine("Dupa:");
            PrintArray(arr);
        }

        private static void PrintArray(int[] arr)
        {
            foreach (int item in arr)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
        }

        private static int[] InitArray(int length, int min, int max)
        {
            int[] v = new int[length];
            Random rnd = new Random();
            for (int i = 0; i < v.Length; i++)
            {
                v[i] = rnd.Next(min, max);
            }
            return v;
        }

        /// <summary>
        /// Rotire k. Se da un vector cu n elemente. Rotiti elementele vectorului cu k pozitii spre stanga.
        /// </summary>
        private static void RotireStangaK()
        {
            int k = 3;
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

            for (int j = 0; j < k; j++)
            {
                int aux;
                aux = v[0];
                for (int i = 1; i < v.Length; i++)
                {
                    v[i - 1] = v[i];
                }
                v[v.Length - 1] = aux;
            }

            Console.WriteLine("Dupa:");
            foreach (var item in v)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
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
