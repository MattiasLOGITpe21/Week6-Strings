using System;

namespace CompareStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutaja eesnime ja perekonna nime
            //programm võrdleb sisestatuid andmeid
            //programm kuvab konsoolis kumb nimi on pikem

            Console.WriteLine("Sisestage oma eesnimi:");
            string eesnimi = Console.ReadLine();
            Console.WriteLine("Sisestage oma perekonna nimi:");
            string perekonnanimi = Console.ReadLine();

            if(eesnimi.Length < perekonnanimi.Length)
            {
                Console.WriteLine("Perekonnanimi on pikem kui eesnimi");
            }
            else if (eesnimi.Length > perekonnanimi.Length)
            {
                Console.WriteLine("Eesnimi on pikem kui perekonnanimi");
            }
            else
            {
                Console.WriteLine("Eesnimi ja perekonnanimi on sama pikad");
            }
        }
    }
}
