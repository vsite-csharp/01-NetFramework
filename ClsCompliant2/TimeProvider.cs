using System;
[assembly:CLSCompliant(true)]
namespace ProvideTime
{
    public class TimeProvider
    {
        public static string GetDateTime(string ime)
        {
            return DateTime.Now.ToShortTimeString();
        }

        public static string GetDateTime()
        {
            return DateTime.Now.ToString(); 
        }

        // TODO:033 Promijeniti pravo pristupa donje metode iz public u private te napraviti build projekta VbNetForm, pokrenuti program i provjeriti funkcionalnost.
        static string GetDatetime()
        {
            return DateTime.UtcNow.ToLongDateString();
        }
    }
}
