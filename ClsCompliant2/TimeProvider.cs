using System;

[assembly: CLSCompliant(true)]
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

        private static string GetDatetime()
        {
            return DateTime.UtcNow.ToLongDateString();
        }
    }
}
