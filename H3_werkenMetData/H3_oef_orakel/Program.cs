using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H3_oef_orakel
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\tGuess what!\n[ENTER]");
            Console.ReadKey();
            Random liveLong = new Random();
            int life = liveLong.Next(5, 125);
            Console.WriteLine($"Je zal nog {life} jaar leven.");
            Console.ReadKey();
        }
    }
}
