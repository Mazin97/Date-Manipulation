using System;
using System.Globalization;

namespace Date
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Clear();

            Console.WriteLine("Formatos:");
            Console.WriteLine(String.Format("{0:dd/MM/yyyy hh:mm:ss ff z}", DateTime.Now));
            Console.WriteLine(String.Format("{0:t}", DateTime.Now));
            Console.WriteLine(String.Format("{0:T}", DateTime.Now));
            Console.WriteLine(String.Format("{0:d}", DateTime.Now));
            Console.WriteLine(String.Format("{0:D}", DateTime.Now));
            Console.WriteLine(String.Format("{0:g}", DateTime.Now));
            Console.WriteLine(String.Format("{0:f}", DateTime.Now));
            Console.WriteLine(String.Format("{0:r}", DateTime.Now));
            Console.WriteLine(String.Format("{0:R}", DateTime.Now));
            Console.WriteLine(String.Format("{0:s}", DateTime.Now));
            Console.WriteLine(String.Format("{0:u}", DateTime.Now));

            Console.WriteLine();
            Console.WriteLine("Culture Info:");

            var br = new CultureInfo("pt-BR");
            var en = new CultureInfo("en-US");
            var currentCulture = CultureInfo.CurrentCulture;

            Console.WriteLine(DateTime.Now.ToString("D", br));
            Console.WriteLine(DateTime.Now.ToString("D", en));
            Console.WriteLine(DateTime.Now.ToString("D", currentCulture));

            Console.WriteLine();
            Console.WriteLine("Timezone:");

            var timezoneBrazil = TimeZoneInfo.FindSystemTimeZoneById("E. South America Standard Time");

            Console.WriteLine(DateTime.UtcNow.ToString("f"));
            Console.WriteLine(DateTime.UtcNow.ToLocalTime().ToString("f"));
            Console.WriteLine(TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, timezoneBrazil).ToString("f"));
        }
    }
}