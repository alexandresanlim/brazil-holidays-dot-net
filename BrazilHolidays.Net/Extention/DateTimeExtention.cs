using BrazilHolidays.Net.DataStore;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace BrazilHolidays.Net.Extention
{
    public static class DateTimeExtention
    {
        public static bool IsHoliday(this DateTime dateToTest)
        {
            var listHolidaysBrazil = Date.GetHolidaysByCurrentYear(dateToTest.Year);
            return listHolidaysBrazil.Contains(dateToTest);
        }
    }
}
