using BrazilHolidays.Net.Extention;
using System;
using System.Collections.Generic;
using System.Text;

namespace BrazilHolidays.Net
{
    public static class Today
    {
        public static bool TodayIsHoliday()
        {
            return DateTime.Today.IsHoliday();
        }

        public static bool TodayIsNotHoliday()
        {
            return !TodayIsHoliday();
        }
    }
}
