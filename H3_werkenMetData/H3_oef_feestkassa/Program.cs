using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H3_oef_feestkassa
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t***************");
            Console.WriteLine("\tFrietjes: 20euro \n\tKoninginnehapje : 10euro " +
                "\n\tIjsjes: 3euro \n\tAlle dranken: 2euro");
            Console.WriteLine("\t***************\n");
            Console.WriteLine("Frietjes?");
            Random aantalFriet = new Random(); 
            int Frieten = Convert.ToInt32(aantalFriet.Next(0,40));
            Console.WriteLine($"{Frieten}");
            int somFriet = Frieten * 20;
            Console.WriteLine($"Tussenprijs = {somFriet} euro");

            Console.WriteLine("Koninginnehapje?");
            string aantalHapjes = Console.ReadLine();
            int konHapjes = Convert.ToInt32(aantalHapjes);
            int somHapjes = konHapjes * 10;
            Console.WriteLine($"Tussenprijs = {somFriet} + {somHapjes} euro");

            Console.WriteLine("Ijsjes?");
            string aantalIsje = Console.ReadLine();
            int Isjes = Convert.ToInt32(aantalIsje);
            int somIsjes = Isjes * 3;
            Console.WriteLine($"Tussenprijs = {somFriet} + {somHapjes} + {somIsjes} euro");

            Console.WriteLine("Dranken?");
            string aantalDrank = Console.ReadLine();
            int Dranken = Convert.ToInt32(aantalDrank);
            int somDrank = Dranken * 2;
            Console.WriteLine($"Tussenprijs = {somFriet} + {somHapjes} + {somIsjes} + {somDrank} euro");

            int teBetalen = somDrank + somFriet + somHapjes + somIsjes;
            Console.WriteLine($"\nHet totaal te betalen bedrag is {teBetalen} EURO");
            Console.ReadKey();
        }
    }
}