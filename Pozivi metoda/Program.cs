using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Vsite.CSharp.NetFrameWork
{
    class Program
    {
        static void NekaMetoda()
        {
            int sum = 0;
            for (int i = 0; i < 1000; ++i)
                ++sum;
        }

        // ++TODO:020 Pokrenuti program nekoliko puta i usporediti vremena ispisa
        static void Main(string[] args)
        {
            // štoperica
            Stopwatch stopWatch = new Stopwatch();

            // ++TODO:021 Otkomentirati donjih šest naredbi i uporediti rezultate s prijašnjima
            stopWatch.Restart();
            stopWatch.Stop();
            Console.WriteLine($"Prvo pokretanje/zaustavljanje štoperice: {stopWatch.Elapsed.Ticks}");

            stopWatch.Restart();
            stopWatch.Stop();
            Console.WriteLine($"Drugo pokretanje/zaustavljanje štoperice: {stopWatch.Elapsed.Ticks}");

            // prvi poziv metode
            stopWatch.Restart();
            NekaMetoda();
            stopWatch.Stop();
            Console.WriteLine($"Prvi poziv: {stopWatch.Elapsed.Ticks}");

            // još jednom pozivamo metodu
            stopWatch.Restart();
            NekaMetoda();
            stopWatch.Stop();
            Console.WriteLine($"Drugi poziv: {stopWatch.Elapsed.Ticks}");

            // ponovno pozivamo metodu 50 puta
            stopWatch.Restart();
            for (int i = 0; i < 50; ++i)
                NekaMetoda();
            stopWatch.Stop();
            Console.WriteLine($"50 poziva: {stopWatch.Elapsed.Ticks}");

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey(true);
        }
    }
}
