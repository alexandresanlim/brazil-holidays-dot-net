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
            var diaDoTrabalho = BrazilHolidays.Net.DataStore.Holiday.GetOneByYear(BrazilHolidays.Net.DataStore.Holiday.HolidayIdentity.DiaDoTrabalho, DateTime.Now.Year);
            var daysToDiaDoTrabalho = diaDoTrabalho.HappenInDays();
        }
    }
}
