using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.A_k_a_cifra
{
    class Program
    {
        static void Main(string[] args)
        {
            // Extrageti si afisati a k-a cifra de la sfarsitul unui numar. Cifrele se numara de la dreapta la stanga.

            int x, k, s, c;

            Console.WriteLine("Introduceti un numar de minim 2 cifre si maxim 6 cifre");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti a k-a cifra pe care vreti sa o afisati");
            c = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti 2 daca numarul are 2 cifre, respectiv 3, 4, 5, 6");
            s = int.Parse(Console.ReadLine());

            switch (s)
            {
                case 2:
                    if (c == 1)
                    {
                        k = x / 10;
                        Console.WriteLine($"A {c}-a cifra este {k}");
                    }
                    if (c == 2)
                    {
                        k = x % 10;
                        Console.WriteLine($"A {c}-a cifra este {k}");
                    }
                    break;
                case 3:
                    if (c == 1)
                    {
                        k = x / 100;
                        Console.WriteLine($"A {c}-a cifra este {k}");
                    }
                    if (c == 2)
                    {
                        k = (x / 10) % 10;
                        Console.WriteLine($"A {c}-a cifra este {k}");
                    }
                    if (c == 3)
                    {
                        k = x % 10;
                        Console.WriteLine($"A {c}-a cifra este {k}");
                    }
                    break;
                case 4:
                    if (c == 1)
                    {
                        k = x / 1000;
                        Console.WriteLine($"A {c}-a cifra este {k}");
                    }
                    if (c == 2)
                    {
                        k = (x / 100) % 10;
                        Console.WriteLine($"A {c}-a cifra este {k}");
                    }
                    if (c == 3)
                    {
                        k = (x / 10) % 10;
                        Console.WriteLine($"A {c}-a cifra este {k}");
                    }
                    if (c == 4)
                    {
                        k = x % 10;
                        Console.WriteLine($"A {c}-a cifra este {k}");
                    }
                    break;
                case 5:
                    if (c == 1)
                    {
                        k = x / 10000;
                        Console.WriteLine($"A {c}-a cifra este {k}");
                    }
                    if (c == 2)
                    {
                        k = (x / 1000) % 10;
                        Console.WriteLine($"A {c}-a cifra este {k}");
                    }
                    if (c == 3)
                    {
                        k = (x / 100) % 10;
                        Console.WriteLine($"A {c}-a cifra este {k}");
                    }
                    if (c == 4)
                    {
                        k = (x / 10) % 10;
                        Console.WriteLine($"A {c}-a cifra este {k}");
                    }
                    if (c == 5)
                    {
                        k = x % 10;
                        Console.WriteLine($"A {c}-a cifra este {k}");
                    }
                    break;
                case 6:
                    if (c == 1)
                    {
                        k = x / 100000;
                        Console.WriteLine($"A {c}-a cifra este {k}");
                    }
                    if (c == 2)
                    {
                        k = (x / 10000) % 10;
                        Console.WriteLine($"A {c}-a cifra este {k}");
                    }
                    if (c == 3)
                    {
                        k = (x / 1000) % 10;
                        Console.WriteLine($"A {c}-a cifra este {k}");
                    }
                    if (c == 4)
                    {
                        k = (x / 100) % 10;
                        Console.WriteLine($"A {c}-a cifra este {k}");
                    }
                    if (c == 5)
                    {
                        k = (x / 10) % 10;
                        Console.WriteLine($"A {c}-a cifra este {k}");
                    }
                    if (c == 6)
                    {
                        k = x % 10;
                        Console.WriteLine($"A {c}-a cifra este {k}");
                    }
                    break;
            }
        }
    }
}
