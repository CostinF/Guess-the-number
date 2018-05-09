using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guess_the_number
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int r = rnd.Next(0, 100);
            Console.WriteLine("Guess the number. Introduceti un numar intre 0 si 100: ");
            string str = Console.ReadLine();
            int x = int.Parse(str);
            while (x != r)
            {
                while (x > r)
                {
                    Console.WriteLine("Numarul " + x + " este prea mare. Introduceti alt numar: ");
                    str = Console.ReadLine();
                    x = int.Parse(str);
                }
                while (x < r)
                {
                    Console.WriteLine("Numarul " + x + " este prea mic. Introduceti alt numar: ");
                    str = Console.ReadLine();
                    x = int.Parse(str);
                }
            }
            Console.WriteLine("Ai ghicit numarul. Felicitari!");
        }
    }
}