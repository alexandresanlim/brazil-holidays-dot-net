using System;

namespace BrazilHolidays.Net
{
    public static class Tomorrow
    {
        public static bool WillBeHoliday()
        {
            return DateTime.Today.AddDays(1).IsHoliday();
        }

        public static bool WilNotBeHoliday()
        {
            return !WillBeHoliday();
        }
    }
}
