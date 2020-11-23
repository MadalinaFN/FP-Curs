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
            //nrCrescatoare();
            //MaxMin();
            //Fibonacci();
            //Monotona();
            nrConsecutive();
            //SumInv();
            //////nrConsecutiveDifDe0();
            //SecRotita();
            //MonRotita();
            //SecBitonica();
            //BitRotita();
            //Paranteze();
        }

        /// <summary>
        /// Se da o secventa de 0 si 1, unde 0 inseamna paranteza deschisa si 1 inseamna paranteza inchisa. 
        /// Determinati daca secventa reprezinta o secventa de paranteze corecta si, daca este, 
        /// determinati nivelul maxim de incuibare a parantezelor. 
        /// De exemplu 0 1 0 0 1 0 1 1 este corecta si are nivelul maxim de incuibare 2 
        /// pe cand 0 0 1 1 1 0 este incorecta. 
        /// </summary>
        private static void Paranteze()
        {
            int n, x, y = 0, z = 1, a = 0, b = -1;

            Console.WriteLine("Cate numere are sirul?");
            n = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduceti doar numerele 0 sau 1, 0 fiind paranteza deschisa si 1 inchisa");

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Introduceti al {i}-lea numar");
                x = int.Parse(Console.ReadLine());

                if (x == 0)
                    y++;
                else if (x == 1 && y > 0)
                    y--;
                else
                    z = 0;

                if (x == 0)
                    a++;
                else
                    a--;
                if (a > b)
                    b = a;
            }
            if (z != 0 && y == 0)
                Console.WriteLine($"Secventa este o secventa de paranteze corecta si nivelul maxim de incuibare este {b}");
            else
                Console.WriteLine("Secventa nu este o secventa de paranteze corecta");
        }

        /// <summary>
        /// O secventa bitonica rotita este o secventa bitonica sau una ca poate fi transformata 
        /// intr-o secventa bitonica prin rotiri succesive (rotire = primul element devine ultimul). 
        /// Se da o secventa de n numere. Se cere sa se determine daca este o secventa bitonica rotita.
        /// </summary>
        private static void BitRotita()
        {
            int n, x, x1, x2;
            bool cresc = true;
            bool desc = true;
            bool rot = true;
            bool rotc = true;
            bool rotd = true;

            Console.WriteLine("Cate numere are sirul?");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine($"Introduceti primul numar");
            x1 = int.Parse(Console.ReadLine());

            x2 = x1;

            for (int i = 2; i <= n; i++)
            {
                Console.WriteLine($"Introduceti al {i}-lea numar");
                x = int.Parse(Console.ReadLine());

                if (x1 > x)
                    cresc = false;
                if (x1 < x)
                    desc = false;
                if (!rotd && ((x1 < x) || (x2 > x)))
                    rot = false;
                if (!cresc && ((x1 < x) || (i == 1)))
                    rotc = false;
                if (!desc && x1 > x)
                    rotd = false;
                if (x2 < x && desc)
                    x2 = x;
                x1 = x;
            }
            if (rot || rotc || rotd)
                Console.WriteLine("Secventa este bitonica rotita");
            else
                Console.WriteLine("Secventa nu este bitonica rotita");
        }

        /// <summary>
        /// O secventa bitonica este o secventa de numere care incepe monoton crescator 
        /// si continua monoton descrecator. 
        /// De ex. 1,2,2,3,5,4,4,3 este o secventa bitonica. 
        /// Se da o secventa de n numere. Sa se determine daca este bitonica.
        /// </summary>
        private static void SecBitonica()
        {
            int n, x, x1;
            bool cresc = true;
            bool bit = true;

            Console.WriteLine("Cate numere are sirul?");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine($"Introduceti primul numar");
            x1 = int.Parse(Console.ReadLine());

            for (int i = 2; i <= n; i++)
            {
                Console.WriteLine($"Introduceti al {i}-lea numar");
                x = int.Parse(Console.ReadLine());

                if (x1 > x)
                    cresc = false;
                if ((x1 < x || i == 1) && !cresc)
                    bit = false;
                x1 = x;
            }
            if (!cresc && bit)
                Console.WriteLine("Secventa este bitonica");
            else
                Console.WriteLine("Secventa nu este bitonica");
        }

        /// <summary>
        /// O secventa monotona rotita este o secventa de numere monotona sau 
        /// poate fi transformata intr-o secventa montona prin rotiri succesive. 
        /// Determinati daca o secventa de n numere este o secventa monotona rotita.
        /// </summary>
        private static void MonRotita()
        {
            int n, x, x1, x2, x3;
            bool cresc = true;
            bool desc = true;
            bool rotc = true;
            bool rotd = true;

            Console.WriteLine("Cate numere are sirul?");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine($"Introduceti primul numar");
            x1 = int.Parse(Console.ReadLine());

            x2 = x1;
            x3 = x1;

            for (int i = 2; i <= n; i++)
            {
                Console.WriteLine($"Introduceti al {i}-lea numar");
                x = int.Parse(Console.ReadLine());

                if (x1 > x)
                    cresc = false;
                if (x1 < x)
                    desc = false;
                if ((x1 > x || x2 < x) && !cresc)
                    rotc = false;
                if ((x1 < x || x3 > x) && !desc)
                    rotd = false;

                if (cresc && x2 > x)
                    x2 = x;
                if (desc && x3 < x)
                    x3 = x;
                x1 = x;
            }
            if (cresc || desc || rotc || rotd)
                Console.WriteLine("Secventa este monotona rotita");
            else
                Console.WriteLine("Secventa nu este monotona rotita");
        }

        /// <summary>
        /// O secventa crescatoare rotita este o secventa de numere care este in ordine crescatoare sau 
        /// poate fi transformata intr-o secventa in ordine crescatoare prin rotiri succesive 
        /// (rotire = primul element devine ultimul). 
        /// Determinati daca o secventa de n numere este o secventa crescatoare rotita.
        /// </summary>
        private static void SecRotita()
        {
            int n, x, x1, x2;
            bool cresc = true;
            bool rot = true;

            Console.WriteLine("Cate numere are sirul?");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine($"Introduceti primul numar");
            x1 = int.Parse(Console.ReadLine());

            x2 = x1;

            for (int i = 2; i <= n; i++)
            {
                Console.WriteLine($"Introduceti al {i}-lea numar");
                x = int.Parse(Console.ReadLine());

                if (x1 > x)
                    cresc = false;
                if ((x1 > x || x2 < x) && !cresc)
                    rot = false;

                if (cresc && x2 > x)
                    x2 = x;
                x1 = x;
            }
            if (cresc || rot)
                Console.WriteLine("Secventa este crescatoare rotita");
            else
                Console.WriteLine("Secventa nu este crescatoare rotita");
        }

        /// <summary>
        /// Cate grupuri de numere consecutive diferite de zero sunt intr-o secventa de n numere. 
        /// Considerati fiecare astfel de grup ca fiind un cuvant, zero fiind delimitator de cuvinte. 
        /// De ex. pentru secventa 1, 2, 0, 3, 4, 5, 0, 0, 6, 7, 0, 0 raspunsul este 3. 
        /// </summary>
        private static void nrConsecutiveDifDe0()
        {
            int n, a, b = 0, c = 0;

            Console.WriteLine("Cate numere are sirul?");
            n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Introduceti al {i}-lea numar");
                a = int.Parse(Console.ReadLine());

                if (a == 0)
                    c = 0;
                if (c == 0)
                {
                    b++;
                    c = 1;
                }
            }
            Console.WriteLine($"In aceasta secventa sunt {b} numere diferite de 0");
        }

        /// <summary>
        /// Se da o secventa de n numere. Se cere sa se caculeze suma inverselor acestor numere.
        /// </summary>
        private static void SumInv()
        {
            int n, a, s = 0;

            Console.WriteLine("Cate numere are sirul?");
            n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Introduceti al {i}-lea numar");
                a = int.Parse(Console.ReadLine());

                s = s + inv(a);
            }

            Console.WriteLine($"Suma inverselor este {s}");
        }
        static int inv(int n)
        {
            int inv = 0;
            while (n != 0)
            {
                inv = inv * 10 + n % 10;
                n = n / 10;
            }
            return inv;
        }

        /// <summary>
        /// Se da o secventa de n numere. Care este numarul maxim de numere consecutive egale din secventa.
        /// </summary>
        private static void nrConsecutive()
        {
            int n, a, b, sa = 1, sm = 1, i;

            Console.WriteLine("Cate numere are sirul?");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti numerele");
            a = int.Parse(Console.ReadLine());

            for (i = 1; i < n; i++)
            {
                b = int.Parse(Console.ReadLine());

                if (b == a)
                {
                    sa++;
                    if (sa > sm)
                        sm = sa;
                }
                else
                {
                    a = b;
                    sa = 1;
                }
            }
            Console.WriteLine($"Numarul maxim de numere consecutive egale din secventa este {sm}");
        }

        /// <summary>
        /// Sa se determine daca o secventa de n numere este monotona. 
        /// Secventa monotona = secventa monoton crescatoare sau monoton descrescatoare.
        /// </summary>
        private static void Monotona()
        {
            int n, a, b, d = 0, i = 1;

            Console.WriteLine("Cate numere are sirul?");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti numerele");
            a = int.Parse(Console.ReadLine());

            while (i < n)
            {
                b = int.Parse(Console.ReadLine());

                if (b > a)
                    if (d < 0)
                        d = 2;
                    else
                        d = 1;
                else if (b < a)
                    if (d > 0)
                        d = 2;
                    else
                        d = -1;
                a = b;
                i++;
            }
            if (d < 2)
                Console.WriteLine("Secventa este monotona");
            else
                Console.WriteLine("Secventa nu este monotona");
        }

        /// <summary>
        /// Determianti al n-lea numar din sirul lui Fibonacci. 
        /// Sirul lui Fibonacci se construieste astfel: f1 = 0, f2 = 1, f_n = f_(n-1) + f(n-2). 
        /// Exemplu: 0, 1, 1, 2, 3, 5, 8 ...
        /// </summary>
        private static void Fibonacci()
        {
            int n, n1 = 1, n2 = 1, F = 0;

            Console.WriteLine("Cate numere are sirul?");
            n = int.Parse(Console.ReadLine());

            for (int i = 2; i <= n; i++)
            {
                F = n1 + n2;
                n1 = n2;
                n2 = F;
            }
            Console.WriteLine($"Al {n}-lea numar din sirul lui Fibonacci este {F}");
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
            Console.WriteLine("Introduceti numerele");
            a = int.Parse(Console.ReadLine());

            while (z < n)
            {
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
