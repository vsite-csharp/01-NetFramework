using System;

namespace Vsite.CSharp.NetFramework
{

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
