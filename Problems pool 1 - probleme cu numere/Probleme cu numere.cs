using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
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
            //akacifra();
            //triunghi();
            //inversarenr();
            //inversarenr1();
            //divizori();
            //nrprim();
            //inversarecifre();
            //divizibilitateinterval();
            //anibisecti();
            //palindrom();
            //nrcrescatoare3();
            nrcrescatoare5();
            //CMMDCMMM();
            //factoriprimi();
            cifrerepeta();
            fractieinzecimal();
            //ghicirenr();
        }

        /// <summary>
        /// Ghiciti un numar intre 1 si 1024 prin intrebari de forma "numarul este mai mare sau egal decat x?".
        /// </summary>
        private static void ghicirenr()
        {
            int x, n;

            Random rnd = new Random();
            x = rnd.Next(1, 1024);

            do
            {
                Console.WriteLine("Introduceti un numar cuprins intre 1 si 1024");
                n = int.Parse(Console.ReadLine());
                if (n > x)
                    Console.WriteLine("Numarul introdus este prea mare");
                if (n < x)
                    Console.WriteLine("Numarul introdus este prea mic");
            } 
            while (n != x);
            Console.WriteLine("Ati ghicit numarul!");
        }

        /// <summary>
        /// Afisati fractia m/n in format zecimal, cu perioada intre paranteze (daca e cazul). 
        /// Exemplu: 13/30 = 0.4(3).
        /// </summary>
        private static void fractieinzecimal()
        {
            double m, n, x;

            Console.WriteLine("Introduceti doua numere");
            m = int.Parse(Console.ReadLine());
            n = int.Parse(Console.ReadLine());

            x = m / n;

            Console.WriteLine($"Fractia in format zecimal este {x}");
        }

        /// <summary>
        /// Determinati daca un numar e format doar cu 2 cifre care se pot repeta.
        /// De ex. 23222 sau 9009000 sunt astfel de numere, pe cand 593 si 4022 nu sunt.
        /// </summary>
        private static void cifrerepeta()
        {
            int n;

            Console.WriteLine("Introduceti un numar");
            n = int.Parse(Console.ReadLine());
        }

        /// <summary>
        /// Afisati descompunerea in factori primi ai unui numar n.  De ex. pentru n = 1776 afisati 2^3 x 3^1 x 7^2.
        /// </summary>
        private static void factoriprimi()
        {
            int n, b, p;

            Console.WriteLine("Introduceti un numar");
            n = int.Parse(Console.ReadLine());

            b = 2;

            while (n > 1)
            {
                p = 0;
                while (n % b == 0)
                {
                    n = n / b;
                    p++;
                }
                if (p != 0)
                    Console.WriteLine($"{b}^{p}");
                b++;
            }
            Console.WriteLine("Descompunerea in factori primi a numarului este inmultirea numerelor de mai sus");
        }

        /// <summary>
        /// Determianti cel mai mare divizor comun si cel mai mic multiplu comun a doua numere. Folositi algoritmul lui Euclid.
        /// </summary>
        private static void CMMDCMMM()
        {
            int a, b, a1, b1, cmmmc;

            Console.WriteLine("Introduceti doua numere");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());

            a1 = a;
            b1 = b;

            while (a1 != b1)
            {
                if (a1 > b1) a1 = a1 - b1;
                else b1 = b1 - a1;
            }

            cmmmc = (a * b) / a1;

            Console.WriteLine($"Cel mai mare divizor comun este {a1} si cel mai mic multiplu comun este {cmmmc}");
        }

        /// <summary>
        /// Se dau 5 numere. Sa se afiseze in ordine crescatoare. (nu folositi tablouri)
        /// </summary>
        private static void nrcrescatoare5()
        {
            int a, b, c, d, e;

            Console.WriteLine("Introduceti cinci numere");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            d = int.Parse(Console.ReadLine());
            e = int.Parse(Console.ReadLine());

            int min, med1, med, med2, max;

            min = a;
            if (b < min)
                min = b;
            if (c < min)
                min = c;
            if (d < min)
                min = d;
            if (e < min)
                min = e;

            max = a;
            if (b > max)
                max = b;
            if (c > max)
                max = c;
            if (d > max)
                max = d;
            if (e > max)
                max = e;

            

            Console.WriteLine($"Numerele ordonanate in ordine crescatoare sunt {min}  {max}");
        }

        /// <summary>
        /// Se dau 3 numere. Sa se afiseze in ordine crescatoare.
        /// </summary>
        private static void nrcrescatoare3()
        {
            int a, b, c;

            Console.WriteLine("Introduceti trei numere");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());

            int min, med, max;

            min = a;
            if (b < min)
                min = b;
            if (c < min)
                min = c;

            max = a;
            if (b > max)
                max = b;
            if (c > max)
                max = c;

            med = a + b + c - min - max;

            Console.WriteLine($"Numerele ordonanate in ordine crescatoare sunt {min} {med} {max}");
        }

        /// <summary>
        /// Determianti daca un numar n este palindrom. 
        /// (un numar este palindrom daca citit invers obtinem un numar egal cu el, de ex. 121 sau 12321.
        /// </summary>
        private static void palindrom()
        {
            int n, n1, m = 0;

            Console.WriteLine("Introduceti un numar");
            n = int.Parse(Console.ReadLine());

            n1 = n;

            while (n > 0)
            {
                m = (m * 10) + (n % 10);
                n = n / 10;
            }
            if (n1 == m)
                Console.WriteLine("Numarul este palindrom");
            else
                Console.WriteLine("Numarul nu este palindrom");
        }

        /// <summary>
        /// Determianti cati ani bisecti sunt intre anii y1 si y2.
        /// </summary>
        private static void anibisecti()
        {
            int y1, y2, b = 0;

            Console.WriteLine("Introduceti primul an");
            y1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti al doilea an");
            y2 = int.Parse(Console.ReadLine());

            for (int i = y1; i <= y2; i++)
            {
                if (i % 4 == 0 && i % 100 != 0)
                {
                    b++;
                }
            }
            Console.WriteLine($"Intre anii {y1} si {y2} sunt {b} ani bisecti");
        }

        /// <summary>
        /// Determinati cate numere intregi divizibile cu n se afla in intervalul [a, b].
        /// </summary>
        private static void divizibilitateinterval()
        {
            int n, a, b, c = 0;

            Console.WriteLine("Introduceti un numar");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti valoarea pentru a din intervalul [a, b]");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti valoarea pentru b din intervalul [a, b]");
            b = int.Parse(Console.ReadLine());

            for (int i = a; i <= b; i++)
            {
                if (i % n == 0)
                {
                    c++;
                }
            }
            Console.WriteLine($"In intervalul [{a}, {b}] se afla {c} numere intregi divizibile cu {n}");
        }

        /// <summary>
        /// Afisati in ordine inversa cifrele unui numar n.
        /// </summary>
        private static void inversarecifre()
        {
            int n, i = 0;

            Console.WriteLine("Introduceti un numar");
            n = int.Parse(Console.ReadLine());

            while (n != 0)
            {
                i = (i * 10) + (n % 10);
                n = n / 10;
            }

            Console.WriteLine($"Cifrele numarului in ordine inversa sunt {i}");
        }

        /// <summary>
        /// Test de primalitate: determinati daca un numar n este prim.
        /// </summary>
        private static void nrprim()
        {
            int n;
            bool nrprim = true;

            Console.WriteLine("Introduceti un numar");
            n = int.Parse(Console.ReadLine());

            for (int i = 2; i <= n / 2; i++)
            {
                if (n % i == 0)
                    nrprim = false;
            }
            if (nrprim == true)
                Console.WriteLine("Numarul introdus este un numar prim");
            else
                Console.WriteLine("Numarul introdus nu este un numar prim");
        }

        /// <summary>
        /// Afisati toti divizorii numarului n.
        /// </summary>
        private static void divizori()
        {
            int n;

            Console.WriteLine("Introduceti un numar");
            n = int.Parse(Console.ReadLine());

            for (int i = 2; i <= n / 2; i++)
            {
                if (n % i == 0)
                    Console.WriteLine($"Divizorii numarului sunt {i}");
            }
        }

        /// <summary>
        /// (Swap restrictionat) Se dau doua variabile numerice a si b ale carori valori sunt date de intrare. 
        /// Se cere sa se inverseze valorile lor fara a folosi alte variabile suplimentare.
        /// </summary>
        private static void inversarenr1()
        {
            int a, b;

            Console.WriteLine("Introduceti valoarea pentru a");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti valoarea pentru b");
            b = int.Parse(Console.ReadLine());

            a = a - b;
            b = a + b;
            a = b - a;

            Console.WriteLine($"Numerele inversate sunt {a} si {b}");
        }

        /// <summary>
        /// (Swap) Se dau doua variabile numerice a si b ale carori valori sunt date de intrare. Se cere sa se inverseze valorile lor.
        /// </summary>
        private static void inversarenr()
        {
            int a, b, t;

            Console.WriteLine("Introduceti valoarea pentru a");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti valoarea pentru b");
            b = int.Parse(Console.ReadLine());

            t = a;
            a = b;
            b = t;

            Console.WriteLine($"Numerele inversate sunt {a} si {b}");
        }

        /// <summary>
        /// Determinati daca trei numere pozitive a, b si c pot fi lungimile laturilor unui triunghi.
        /// </summary>
        private static void triunghi()
        {
            int a, b, c;

            Console.WriteLine("Introduceti valoarea pentru latura a");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti valoarea pentru latura b");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti valoarea pentru latura c");
            c = int.Parse(Console.ReadLine());

            if ((a < b + c) && (b < a + c) && (c < b + a) && (a > 0) && (b > 0) && (c > 0))
                Console.WriteLine("Cele trei numere pot fi lungimile laturilor unui triunghi");
            else
                Console.WriteLine("Cele trei numere nu pot fi lungimile laturilor unui triunghi");
        }

        /// <summary>
        /// Extrageti si afisati a k-a cifra de la sfarsitul unui numar. Cifrele se numara de la dreapta la stanga.
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
        /// Determinati daca un an y este an bisect.
        /// </summary>
        private static void anbisect()
        {
            int y;

            Console.WriteLine("Introduceti un an");
            y = int.Parse(Console.ReadLine());

            if ((y % 4 == 0 && y % 100 != 0) || (y % 400 == 0))
            {
                Console.WriteLine("Anul este bisect");
            }
            else
            {
                Console.WriteLine("Anul nu este bisect");
            }
        }

        /// <summary>
        /// Determinati daca n se divide cu k, unde n si k sunt date de intrare.
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
        /// Rezolvati ecuatia de gradul 2 cu o necunoscuta: ax^2 + bx + c = 0, unde a, b si c sunt date de intrare. 
        /// Tratati toate cazurile posibile.
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
        /// Rezolvati ecuatia de gradul 1 cu o necunoscuta: ax+b = 0, unde a si b sunt date de intrare.
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
