using System;

namespace StringAndForLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta eesnimi:");
            string eesnimi = Console.ReadLine();

            for (int i = 0; i < eesnimi.Length; i++)
            {
                Console.WriteLine(eesnimi[i]);
            }
        }
    }
}
