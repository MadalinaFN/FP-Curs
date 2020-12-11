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
            ZeroLaSfarsit();
            EliminareElRep();
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
            for (int i = n - 1; i >= 0; i--)
            {
                if (v[i] == v[i - 1])
                {
                    for (int j = i; j < n - 1; j++)
                    {
                        v[i] = v[i + 1];
                    }
                    n--;
                }
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
