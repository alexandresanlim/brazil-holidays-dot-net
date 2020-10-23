using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTest
{
    [TestClass]
    public class ToToday
    {
        [TestMethod]
        public void TodayIsHoliday()
        {
            var isHoliday = BrazilHolidays.Net.Today.IsHoliday();
        }
        [TestMethod]
        public void TodayIsNotHoliday()
        {
            var isHoliday = BrazilHolidays.Net.Today.IsNotHoliday();
        }
    }
}
