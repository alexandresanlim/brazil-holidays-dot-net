using System;

namespace BrazilHolidays.Net
{
    public interface IHoliday
    {
        string Title { get; }

        DateTime Date { get; }

        HolidayIdentity Identity { get; set; }
    }
}
