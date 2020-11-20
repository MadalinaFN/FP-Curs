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
            //nrpare();
            //nrNegZeroPoz();
            //SumSiProd();
            //PozitieA();
            //nrEgaleCuPoz();
            nrCrescatoare();
            //MaxMin();
        }

        /// <summary>
        /// Se da o secventa de n numere. Sa se determine cea mai mare si cea mai mica valoare din secventa.
        /// </summary>
        private static void MaxMin()
        {
            int n, x, max, min;

            Console.WriteLine("Cate numere are sirul?");
            n = int.Parse(Console.ReadLine());

            max = -int.MaxValue;
            min = Int32.MaxValue;
            
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Introduceti al {i}-lea numar");
                x = int.Parse(Console.ReadLine());

                if (x > max)
                    max = x;
                if (x < min)
                    min = x;
            }
            Console.WriteLine($"Cea mai mare valoare este {max} si cea mai mica este {min}");
        }

        /// <summary>
        /// Se da o secventa de n numere. Sa se determine daca numerele din secventa sunt in ordine crescatoare.
        /// </summary>
        private static void nrCrescatoare()
        {
            int n, a, b, z = 1, cresc = 1;

            Console.WriteLine("Cate numere are sirul?");
            n = int.Parse(Console.ReadLine());

            while (z <= n)
            {
                Console.WriteLine("Introduceti numerele");
                a = int.Parse(Console.ReadLine());
                Console.WriteLine("Introduceti numerele");
                b = int.Parse(Console.ReadLine());

                if (b < a)
                    cresc = 0;
                a = b;
                z++;
            }
            if (cresc == 1)
                Console.WriteLine("Numerele sunt in ordine crescatoare");
            else
                Console.WriteLine("Numerele nu sunt in ordine crescatoare");
        }

        /// <summary>
        /// Cate elemente dintr-o secventa de n numere sunt egale cu pozitia pe care apar in secventa. 
        /// Se considera ca primul element din secventa este pe pozitia 0. 
        /// </summary>
        private static void nrEgaleCuPoz()
        {
            int n, x, contor = 0;

            Console.WriteLine("Cate numere are sirul?");
            n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Introduceti al {i}-lea numar");
                x = int.Parse(Console.ReadLine());

                if (x == i)
                    contor++;
            }
            Console.WriteLine($"Sunt {contor} numere egale cu pozitia pe care apar in secventa");
        }

        /// <summary>
        /// Se da o secventa de n numere. Determinati pe ce pozitie se afla in secventa un numar a. 
        /// Se considera ca primul element din secventa este pe pozitia zero. 
        /// Daca numarul nu se afla in secventa raspunsul va fi -1.
        /// </summary>
        private static void PozitieA()
        {
            int n, a, x, i;

            Console.WriteLine("Cate numere are sirul?");
            n = int.Parse(Console.ReadLine());

            Console.WriteLine($"Introduceti numarul a carui pozitie vreti sa o aflati");
            a = int.Parse(Console.ReadLine());

            for (i = 0; i < n; i++)
            {
                Console.WriteLine($"Introduceti al {i}-lea numar");
                x = int.Parse(Console.ReadLine());

                a = x;
                
                Console.WriteLine($"Numarul {x} se afla in pozitia {i}");

                if (a != x)
                    Console.WriteLine("-1");
            }
        }

        /// <summary>
        /// Calculati suma si produsul numerelor de la 1 la n.
        /// </summary>
        private static void SumSiProd()
        {
            int n, x, suma = 0, produs = 1;

            Console.WriteLine("Cate numere are sirul?");
            n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Introduceti al {i}-lea numar");
                x = int.Parse(Console.ReadLine());

                suma = suma + x;
                produs = produs * x;
            }
            Console.WriteLine($"Suma numerelor este {suma}");
            Console.WriteLine($"Produsul numerelor este {produs}");
        }

        /// <summary>
        /// Se da o secventa de n numere. Sa se determine cate sunt negative, cate sunt zero si cate sunt pozitive.
        /// </summary>
        private static void nrNegZeroPoz()
        {
            int n, x, contor1 = 0, contor2 = 0, contor3 = 0;

            Console.WriteLine("Cate numere are sirul?");
            n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Introduceti al {i}-lea numar");
                x = int.Parse(Console.ReadLine());

                if (x < 0)
                    contor1++;
                if (x == 0)
                    contor2++;
                if (x > 0)
                    contor3++;
            }
            Console.WriteLine($"Sunt {contor1} numere negative in aceasta secventa de numere");
            Console.WriteLine($"Sunt {contor2} zerouri in aceasta secventa de numere");
            Console.WriteLine($"Sunt {contor3} numere pozitive in aceasta secventa de numere");
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
