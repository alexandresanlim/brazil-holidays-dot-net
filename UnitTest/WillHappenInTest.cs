using BrazilHolidays.Net;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTest
{
    [TestClass]
    public class WillHappenInTest
    {
        [TestMethod]
        public void WillHappenNatal()
        {
            var natal = Holiday.GetOneByYear(HolidayIdentity.Natal, DateTime.Now.Year);
            var daysToNatal = natal.HappenInDays();
        }

        [TestMethod]
        public void WillHappenDiaDoTrabalho()
        {
            var diaDoTrabalho = Holiday.GetOneByYear(HolidayIdentity.DiaDoTrabalho, DateTime.Now.Year);
            var daysToDiaDoTrabalho = diaDoTrabalho.HappenInDays();
        }
    }
}
