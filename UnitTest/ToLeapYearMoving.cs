using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using BrazilHolidays.Net.DataStore;

namespace UnitTest
{
    [TestClass]
    public class ToLeapYearMoving
    {
        public int LeapYear => 2020;

        [TestMethod]
        public void Pascoa()
        {
            Assert.IsTrue(new DateTime(LeapYear, 4, 12).IsHoliday());
        }

        [TestMethod]
        public void SextaFeiraSanta()
        {
            Assert.IsTrue(new DateTime(LeapYear, 4, 10).IsHoliday());
        }

        [TestMethod]
        public void Carnaval()
        {
            Assert.IsTrue(new DateTime(LeapYear, 2, 25).IsHoliday());
        }

        [TestMethod]
        public void CorpusChristi()
        {
            Assert.IsTrue(new DateTime(LeapYear, 6, 11).IsHoliday());
        }
    }
}
