using System;

namespace Vsite.CSharp.NetFramework
{
    // Pogledati strukturu projekta: Properties, References...
    // Kliknuti na projekt desnom tipkom miša i iz kontekstnog izbornika izabrati "Open Folder in File Explorer". Pogledati strukturu kazala.
    // Napraviti build programa i pogledati koja kazala i datoteke je Visual Studio kreirao.
    // Pokrenuti program i pogledati ispis.
    // Pomoću programa ILDasm (obično unutar "C:\Program Files (x86)\Microsoft SDKs\Windows\vNN.N\bin\NETFX N.N.N Tools") pogledati sadržaj generirane izvedbene datoteke.
    class Program
    {
        static void Main(string[] args)
        {
            int a = 14;
            double d = 3.14;
            Console.WriteLine(a);
            Console.WriteLine(d);
            Console.WriteLine("Zdravo");
            Console.ReadKey();
        }
    }
}
