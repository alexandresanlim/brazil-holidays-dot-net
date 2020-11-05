using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTest
{
    [TestClass]
    public class OutherTests
    {
        [TestMethod]
        public void TodayIsHoliday()
        {
            var isHoliday = BrazilHolidays.Net.Today.IsHoliday();
        }

        [TestMethod]
        public void TodayIsNotHoliday()
        {
            var isNotHoliday = BrazilHolidays.Net.Today.IsNotHoliday();
        }

        [TestMethod]
        public void GetAllNext()
        {
            var a = BrazilHolidays.Net.Holiday.GetAllNext();
        }

        [TestMethod]
        public void GetOld()
        {
            var old = BrazilHolidays.Net.Holiday.GetOld();
        }

        [TestMethod]
        public void GetNext()
        {
            var old = BrazilHolidays.Net.Holiday.GetNext();
        }

        [TestMethod]
        public void GetAllByMonth()
        {
            var m = BrazilHolidays.Net.Holiday.GetAllByMonth(BrazilHolidays.Net.Holiday.Months.Dec);
        }
    }
}
