using BrazilHolidays.Net;
using System;
using System.Collections.Generic;
using System.Text;

namespace BrazilHolidays.Net
{
    public static class Today
    {
        public static bool IsHoliday()
        {
            return DateTime.Today.IsHoliday();
        }

        public static bool IsNotHoliday()
        {
            return !IsHoliday();
        }
    }

    public static class Tomorrow
    {
        public static bool IsHoliday()
        {
            return DateTime.Today.AddDays(1).IsHoliday();
        }

        public static bool IsNotHoliday()
        {
            return !IsHoliday();
        }
    }

    public static class Yesterday
    {
        public static bool IsHoliday()
        {
            return DateTime.Today.AddDays(-1).IsHoliday();
        }

        public static bool IsNotHoliday()
        {
            return !IsHoliday();
        }
    }
}
