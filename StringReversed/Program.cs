using System;

namespace StringReversed
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib eesnime
            //programm kirjutab nime tagurpidi

            Console.WriteLine("Sisesta eesnimi:");
            string eesnimi = Console.ReadLine();

            for (int i = eesnimi.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(eesnimi[i]);
            }
        }
    }
}
