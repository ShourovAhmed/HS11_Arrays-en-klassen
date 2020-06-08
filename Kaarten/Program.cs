using System;
using System.Collections.Generic;

namespace Kaarten
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Speelkaart> speelkaarten = new List<Speelkaart>();
            for (int i = 0; i < 4; i++)
            {
                for (int j = 1; j < 14; j++)
                {
                    speelkaarten.Add(new Speelkaart() { Nummer = j, Kleur = (Suite)i});
                }   
            }

            foreach (var kaart in speelkaarten)
            {
                Console.WriteLine($"{kaart.Kleur} {kaart.Nummer}");
                if (kaart.Nummer == 13)
                    Console.WriteLine("\n");
            }

            Random r = new Random();
            while (speelkaarten.Count > 0)
            {
                int totrek = r.Next(0, speelkaarten.Count);
                Console.WriteLine("Getrokken kaart=");
                Console.WriteLine(speelkaarten[totrek].Kleur + " " + speelkaarten[totrek].Nummer);
                speelkaarten.RemoveAt(totrek);
                Console.ReadKey();
            }
        }
    }
}
