using BrazilHolidays.Net;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTest
{
    [TestClass]
    public class CustomHolidayTests
    {
        [TestMethod]
        public void AddCustom()
        {
            var custom = new Holiday(DateTime.Today, "Teste");
            Holiday.AddCustomHoliday(custom);

            var list = Holiday.GetAllByYear();

            Assert.IsTrue(Today.IsHoliday());
        }
    }
}
