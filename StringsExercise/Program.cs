using System;

namespace StringsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string helloworld = "Hello World!";

            //programm kuva lause esimest ja viimast tähte

            Console.WriteLine(helloworld [0]);

            Console.WriteLine(helloworld [helloworld.Length - 1]);
        }
    }
}
