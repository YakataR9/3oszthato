using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3oszthato2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Adjon meg egy számot(1-20-ig): ");
            int szam = Convert.ToInt32(Console.ReadKey());
            if (szam % 3 == 0 ) 
            {
                Console.WriteLine("A szám osztható 3-mal");
            }
            else
            {
                Console.WriteLine("A szám nem osztható 3-mal");
            }
            Console.ReadKey();                
        }
    }
}
