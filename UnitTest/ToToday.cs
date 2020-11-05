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

        [TestMethod]
        public void GetAllNext()
        {
            var a = BrazilHolidays.Net.DataStore.Holiday.GetAllNext();
        }

        [TestMethod]
        public void GetOld()
        {
            var old = BrazilHolidays.Net.DataStore.Holiday.GetOld();
        }

        [TestMethod]
        public void GetAllNextByMonth()
        {
            var m = BrazilHolidays.Net.DataStore.Holiday.GetAllNextByMonth(2);
        }
    }
}
