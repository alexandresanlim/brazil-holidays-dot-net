using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
    [TestClass]
    public class ToToday
    {
        [TestMethod]
        public void TodayIsHoliday()
        {
            var todayIsHoliday = BrazilHolidays.Net.Today.TodayIsHoliday();
        }
        [TestMethod]
        public void TodayIsNotHoliday()
        {
            var todayIsNotHoliday = BrazilHolidays.Net.Today.TodayIsNotHoliday();
        }
    }
}
