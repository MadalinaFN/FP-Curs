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
            //Suma();
            //PozitieK();
            //CmmCmM();
            //CmmCmM2();
            //EinpozK();
            //StergeK();
            //Inversare();
            //PozitieK2();
            //Eratostene();
            //ZeroLaSfarsit();
            //EliminareElRep();
            //CMMDC();
            //ConvertireNinB();
            //Polinom();
            //AparePinS();
            //SiraguriDeMargele();
            //Lexicografica();
            ///////////////OperatiiCuMultimi();
            ///////////////OperatiiCuMultimi2();
            ///////////////OperatiiCuMultimi3();
            //VectorCrescator();
            //SumDifProd();
            //ValIndex();
            //QuickSort();
        }

        /// <summary>
        /// Quicksort. Sortati un vector folosind metoda QuickSort.
        /// </summary>
        private static void QuickSort()
        {
            int n;

            Console.WriteLine("Introduceti cate elemente sa aiba vectorul");
            n = int.Parse(Console.ReadLine());

            int[] v = new int[n];

            Console.WriteLine("Introduceti elementele vectorului");
            for (int i = 0; i < n; i++)
            {
                v[i] = int.Parse(Console.ReadLine());
            }
            QuickSort(v, 0, n - 1);
            for (int i = 0; i < n; i++)
                Console.Write($"{v[i]} ");
            Console.WriteLine();
        }

        private static void QuickSort(int[] v, int inc, int sf)
        {
            int i;
            if (inc < sf)
            {
                i = Partition(v, inc, sf);
                QuickSort(v, inc, i - 1);
                QuickSort(v, i + 1, sf);
            }
        }

        private static int Partition(int[] v, int inc, int sf)
        {
            int t;
            int p = v[sf];
            int i = inc - 1;

            for (int j = inc; j <= sf - 1; j++)
            {
                if (v[j] <= p)
                {
                    i++;
                    t = v[i];
                    v[i] = v[j];
                    v[j] = t;
                }
            }
            t = v[i + 1];
            v[i + 1] = v[sf];
            v[sf] = t;
            return i + 1;
        }

        /// <summary>
        /// Se da un vector si un index in vectorul respectiv. 
        /// Se cere sa se determine valoarea din vector care va fi 
        /// pe pozitia index dupa ce vectorul este sortat.
        /// </summary>
        private static void ValIndex()
        {
            int n, index, aux;

            Console.WriteLine("Introduceti cate elemente sa aiba vectorul");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti pozitia index");
            index = int.Parse(Console.ReadLine());

            int[] v = new int[n];

            Console.WriteLine("Introduceti elementele vectorului");
            for (int i = 0; i < n; i++)
            {
                v[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < n; i++)
            {
                for (int k = i; k > 0 && v[k] < v[k - 1]; k--)
                {
                    aux = v[k];
                    v[k] = v[k - 1];
                    v[k - 1] = aux;
                }
            }
            for (int i = 0; i < n; i++)
            {
                if (index == i)
                    Console.WriteLine(v[i]);
            }
        }

        /// <summary>
        /// Se dau doua numere naturale foarte mari 
        /// (cifrele unui numar foarte mare sunt stocate intr-un vector - fiecare cifra pe cate o pozitie).
        /// Se cere sa se determine suma, diferenta si produsul a doua astfel de numere.
        /// </summary>
        private static void SumDifProd()
        {
            int n;

            Console.WriteLine("Introduceti cate elemente sa aiba vectorii");
            n = int.Parse(Console.ReadLine());

            int[] v1 = new int[n];
            int[] v2 = new int[n];
            int[] v3 = new int[n];

            Console.WriteLine("Introduceti cifrele primului numar");
            for (int i = 0; i < n; i++)
            {
                v1[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Introduceti cifrele numarului al doilea");
            for (int i = 0; i < n; i++)
            {
                v2[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Suma este:");
            for (int i = 0; i < n; i++)
            {
                v3[i] = v1[i] + v2[i];
                Console.Write($"{v3[i]} ");
            }
            Console.WriteLine();
            Console.WriteLine("Diferenta este:");
            for (int i = 0; i < n; i++)
            {
                v3[i] = v1[i] - v2[i];
                Console.Write($"{v3[i]} ");
            }
            Console.WriteLine();
            Console.WriteLine("Produsul este:");
            for (int i = 0; i < n; i++)
            {
                v3[i] = v1[i] * v2[i];
                Console.Write($"{v3[i]} ");
            }
            Console.WriteLine();
        }

        /// <summary>
        /// (Interclasare) Se dau doi vector sortati crescator v1 si v2.
        /// Construiti un al treilea vector ordonat crescator format din toate elementele din  v1 si v2.
        /// Sunt permise elemente duplicate.
        /// </summary>
        private static void VectorCrescator()
        {
            int n, x, l = 0, m = 0, z = 0;

            Console.WriteLine("Introduceti cate elemente sa aiba vectorul v1");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti cate elemente sa aiba vectorul v2");
            x = int.Parse(Console.ReadLine());

            int[] v1 = new int[n];
            int[] v2 = new int[x];
            int[] v3 = new int[n + x];

            Console.WriteLine("Introduceti elementele vectorului v1");
            for (int i = 0; i < n; i++)
            {
                v1[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Introduceti elementele vectorului v2");
            for (int i = 0; i < x; i++)
            {
                v2[i] = int.Parse(Console.ReadLine());
            }
            do
            {
                if (v1[l] < v2[m])
                {
                    v3[z] = v1[l];
                    z++;
                    l++;
                }
                else
                {
                    v3[z] = v2[m];
                    z++;
                    m++;
                }
            } while (l < n && m < x);
            if (l < n)
            {
                for (int i = l; i < n; i++)
                {
                    v3[z] = v1[i];
                    z++;
                }
            }
            if (m < x)
            {
                for (int i = m; i < x; i++)
                {
                    v3[z] = v2[i];
                    z++;
                }
            }
            for (int i = 0; i < z; i++)
            {
                Console.Write($"{v3[i]} ");
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Aceleasi cerinte ca si la problema anterioara dar de data asta 
        /// elementele sunt stocate ca vectori cu valori binare
        /// (v[i] este 1 daca i face parte din multime si este 0 in caz contrar).
        /// </summary>
        private static void OperatiiCuMultimi3()
        {
            
        }

        /// <summary>
        /// Aceleasi cerinte ca si la problema anterioara dar de data asta 
        /// elementele din v1 respectiv v2  sunt in ordine strict crescatoare.
        /// </summary>
        private static void OperatiiCuMultimi2()
        {
            
        }

        /// <summary>
        /// Se dau doi vectori v1 si v2.
        /// Se cere sa determine intersectia, reuniunea, si diferentele v1-v2 si v2 -v1 
        /// (implementarea operatiilor cu multimi).
        /// Elementele care se repeta vor fi scrise o singura data in rezultat.
        /// </summary>
        private static void OperatiiCuMultimi()
        {
            int n, x, intersectia = 0, reuniunea = 0, diferenta1 = 0, diferenta2 = 0;

            Console.WriteLine("Introduceti cate elemente sa aiba vectorul v1");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti cate elemente sa aiba vectorul v2");
            x = int.Parse(Console.ReadLine());

            int[] v1 = new int[n];
            int[] v2 = new int[x];

            Console.WriteLine("Introduceti elementele vectorului v1");
            for (int i = 0; i < n; i++)
            {
                v1[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Introduceti elementele vectorului v2");
            for (int i = 0; i < x; i++)
            {
                v2[i] = int.Parse(Console.ReadLine());
            }
            if (n > x)
            {
                for (int i = 0; i < n; i++)
                {
                    if (v1[i] == v2[i])
                        intersectia = v1[i];
                    else if (v1[i] > v2[i])
                        intersectia = v2[i];
                    else if (v1[i] < v2[i])
                        intersectia = v1[i];
                }
                for (int i = 0; i < n; i++)
                {
                    if (v1[i] == v2[i])
                        reuniunea = v1[i];
                    else if (v1[i] > v2[i])
                        reuniunea = v1[i];
                    else if (v1[i] < v2[i])
                        reuniunea = v2[i];
                }
                for (int i = 0; i < n; i++)
                {
                    diferenta1 = v1[i] - v2[i];
                    diferenta2 = v2[i] - v1[i];
                }
            }
            else if (x > n)
            {
                for (int i = 0; i < x; i++)
                {
                    if (v1[i] == v2[i])
                        intersectia = v1[i];
                    else if (v1[i] > v2[i])
                        intersectia = v2[i];
                    else if (v1[i] < v2[i])
                        intersectia = v1[i];
                }
                for (int i = 0; i < x; i++)
                {
                    if (v1[i] == v2[i])
                        reuniunea = v1[i];
                    else if (v1[i] > v2[i])
                        reuniunea = v1[i];
                    else if (v1[i] < v2[i])
                        reuniunea = v2[i];
                }
                for (int i = 0; i < x; i++)
                {
                    diferenta1 = v1[i] - v2[i];
                    diferenta2 = v2[i] - v1[i];
                }
            }
            Console.WriteLine($"Intersectia este {intersectia}, reuniunea este {reuniunea} iar diferentele sunt {diferenta1} si {diferenta2}");
        }

        /// <summary>
        /// Se dau doi vectori. Se cere sa se determine ordinea lor lexicografica 
        /// (care ar trebui sa apara primul in dictionar).
        /// </summary>
        private static void Lexicografica()
        {
            int n, x, contor = 0;

            Console.WriteLine("Introduceti cate elemente sa aiba primul vector");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti cate elemente sa aiba al doilea vector");
            x = int.Parse(Console.ReadLine());

            int[] v1 = new int[n];
            int[] v2 = new int[x];

            Console.WriteLine("Introduceti elementele primului vector");
            for (int i = 0; i < n; i++)
            {
                v1[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Introduceti elementele vectorului al doilea");
            for (int i = 0; i < x; i++)
            {
                v2[i] = int.Parse(Console.ReadLine());
            }
            if (n > x)
            {
                for (int i = 0; i < x; i++)
                {
                    if (v1[i] > v2[i])
                    {
                        Console.WriteLine("Al doilea vector este primul in ordinea lexicografica");
                        break;
                    }
                    else if (v1[i] < v2[i])
                    {
                        Console.WriteLine("Primul vector este primul in ordinea lexicografica");
                        break;
                    }
                    else if (v1[i] == v2[i])
                        contor++;
                }
                if (contor == x)
                    Console.WriteLine("Al doilea vector este primul in ordinea lexicografica");
            }
            else
            {
                for (int i = 0; i < n; i++)
                {
                    if (v1[i] > v2[i])
                    {
                        Console.WriteLine("Al doilea vector este primul in ordinea lexicografica");
                        break;
                    }
                    else if (v1[i] < v2[i])
                    {
                        Console.WriteLine("Primul vector este primul in ordinea lexicografica");
                        break;
                    }
                    else if (v1[i] == v2[i])
                        contor++;
                }
                if (contor == n)
                {
                    if (n == x)
                        Console.WriteLine("Vectorii sunt egali");
                    else
                        Console.WriteLine("Primul vector este primul in ordinea lexicografica");
                }
            }
        }

        /// <summary>
        /// Se dau doua siraguri de margele formate din margele albe si negre, notate s1, respectiv s2.
        /// Determinati numarul de suprapuneri (margea cu margea) a unui sirag peste celalalt 
        /// astfel incat margelele suprapuse au aceeasi culoare.
        /// Siragurile de margele se pot roti atunci cand le suprapunem.
        /// </summary>
        private static void SiraguriDeMargele()
        {
            int n, x, contor = 0;

            Console.WriteLine("Introduceti cate elemente sa aiba vectorul s1");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti cate elemente sa aiba vectorul s2");
            x = int.Parse(Console.ReadLine());

            int[] s1 = new int[n];
            int[] s2 = new int[x];

            Console.WriteLine("Introduceti elementele vectorului s1");
            for (int i = 0; i < n; i++)
            {
                s1[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Introduceti elementele vectorului s2");
            for (int i = 0; i < x; i++)
            {
                s2[i] = int.Parse(Console.ReadLine());
            }
            if (n > x)
            {
                for (int i = 0; i < n - 1; i++)
                {
                    if (Vector(s1, s2, n, x) != 0)
                        contor++;
                }
            }
            else
            {
                for (int k = 0; k < x - 1; k++)
                {
                    if (Vector(s2, s1, x, n) != 0)
                        contor++;
                }
            }
            Console.WriteLine($"Numarul de suprapuneri a unui sirag peste celalalt este {contor}");
        }

        private static int Vector(int[] s1, int[] s2, int max, int min)
        {
            int contor = 0, j;
            for (int i = 0; i < max - min + 1; i++)
            {
                for (j = 0; j < min && s1[j + i] == s2[j]; j++)
                { }
                if (j == min)
                    contor++;
            }
            return contor;
        }

        /// <summary>
        /// Se da un vector s (vectorul in care se cauta) si un vector p (vectorul care se cauta). 
        /// Determinati de cate ori apare p in s. 
        /// De ex. Daca s = [1,2,1,2,1,3,1,2,1] si p = [1,2,1] atunci p apare in s de 3 ori. 
        /// (Problema este dificila doar daca o rezolvati cu un algoritm liniar).
        /// </summary>
        private static void AparePinS()
        {
            int n, x, contor = 0, j;

            Console.WriteLine("Introduceti cate elemente sa aiba vectorul s");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti cate elemente sa aiba vectorul p");
            x = int.Parse(Console.ReadLine());

            int[] s = new int[n];
            int[] p = new int[x];

            Console.WriteLine("Introduceti elementele vectorului s");
            for (int i = 0; i < n; i++)
            {
                s[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Introduceti elementele vectorului p");
            for (int i = 0; i < x; i++)
            {
                p[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < n - x + 1; i++)
            {
                for (j = 0; j < x && s[j + i] == p[j]; j++)
                { }
                if (j == x)
                    contor++;
            }
            Console.WriteLine($"P apare de {contor} ori in S");
        }

        /// <summary>
        /// Se da un polinom de grad n ai carui coeficienti sunt stocati intr-un vector.
        /// Cel mai putin semnificativ coeficient este pe pozitia zero in vector.
        /// Se cere valoarea polinomului intr-un punct x.
        /// </summary>
        private static void Polinom()
        {
            int n, x, n1, valoare = 0;

            Console.WriteLine("Introduceti gradul polinomului");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti punctul x");
            x = int.Parse(Console.ReadLine());
            n1 = n;

            int[] v = new int[n + 1];

            Console.WriteLine("Introduceti coeficientii");
            for (int i = 0; i < n + 1; i++)
            {
                v[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < n + 1; i++)
            {
                valoare = valoare + (v[i] * (int)Math.Pow(x, n1));
                n1--;
            }
            Console.WriteLine($"Valoarea polinomului in punctul {x} este {valoare}");
        }

        /// <summary>
        /// Se da un numar n in baza 10 si un numar b. 1 < b < 17. 
        /// Sa se converteasca si sa se afiseze numarul n in baza b.
        /// </summary>
        private static void ConvertireNinB()
        {
            int n, b, x = 0, rest;

            Console.WriteLine("Introduceti un numar in baza 10");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti baza in care vreti sa convertiti numarul (intre 1 si 17)");
            b = int.Parse(Console.ReadLine());

            int[] v = new int[n];

            do
            {
                rest = n % b;
                n = n / b;
                v[x] = rest;
                x++;
            } while (n != 0);
            Console.WriteLine("Numarul convertit este:");
            for (int i = x - 1; i >= 0; i--)
            {
                if (v[i] < 10)
                    Console.Write($"{v[i]}");
                else if (v[i] >= 10)
                    Console.Write($"{(char)(v[i] + (int)'A' - 10)}");
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Se da un vector de n numere naturale. 
        /// Determinati cel mai mare divizor comun al elementelor vectorului.
        /// </summary>
        private static void CMMDC()
        {
            int n, cmmdc, elvect;

            Console.WriteLine("Introduceti cate elemente sa aiba vectorul");
            n = int.Parse(Console.ReadLine());

            int[] v = new int[n];

            Console.WriteLine("Introduceti elementele vectorului");
            for (int i = 0; i < n; i++)
            {
                v[i] = int.Parse(Console.ReadLine());
            }
            cmmdc = v[0];
            for (int i = 1; i < n; i++)
            {
                elvect = v[i];
                while (elvect != cmmdc)
                {
                    if (elvect > cmmdc)
                        elvect = elvect - cmmdc;
                    else if (elvect < cmmdc)
                        cmmdc = cmmdc - elvect;
                }
            }
            Console.Write($"Cel mai mare divizor comun al elementelor vectorului este {cmmdc}");
        }

        /// <summary>
        /// Modificati un vector prin eliminarea elementelor care se repeta, fara a folosi un alt vector.
        /// </summary>
        private static void EliminareElRep()
        {
            int n;

            Console.WriteLine("Introduceti cate elemente sa aiba vectorul");
            n = int.Parse(Console.ReadLine());

            int[] v = new int[n];

            Console.WriteLine("Introduceti elementele vectorului");
            for (int i = 0; i < n; i++)
            {
                v[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (v[i] == v[j])
                    {
                        for (int k = j; k < n - 1; k++)
                        {
                            v[k] = v[k + 1];
                        }
                        n--;
                        j--;
                    }
                }
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{v[i]} ");
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Interschimbati elementele unui vector in asa fel incat la final 
        /// toate valorile egale cu zero sa ajunga la sfarsit.
        /// </summary>
        private static void ZeroLaSfarsit()
        {
            int n, aux;

            Console.WriteLine("Introduceti cate elemente sa aiba vectorul");
            n = int.Parse(Console.ReadLine());

            int[] v = new int[n];

            Console.WriteLine("Introduceti elementele vectorului");
            for (int i = 0; i < n; i++)
            {
                v[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (v[i] == 0 && v[j] != 0)
                    {
                        aux = v[i];
                        v[i] = v[j];
                        v[j] = aux;
                    }
                }
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{v[i]} ");
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Se da un numar natural n. 
        /// Se cere sa se afiseze toate numerele prime mai mici sau egale cu n (ciurul lui Eratostene).
        /// </summary>
        private static void Eratostene()
        {
            int n;

            Console.WriteLine("Introduceti cate elemente sa aiba vectorul");
            n = int.Parse(Console.ReadLine());

            int[] v = new int[n];

            for (int i = 0; i < n; i++)
            {
                v[i] = 0;
            }
            v[0] = 1;
            v[1] = 1;
            for (int i = 2; i < Math.Sqrt(n); i++)
            {
                if (v[i] == 0)
                {
                    for (int j = 2; j < n / i; j++)
                    {
                        v[i * j] = 1;
                    }
                }
            }
            for (int i = 0; i < n; i++)
            {
                if (v[i] == 0)
                    Console.Write($"{i} ");
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Cautare binara. Se da un vector cu n elemente sortat in ordine crescatoare. 
        /// Se cere sa se determine pozitia unui element dat k. 
        /// Daca elementul nu se gaseste in vector rezultatul va fi -1.
        /// </summary>
        private static void PozitieK2()
        {
            int n, k, poz = 0;

            Console.WriteLine("Introduceti cate elemente sa aiba vectorul");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti k");
            k = int.Parse(Console.ReadLine());

            int[] v = new int[n];

            Console.WriteLine("Introduceti elementele vectorului in ordine crescatoare");
            for (int i = 0; i < n; i++)
            {
                v[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i <= n - 2; i++)
            {
                if (v[i + 1] < v[i])
                    Console.WriteLine("Numerele nu sunt in ordine crescatoare");
            }
            for (int i = 0; i < n && poz == 0; i++)
            {
                if (v[i] == k)
                {
                    poz = 1;
                    Console.WriteLine($"Pozitia pe care apare {k} este {i + 1}");
                }
            }
            if (poz == 0)
                Console.WriteLine("-1");
        }

        /// <summary>
        /// Reverse. Se da un vector n elemente. Se cere sa se inverseze ordinea elementelor din vector.
        /// Prin inversare se intelege ca primul element devine ultimul, al doilea devine penultimul etc.
        /// </summary>
        private static void Inversare()
        {
            int n;

            Console.WriteLine("Introduceti cate elemente sa aiba vectorul");
            n = int.Parse(Console.ReadLine());

            int[] v = new int[n];
            int[] x = new int[n];

            Console.WriteLine("Introduceti elementele vectorului");
            for (int i = 0; i < n; i++)
            {
                v[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Vectorul cu elementele inversate este:");
            for (int i = 0; i < n; i++)
            {
                x[i] = v[n - 1 - i];
                Console.Write($"{x[i]} ");
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Se da un vector cu n elemente si o pozitie din vector k. 
        /// Se cere sa se stearga din vector elementul de pe pozitia k. 
        /// Prin stergerea unui element, toate elementele din dreapta lui se muta cu o pozitie spre stanga.
        /// </summary>
        private static void StergeK()
        {
            int n, k1, k;

            Console.WriteLine("Introduceti cate elemente sa aiba vectorul");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti pozitia k");
            k1 = int.Parse(Console.ReadLine());

            int[] v = new int[n];

            Console.WriteLine("Introduceti elementele vectorului");
            for (k = 0; k < n; k++)
            {
                v[k] = int.Parse(Console.ReadLine());
            }
            for (k = k1; k < n; k++)
            {
                v[k - 1] = v[k];
            }
            n--;
            for (k = 0; k < n; k++)
            {
                Console.Write($"{v[k]} ");
            }
        }

        /// <summary>
        /// Se da un vector cu n elemente, o valoare e si o pozitie din vector k. 
        /// Se cere sa se insereze valoarea e in vector pe pozitia k. 
        /// Primul element al vectorului se considera pe pozitia zero.
        /// </summary>
        private static void EinpozK()
        {
            int n, e, k, k1;

            Console.WriteLine("Introduceti cate elemente sa aiba vectorul");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti valoarea pentru e");
            e = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti pozitia k");
            k1 = int.Parse(Console.ReadLine());

            int[] v = new int[n];

            Console.WriteLine("Introduceti elementele vectorului");
            for (k = 0; k < n; k++)
            {
                v[k] = int.Parse(Console.ReadLine());
            }
            for (k = 0; k < n; k++)
            {
                if (k == k1)
                {
                    v[k1] = v[k];
                    v[k] = e;
                }
                Console.Write($"{v[k]} ");
            }
        }

        /// <summary>
        /// Deteminati printr-o singura parcurgere, cea mai mica si cea mai mare valoare 
        /// dintr-un vector si de cate ori apare acestea.
        /// </summary>
        private static void CmmCmM2()
        {
            int n, cmm, cmM, contor1 = 0, contor2 = 0;

            Console.WriteLine("Introduceti cate elemente sa aiba vectorul");
            n = int.Parse(Console.ReadLine());

            int[] v = new int[n];

            cmm = v[0];
            cmM = v[0];

            Console.WriteLine("Introduceti elementele vectorului");
            for (int i = 0; i < n; i++)
            {
                v[i] = int.Parse(Console.ReadLine());

                if (v[i] < cmm || v[i] == v[0])
                    cmm = v[i];
                if (v[i] == cmm)
                    contor1++;
                else if (v[i] > cmM || v[i] == v[0])
                    cmM = v[i];
                if (v[i] == cmM)
                {
                    contor2++;
                    if (v[i - 1] < cmM && v[i - 1] > cmm)
                        contor2--;
                }
            }
            Console.WriteLine($"Cea mai mica valoare a vectorului este {cmm} si apare de {contor1} ori, " +
                $"iar cea mai mare este {cmM} si apare de {contor2} ori");
        }

        /// <summary>
        /// Sa se determine pozitiile dintr-un vector pe care apar cel mai mic 
        /// si cel mai mare element al vectorului. 
        /// Pentru extra-credit realizati programul efectuand 3n/2 comparatii (in cel mai rau caz).
        /// </summary>
        private static void CmmCmM()
        {
            int n, cmm, cmM;

            Console.WriteLine("Introduceti cate elemente sa aiba vectorul");
            n = int.Parse(Console.ReadLine());

            int[] v = new int[n];

            cmm = v[0];
            cmM = v[0];

            Console.WriteLine("Introduceti elementele vectorului");
            for (int i = 0; i < n; i++)
            {
                v[i] = int.Parse(Console.ReadLine());

                if (v[i] < cmm || v[i] == v[0])
                {
                    cmm = v[i];
                    Console.WriteLine($"Numarul se afla in pozitia {i}");
                }
                else if (v[i] > cmM || v[i] == v[0])
                {
                    cmM = v[i];
                    Console.WriteLine($"Numarul se afla in pozitia {i}");
                }
            }
            Console.WriteLine($"Cel mai mic element al vectorului este {cmm} si cel mai mare este {cmM}");
        }

        /// <summary>
        /// Se da un vector cu n elemente si o valoare k. 
        /// Se cere sa se determine prima pozitie din vector pe care apare k. 
        /// Daca k nu apare in vector rezultatul va fi -1.
        /// </summary>
        private static void PozitieK()
        {
            int n, k, poz = 0;

            Console.WriteLine("Introduceti cate elemente sa aiba vectorul");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti k");
            k = int.Parse(Console.ReadLine());

            int[] v = new int[n];

            Console.WriteLine("Introduceti elementele vectorului");
            for (int i = 0; i < n; i++)
            {
                v[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < n && poz == 0; i++)
            {
                if (v[i] == k)
                {
                    poz = 1;
                    Console.WriteLine($"Pozitia pe care apare {k} este {i + 1}");
                }
            }
            if (poz == 0)
                Console.WriteLine("-1");
        }

        /// <summary>
        /// Calculati suma elementelor unui vector de n numere citite de la tastatura. 
        /// Rezultatul se va afisa pe ecran.
        /// </summary>
        private static void Suma()
        {
            int n, suma = 0;
            
            Console.WriteLine("Introduceti cate elemente sa aiba vectorul");
            n = int.Parse(Console.ReadLine());
            
            int[] v = new int[n];

            Console.WriteLine("Introduceti elementele vectorului");
            for (int i = 0; i < n; i++)
            {
                v[i] = int.Parse(Console.ReadLine());

                suma = suma + v[i];
            }
            Console.WriteLine($"Suma elementelor vectorului este {suma}");
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
