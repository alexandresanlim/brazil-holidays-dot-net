using System;

namespace BrazilHolidays.Net
{
    public static class Yesterday
    {
        public static bool WasHoliday()
        {
            return DateTime.Today.AddDays(-1).IsHoliday();
        }

        public static bool WasNotHoliday()
        {
            return !WasHoliday();
        }
    }
}
