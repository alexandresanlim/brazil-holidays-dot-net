using System;
using System.Collections.Generic;
using System.Text;

namespace BrazilHolidays.Net.DataStore
{
    class Date
    {
        public static IList<DateTime> GetHolidaysByCurrentYear(int? yearParameter = null)
        {
            var holidayList = new List<DateTime>();
            var year = DateTime.Now.Year;

            if (yearParameter != null)
                year = yearParameter.Value;

            holidayList.Add(new DateTime(year, 1, 1)); //Ano novo 
            holidayList.Add(new DateTime(year, 4, 21));  //Tiradentes
            holidayList.Add(new DateTime(year, 5, 1)); //Dia do trabalho
            holidayList.Add(new DateTime(year, 9, 7)); //Dia da Independência do Brasil
            holidayList.Add(new DateTime(year, 10, 12));  //Nossa Senhora Aparecida
            holidayList.Add(new DateTime(year, 11, 2)); //Finados
            holidayList.Add(new DateTime(year, 11, 15)); //Proclamação da República
            holidayList.Add(new DateTime(year, 12, 25)); //Natal

            #region FeriadosMóveis

            int x, y;
            int a, b, c, d, e;
            int day, month;

            if (year >= 1900 & year <= 2099)
            {
                x = 24;
                y = 5;
            }
            else
                if (year >= 2100 & year <= 2199)
            {
                x = 24;
                y = 6;
            }
            else
                    if (year >= 2200 & year <= 2299)
            {
                x = 25;
                y = 7;
            }
            else
            {
                x = 24;
                y = 5;
            }

            a = year % 19;
            b = year % 4;
            c = year % 7;
            d = (19 * a + x) % 30;
            e = (2 * b + 4 * c + 6 * d + y) % 7;

            if ((d + e) > 9)
            {
                day = (d + e - 9);
                month = 4;
            }

            else
            {
                day = (d + e + 22);
                month = 3;
            }

            var pascoa = new DateTime(year, month, day);
            var sextaSanta = pascoa.AddDays(-2);
            var carnaval = pascoa.AddDays(-47);
            var corpusChristi = pascoa.AddDays(60);

            holidayList.Add(pascoa);
            holidayList.Add(sextaSanta);
            holidayList.Add(carnaval);
            holidayList.Add(corpusChristi);

            #endregion

            return holidayList;
        }
    }
}
