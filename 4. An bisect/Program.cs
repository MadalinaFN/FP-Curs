using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.An_bisect
{
    class Program
    {
        static void Main(string[] args)
        {
            // Determinati daca un an y este an bisect.

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
    }
}
