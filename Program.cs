using System;

namespace Gritador
{
    class Program
    {
        static void Main(string[] args)

        {
            string Frase;
            Console.Clear();
           Console.ForegroundColor = ConsoleColor.DarkBlue;
           Console.WriteLine("!!!GRITADOR!!!");
           Console.WriteLine(@"    ###");
           Console.WriteLine(@"   |~ ~|");
           Console.WriteLine(@"  (  -  )");
           Console.WriteLine(@" //¨¨¨¨¨\\");
           Console.ResetColor();


           Console.WriteLine("\nDiga algo baixinho:");
           Frase = Console.ReadLine().ToUpper();
           Console.Clear();

           Console.ForegroundColor = ConsoleColor.Yellow;
           Console.WriteLine("!!!GRITADOR!!!");
           Console.WriteLine(@"    ###");
           Console.WriteLine(@"   |@ @|");
           Console.WriteLine(@$" W(  O  )W    {Frase}");
           Console.WriteLine(@" \\¨¨¨¨¨//");
           Console.ResetColor();
           //Console.WriteLine(Frase);
                            

        }
    }
}
