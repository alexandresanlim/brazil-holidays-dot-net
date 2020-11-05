using BrazilHolidays.Net;
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
            var natal = BrazilHolidays.Net.Holiday.GetOneByYear(BrazilHolidays.Net.Holiday.HolidayIdentity.Natal, DateTime.Now.Year);
            var daysToNatal = natal.HappenInDays();
        }

        [TestMethod]
        public void WillHappenDiaDoTrabalho()
        {
            var diaDoTrabalho = BrazilHolidays.Net.Holiday.GetOneByYear(BrazilHolidays.Net.Holiday.HolidayIdentity.DiaDoTrabalho, DateTime.Now.Year);
            var daysToDiaDoTrabalho = diaDoTrabalho.HappenInDays();
        }
    }
}
