using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp22 {
   public static class DateTimeExamples {
        public static CultureInfo provider = CultureInfo.InvariantCulture;
        public static void Parse() {
            StringBuilder sb = new StringBuilder();
            var date = DateTime.Parse("28.02.2008");
            sb.AppendLine("День:");
            sb.AppendLine(date.Day.ToString());
            sb.AppendLine("Месяц:");
            sb.AppendLine(date.Month.ToString());
            sb.AppendLine("Год:");
            sb.AppendLine(date.Year.ToString());
            Console.WriteLine(sb.ToString());
        }
        public static void ParseExact() {
           string dateString = "06/15/2008";
           string  format = "d";
            var result = DateTime.ParseExact(dateString, format, provider);
            Console.WriteLine("{0} converts to {1}.", dateString, result.ToString());
        }
        public static void TryParse() {
            DateTime result;
            if (DateTime.TryParse("12.04.1984",out result)) {
                Console.WriteLine($" Удачно прочитали дату: {result.ToString()}");
            }
            else Console.WriteLine("Увы дату прочитать не удалось :(");
        }

        public static void TryParseExact() {
            DateTime result;
            string dateString = "03/12/1987";
            string format = "d";
            if (DateTime.TryParseExact(dateString,format,provider,DateTimeStyles.AllowLeadingWhite,out result)) {
                Console.WriteLine($" Удачно прочитали дату: {result.ToString()}");
            }
            else Console.WriteLine("Увы дату прочитать не удалось :(");
        }
    }
}
