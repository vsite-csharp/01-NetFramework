using System;

namespace Vsite.CSharp.NetFramework
{
    // TODO:002 Napraviti build programa i pogledati koja kazala i datoteke je Visual Studio kreirao.
    // TODO:003 Pokrenuti program i pogledati ispis.
    // TODO:004 Pomoću programa ILDasm (obično unutar "C:\Program Files (x86)\Microsoft SDKs\Windows\vNN.N\bin\NETFX N.N.N Tools") pogledati sadržaj generirane izvedbene datoteke.
    class Program
    {
        //
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
