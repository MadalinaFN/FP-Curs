using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Problems_pool_1___probleme_cu_numere
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ecgrad1();
            //Ecgrad2();
            //nsedividecuk();
            //anbisect();
            akacifra();
            //triunghi();
        }

        /// <summary>
        /// // Detreminati daca trei numere pozitive a, b si c pot fi lungimile laturilor unui triunghi.
        /// </summary>
        private static void triunghi()
        {
            
        }

        /// <summary>
        /// // Extrageti si afisati a k-a cifra de la sfarsitul unui numar. Cifrele se numara de la dreapta la stanga.
        /// </summary>
        private static void akacifra()
        {
            int c, k, n = 580201;

            Console.WriteLine($"Se da numarul {n}");
            Console.WriteLine("Introduceti a k-a cifra pe care vreti sa o afisati");
            k = int.Parse(Console.ReadLine());

            switch (k)
            {
                case 1:
                    c = n / 100000;
                    Console.WriteLine($"A {k}-a cifra este {c}");
                    break;
                case 2:
                    c = (n / 10000) % 10;
                    Console.WriteLine($"A {k}-a cifra este {c}");
                    break;
                case 3:
                    c = (n / 1000) % 10;
                    Console.WriteLine($"A {k}-a cifra este {c}");
                    break;
                case 4:
                    c = (n / 100) % 10;
                    Console.WriteLine($"A {k}-a cifra este {c}");
                    break;
                case 5:
                    c = (n / 10) % 10;
                    Console.WriteLine($"A {k}-a cifra este {c}");
                    break;
                case 6:
                    c = n % 10;
                    Console.WriteLine($"A {k}-a cifra este {c}");
                    break;
            }
        }

        /// <summary>
        /// // Determinati daca un an y este an bisect.
        /// </summary>
        private static void anbisect()
        {
            int y;

            Console.WriteLine("Introduceti un an");
            y = int.Parse(Console.ReadLine());

            if (y % 4 == 0 && y % 100 != 0)
            {
                Console.WriteLine("Anul este bisect");
            }
            else
            {
                Console.WriteLine("Anul nu este bisect");
            }
        }

        /// <summary>
        /// // Determinati daca n se divide cu k, unde n si k sunt date de intrare.
        /// </summary>
        private static void nsedividecuk()
        {
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

        /// <summary>
        /// // Rezolvati ecuatia de gradul 2 cu o necunoscuta: ax^2 + bx + c = 0, unde a, b si c sunt date de intrare. 
        /// // Tratati toate cazurile posibile.
        /// </summary>
        private static void Ecgrad2()
        {
            double a, b, c, x1, x2, rad;

            Console.WriteLine("Introduceti valoarea pentru a");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti valoarea pentru b");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti valoarea pentru c");
            c = int.Parse(Console.ReadLine());

            if (2 * a != 0)
            {
                rad = Math.Sqrt((b * b) - (4 * a * c));
                x1 = ((-b) + rad) / (2 * a);
                x2 = ((-b) - rad) / (2 * a);

                Console.WriteLine($"Rezultatele ecuatiei sunt {x1} si {x2}");
            }
            else
            {
                rad = Math.Sqrt((b * b) - (4 * a * c));
                if (((-b) + rad) == 0)
                    Console.WriteLine("Ecuatia este nedeterminata");
                else
                    Console.WriteLine("Ecuatia este imposibila");
            }
        }

        /// <summary>
        /// // Rezolvati ecuatia de gradul 1 cu o necunoscuta: ax+b = 0, unde a si b sunt date de intrare.
        /// </summary>
        private static void Ecgrad1()
        {
            int a, b, x;

            Console.WriteLine("Introduceti valoarea pentru a");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti valoarea pentru b");
            b = int.Parse(Console.ReadLine());

            x = -(b / a);

            Console.WriteLine($"Rezultatul ecuatiei este {x}");
        }
    }

}
