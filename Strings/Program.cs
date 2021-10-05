using System;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajalt tema eesnime
            //programm kuvab kasutaja eesnime esimest tähte
            //programm kuvab kasutaja eesnime viimast tähte

            Console.WriteLine("Sisesta oma eesnimi:");
            string eesnimi = Console.ReadLine();
            
            Console.WriteLine(eesnimi[0]);

            int eesnimiLength = eesnimi.Length;
            Console.WriteLine($"Teie nimi on {eesnimiLength} tähte pikk");

            //viimase tähe indeks = eesnimi [eesnimiLength - 1]
            Console.WriteLine(eesnimi [eesnimiLength - 1]);
            
        }
    }
}
