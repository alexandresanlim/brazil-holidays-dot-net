using System;
using System.Linq;

namespace BrazilHolidays.Net
{
    public static class HolidayExtention
    {
        public static bool IsHoliday(this DateTime dateToTest)
        {
            return Holiday.GetAllByYear(dateToTest.Year).Any(x => x.Date.Date.Equals(dateToTest.Date));
        }

        public static TimeSpan HappenInTime(this IHoliday holiday)
        {
            return (holiday.Date - DateTime.Now.Date);
        }

        public static int HappenInDays(this IHoliday holiday)
        {
            return HappenInTime(holiday).Days;
        }

        public static int HappenHours(this IHoliday holiday)
        {
            return HappenInTime(holiday).Hours;
        }

        public static int HappenAtMinutes(this IHoliday holiday)
        {
            return HappenInTime(holiday).Minutes;
        }

        public static int HappenAtSeconds(this IHoliday holiday)
        {
            return HappenInTime(holiday).Seconds;
        }
    }
}
