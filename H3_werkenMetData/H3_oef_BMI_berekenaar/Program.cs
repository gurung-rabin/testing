using System;

namespace H3_oef_BMI_berekenaar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("^^^^     BMI berekenen      ^^^^^\n");
            Console.WriteLine("Geef u gewicht in kg:");
            double gewicht = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Geef u lengte in cm: ");
            double lengte = Convert.ToDouble(Console.ReadLine());

            double bmi = (gewicht / Math.Pow(lengte,2))*10000;

            Console.WriteLine($"U BMI is {Math.Round(bmi):F2} kg/cm²");
        }
    }
}
