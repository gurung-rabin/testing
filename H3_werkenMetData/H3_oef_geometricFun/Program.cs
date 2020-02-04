using System;

namespace H3_oef_geometricFun
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geef een hoek in graden: ");
            int hoekInGraden = Convert.ToInt32(Console.ReadLine()); 
            double naarRad = hoekInGraden * (Math.PI / 180);

            double naarSin = Math.Sin(naarRad);
            double naarCos = Math.Cos(naarRad);
            double naarTan = Math.Tan(naarRad);

            Console.WriteLine($"sin {hoekInGraden}° is {naarSin:F4}");
            Console.WriteLine($"cos {hoekInGraden}° is {naarCos:F4}");
            Console.WriteLine($"tan {hoekInGraden}° is {naarTan:F4}");

            Console.WriteLine($"sin2de {hoekInGraden}° is {naarSin:F4}");
            Console.WriteLine($"cos2de {hoekInGraden}° is {naarCos:F4}");
            Console.WriteLine($"tan2de {hoekInGraden}° is {naarTan:F4}");

            Console.WriteLine($"sin3de {hoekInGraden}° is {naarSin:F4}");
            Console.WriteLine($"cos3de {hoekInGraden}° is {naarCos:F4}");
            Console.WriteLine($"tan3de {hoekInGraden}° is {naarTan:F4}");


        }
    }
}
