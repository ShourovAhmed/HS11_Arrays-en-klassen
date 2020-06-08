using System;

namespace Prijzen
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] prijzen = new double[20];
            
            for (int i = 0; i < prijzen.Length; i++)
            {
                Console.WriteLine("Voer een prijs in:");
                prijzen[i] = Convert.ToDouble(Console.ReadLine()); 
            }
            Console.WriteLine("\n");

            double tot = 0;
            Console.WriteLine("Prijzen groter of gelijk aan 5:");
            foreach (var prijs in prijzen)
            {
                tot += prijs;
                if (prijs >= 5)
                    Console.WriteLine(prijs);

            }
            Console.WriteLine("\n");
            Console.WriteLine($"Gemiddelde: {tot/prijzen.Length}");
        }
    }
}
