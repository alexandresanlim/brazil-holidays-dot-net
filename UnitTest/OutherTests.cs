using BrazilHolidays.Net;
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
            var isHoliday = Today.IsHoliday();
            Assert.IsNotNull(isHoliday);
        }

        [TestMethod]
        public void TodayIsNotHoliday()
        {
            var isNotHoliday = Today.IsNotHoliday();
            Assert.IsNotNull(isNotHoliday);
        }

        [TestMethod]
        public void GetAllNext()
        {
            var list = Holiday.GetAllNext();
            Assert.IsNotNull(list);
        }

        [TestMethod]
        public void GetOld()
        {
            var list = Holiday.GetOld();
            Assert.IsNotNull(list);
        }

        [TestMethod]
        public void GetNext()
        {
            var list = Holiday.GetNext();
            Assert.IsNotNull(list);
        }

        [TestMethod]
        public void GetAllByMonth()
        {
            var list = Holiday.GetAllByMonth(Months.Dec);
            Assert.IsNotNull(list);
        }
    }
}
