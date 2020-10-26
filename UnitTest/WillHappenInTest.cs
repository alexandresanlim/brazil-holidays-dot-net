using BrazilHolidays.Net.DataStore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTest
{
    [TestClass]
    public class WillHappenInTest
    {
        [TestMethod]
        public void WillHappenNatal()
        {
            var natal = BrazilHolidays.Net.DataStore.Holiday.GetOneByYear(BrazilHolidays.Net.DataStore.Holiday.HolidayIdentity.Natal, DateTime.Now.Year);
            var daysToNatal = natal.HappenInDays();
        }

        [TestMethod]
        public void WillHappenDiaDoTrabalho()
        {
            var natal = BrazilHolidays.Net.DataStore.Holiday.GetOneByYear(BrazilHolidays.Net.DataStore.Holiday.HolidayIdentity.Natal, DateTime.Now.Year);
            var daysToNatal = natal.HappenInDays();

            var a = Holiday.GetAllNext();

            var next = Holiday.GetNext();

            var old = Holiday.GetOld();

            var m = Holiday.GetAllByMonth(2);
        }
    }
}
