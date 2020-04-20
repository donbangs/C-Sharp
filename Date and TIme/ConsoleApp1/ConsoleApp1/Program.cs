using System;
using System.Globalization;

namespace ConsoleApp1
{
    class Program
    {
        public static void TimeIn(int hour)
        {
            var time = DateTimeOffset.Now.ToOffset(TimeSpan.FromHours(hour));
            foreach (var timeZone in TimeZoneInfo.GetSystemTimeZones())
            {
                if (timeZone.GetUtcOffset(time) == time.Offset)
                {
                    Console.WriteLine(timeZone);
                }
            }
        }
        public static void ParseTimeToUtc(string date )
        {
           Console.WriteLine(DateTime.Parse(date, CultureInfo.InvariantCulture, DateTimeStyles.AdjustToUniversal));
        }
        public static DateTimeOffset ExtendContract(DateTimeOffset current, int months)
        {
            var newContractDate = current.AddMonths(months).AddTicks(-1);
            
            return new DateTimeOffset(newContractDate.Year,
                 newContractDate.Month,
                 DateTime.DaysInMonth(newContractDate.Year,newContractDate.Month),
                 23,59,59,current.Offset);
        }
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now);
            Console.WriteLine(DateTimeOffset.Now);
            Console.WriteLine(DateTimeOffset.UtcNow);
            Console.WriteLine(DateTimeOffset.UtcNow.ToLocalTime());
            Console.WriteLine(DateTimeOffset.UtcNow.ToUniversalTime());

            TimeIn(-10);
            ParseTimeToUtc("2019-07-01 10:22:00 PM +02:00");
         
            Console.WriteLine();
            var start = DateTimeOffset.UtcNow;
            var end = DateTimeOffset.UtcNow.AddSeconds(45);

            TimeSpan difference = end - start;
            Console.WriteLine(difference.TotalSeconds);

            var contractDate = new DateTimeOffset(2020, 2, 29, 0, 0, 0, TimeSpan.Zero);
            Console.WriteLine(contractDate);
            contractDate=ExtendContract(contractDate, 1);
            Console.WriteLine(contractDate);


        }
    }
}
