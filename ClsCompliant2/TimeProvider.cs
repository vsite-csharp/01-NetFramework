using System;

// TODO:030 Napraviti build projekta ProvideTime i pogledati ima li pogrešaka ili upozorenja
// TODO:031 Napraviti build projekta VbNetForm i pogledati koju pogrešku javlja
// TODO:032 Otkomentirati donju naredbu i napraviti build projekta te provjeriti javlja li pogreške ili upozorenja
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
