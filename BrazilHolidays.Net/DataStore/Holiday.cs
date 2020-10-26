using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrazilHolidays.Net.DataStore
{
    public class Holiday
    {
        public string Title { get; set; }

        public string Description { get; set; }

        public DateTime Date { get; set; }

        public HolidayIdentity Identity { get; set; }

        private static List<Holiday> CustomHolidayList { get; set; } = new List<Holiday>();

        public static void SetNewCustomHoliday(Holiday holidayToAddInCustom)
        {
            CustomHolidayList.Add(holidayToAddInCustom);
        }

        public static void SetNewCustomHoliday(IList<Holiday> holidayToAddInCustomList)
        {
            CustomHolidayList.AddRange(holidayToAddInCustomList);
        }


        public static IList<Holiday> GetAllByMonth(int month)
        {
            return GetAllNext().Where(x => x.Date.Month == month).ToList();
        }

        public static Holiday GetNext()
        {
            return GetAllNext().FirstOrDefault(x => x.Date >= DateTime.Today);
        }

        public static Holiday GetOld()
        {
            return GetAllNext().FirstOrDefault(x => x.Date < DateTime.Today);
        }

        public static IList<Holiday> GetAllNext()
        {
            var actualMonth = DateTime.Now.Month;

            var nextActualYear = GetAllByYear(DateTime.Now.Year).Where(x => x.Date.Month >= actualMonth);
            var nextNextYear = GetAllByYear(DateTime.Now.Year + 1).Where(x => x.Date.Month < actualMonth);

            var l = new List<Holiday>();
            l.AddRange(nextActualYear);
            l.AddRange(nextNextYear);

            return l;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="yearParameter">It's to year, default's current year</param>
        /// <returns>Holiday list from Brazil</returns>
        public static IList<Holiday> GetAllByYear(int? yearParameter = null)
        {
            var holidayList = new List<Holiday>();

            var year = yearParameter ?? DateTime.Now.Year;

            holidayList.Add(new Holiday { Date = new DateTime(year, 1, 1), Title = "Ano Novo", Identity = HolidayIdentity.AnoNovo });
            holidayList.Add(new Holiday { Date = new DateTime(year, 4, 21), Title = "Tiradentes", Identity = HolidayIdentity.Tiradentes });
            holidayList.Add(new Holiday { Date = new DateTime(year, 5, 1), Title = "Dia do trabalho", Identity = HolidayIdentity.DiaDoTrabalho });
            holidayList.Add(new Holiday { Date = new DateTime(year, 9, 7), Title = "Independência do Brasil", Identity = HolidayIdentity.IdependenciaDoBrasil });
            holidayList.Add(new Holiday { Date = new DateTime(year, 10, 12), Title = "Nossa Senhora Aparecida", Identity = HolidayIdentity.NossaSenhoraAparecida });
            holidayList.Add(new Holiday { Date = new DateTime(year, 11, 2), Title = "Finados", Identity = HolidayIdentity.Finados });
            holidayList.Add(new Holiday { Date = new DateTime(year, 11, 15), Title = "Proclamação da República", Identity = HolidayIdentity.ProclamacaoDaRepublica });
            holidayList.Add(new Holiday { Date = new DateTime(year, 12, 25), Title = "Natal", Identity = HolidayIdentity.Natal });

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

            holidayList.Add(new Holiday { Date = pascoa, Title = "Páscoa", Identity = HolidayIdentity.Pascoa });
            holidayList.Add(new Holiday { Date = sextaSanta, Title = "Sexta-Feira Santa", Identity = HolidayIdentity.SextaFeiraSanta });
            holidayList.Add(new Holiday { Date = carnaval, Title = "Carnaval", Identity = HolidayIdentity.Carnaval });
            holidayList.Add(new Holiday { Date = corpusChristi, Title = "Corpus Christi", Identity = HolidayIdentity.CorpusChristi });

            #endregion

            #region Custom

            holidayList.AddRange(CustomHolidayList);

            #endregion

            return holidayList;
        }

        public static Holiday GetOneByYear(HolidayIdentity identity, int? yearParameter = null)
        {
            return GetAllByYear(yearParameter).FirstOrDefault(x => x.Identity == identity);
        }

        public enum HolidayIdentity
        {
            AnoNovo,
            Tiradentes,
            DiaDoTrabalho,
            IdependenciaDoBrasil,
            NossaSenhoraAparecida,
            Finados,
            ProclamacaoDaRepublica,
            Natal,
            Pascoa,
            SextaFeiraSanta,
            Carnaval,
            CorpusChristi
        }
    }

    public static class HolidayExtention
    {
        public static bool IsHoliday(this DateTime dateToTest)
        {
            return Holiday.GetAllByYear(dateToTest.Year).Any(x => x.Date.Date.Equals(dateToTest.Date));
        }

        public static TimeSpan HappenInTime(this Holiday holiday)
        {
            return (holiday.Date - DateTime.Now.Date);
        }

        public static int HappenInDays(this Holiday holiday)
        {
            return HappenInTime(holiday).Days;
        }

        public static int HappenHours(this Holiday holiday)
        {
            return HappenInTime(holiday).Hours;
        }

        public static int HappenAtMinutes(this Holiday holiday)
        {
            return HappenInTime(holiday).Minutes;
        }

        public static int HappenAtSeconds(this Holiday holiday)
        {
            return HappenInTime(holiday).Seconds;
        }
    }
}
