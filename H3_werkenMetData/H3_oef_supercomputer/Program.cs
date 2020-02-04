using System;

namespace H3_oef_supercomputer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Drie kommagetallen: ");
            double kommaGetal1 = Convert.ToDouble(Console.ReadLine());
            double kommaGetal2 = Convert.ToDouble(Console.ReadLine());
            double kommaGetal3 = Convert.ToDouble(Console.ReadLine());

            double result = (kommaGetal1 + kommaGetal2 + kommaGetal3)/3;
            Console.WriteLine($"Het resultaat: {result}");
        }
    }
}
