using System;
using System.Collections.Generic;
using System.Linq;

namespace BrazilHolidays.Net
{
    public class Holiday : IHoliday
    {
        public Holiday(DateTime _dateTime, string _title)
        {
            Title = _title;
            Date = _dateTime;
        }

        public string Title { get; private set; }

        public DateTime Date { get; private set; }

        public HolidayIdentity Identity { get; set; }

        private static List<IHoliday> CustomHolidayList { get; set; } = new List<IHoliday>();

        public static void AddCustomHoliday(IHoliday holidayToAddInCustom)
        {
            holidayToAddInCustom.Identity = HolidayIdentity.Custom;
            CustomHolidayList.Add(holidayToAddInCustom);
        }

        public static void AddCustomHoliday(IEnumerable<IHoliday> holidayToAddInCustomList)
        {
            CustomHolidayList.AddRange(holidayToAddInCustomList);
        }

        public static IEnumerable<IHoliday> GetAllByMonth(Months month)
        {
            return GetAllNext().Where(x => x.Date.Month == (int)month);
        }

        public static IHoliday GetNext()
        {
            return GetAllNext().FirstOrDefault();
        }

        public static IHoliday GetOld()
        {
            return GetAllByYear(DateTime.Today.Year).LastOrDefault(x => x.Date <= DateTime.Today);
        }

        public static IEnumerable<IHoliday> GetAllNext()
        {
            var actualMonth = DateTime.Today.Month;

            var nextActualYear = GetAllByYear(DateTime.Today.Year).Where(x => x.Date.Month >= actualMonth && x.Date >= DateTime.Today.Date);
            var nextNextYear = GetAllByYear(DateTime.Today.Year + 1).Where(x => x.Date.Month <= actualMonth);

            var l = new List<IHoliday>();
            l.AddRange(nextActualYear);
            l.AddRange(nextNextYear);

            return l.OrderBy(x => x.Date);
        }

        /// <param name="yearParameter">Ano para buscar os feriados, por padrão é o ano corrente</param>
        /// <returns>Lista de todos feriados, fixos, móveis e customizados</returns>
        public static IEnumerable<IHoliday> GetAllByYear(int? yearParameter = null)
        {
            var holidayList = new List<IHoliday>();

            var year = yearParameter ?? DateTime.Today.Year;

            holidayList.AddRange(GetAllFixByYear(year));
            holidayList.AddRange(GetAllMoveByYear(year));
            holidayList.AddRange(CustomHolidayList);

            return holidayList.OrderBy(z => z.Date);
        }

        /// <param name="yearParameter">Ano para buscar os feriados, por padrão é o ano corrente</param>
        /// <returns>Lista de feriados fixos como Natal</returns>
        public static IEnumerable<IHoliday> GetAllFixByYear(int? yearParameter = null)
        {
            var year = yearParameter ?? DateTime.Today.Year;

            var holidayList = new List<IHoliday>
            {
                new Holiday(new DateTime(year, 1, 1), "Ano Novo") { Identity = HolidayIdentity.AnoNovo },
                new Holiday(new DateTime(year, 4, 21), "Tiradentes") { Identity = HolidayIdentity.Tiradentes },
                new Holiday(new DateTime(year, 5, 1), "Dia do trabalho") { Identity = HolidayIdentity.DiaDoTrabalho },
                new Holiday(new DateTime(year, 9, 7), "Independência do Brasil") { Identity = HolidayIdentity.IdependenciaDoBrasil },
                new Holiday(new DateTime(year, 10, 12), "Nossa Senhora Aparecida") { Identity = HolidayIdentity.NossaSenhoraAparecida },
                new Holiday(new DateTime(year, 11, 2), "Finados") { Identity = HolidayIdentity.Finados },
                new Holiday(new DateTime(year, 11, 15), "Proclamação da República") { Identity = HolidayIdentity.ProclamacaoDaRepublica },
                new Holiday(new DateTime(year, 11, 20), "Consciência Negra") { Identity = HolidayIdentity.ConscienciaNegra },
                new Holiday(new DateTime(year, 12, 25), "Natal") { Identity = HolidayIdentity.Natal }
            };

            return holidayList;

        }

        /// <param name="yearParameter">Ano para buscar os feriados, por padrão é o ano corrente</param>
        /// <returns>Lista de feriados móveis</returns>
        public static IEnumerable<IHoliday> GetAllMoveByYear(int? yearParameter = null)
        {
            var holidayList = new List<IHoliday>();

            var year = yearParameter ?? DateTime.Today.Year;

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

            holidayList.Add(new Holiday(pascoa, "Páscoa") { Identity = HolidayIdentity.Pascoa });
            holidayList.Add(new Holiday(sextaSanta, "Sexta-Feira Santa") { Identity = HolidayIdentity.SextaFeiraSanta });
            holidayList.Add(new Holiday(carnaval, "Carnaval") { Identity = HolidayIdentity.Carnaval });
            holidayList.Add(new Holiday(corpusChristi, "Corpus Christi") { Identity = HolidayIdentity.CorpusChristi });

            #endregion

            return holidayList;
        }

        /// <returns>Lista de feriados customizaveis que não são feriados nacionais mas foram adicionados usando o método AddCustomHoliday</returns>
        public static IEnumerable<IHoliday> GetAllCustomByYear() => CustomHolidayList;

        public static IHoliday GetOneByYear(HolidayIdentity identity, int? yearParameter = null)
        {
            return GetAllByYear(yearParameter).FirstOrDefault(x => x.Identity == identity);
        }
    }
}
