using System;

namespace Vsite.CSharp.NetFramework
{
    // ++TODO:010 Pogledati i usporediti kod u projektima CSharpConsole i VbNetConsole 
    // ++TODO:011 Prevesti i pokrenuti projekte CSharpConsole i VbNetConsole te usporediti ispise
    // ++TODO:012 Pomoću programa ILDasm usporediti izvedbene kodove oba programa
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for (int i = 1; i <= 100; ++i)
                sum += i;
            Console.WriteLine(sum);

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey(true);
        }
    }
}
