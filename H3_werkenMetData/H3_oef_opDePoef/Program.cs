using System;

namespace H3_oef_opDePoef
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Voer bedrag in?");
            string toPay1 = Console.ReadLine();
            double bedrag1 = Convert.ToDouble(toPay1);
            Console.WriteLine($"De proef staat op {bedrag1}");

            Console.WriteLine("Voer bedrag in?");
            string toPay2 = Console.ReadLine();
            double bedrag2 = Convert.ToDouble(toPay2);
            double som2 = bedrag1 + bedrag2;
            Console.WriteLine($"De proef staat op {som2}");

            Console.WriteLine("Voer bedrag in?");
            string toPay3 = Console.ReadLine();
            double bedrag3 = Convert.ToDouble(toPay3);
            double som3 = som2 + bedrag3;
            Console.WriteLine($"De proef staat op {som3}");

            Console.WriteLine("Voer bedrag in?");
            string toPay4 = Console.ReadLine();
            double bedrag4 = Convert.ToDouble(toPay4);
            double som4 = som3 + bedrag4;
            Console.WriteLine($"De proef staat op {som4}");

            Console.WriteLine("Voer bedrag in?");
            string toPay5 = Console.ReadLine();
            double bedrag5 = Convert.ToDouble(toPay5);
            double som5 = som4 + bedrag5; 
            Console.WriteLine($"De proef staat op {som5}");

            Console.WriteLine("\n***************************");
            Console.WriteLine($"Het totaal van de poef is {som5} euro.");

        }
    }
}
