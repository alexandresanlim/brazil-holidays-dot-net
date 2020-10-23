using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using BrazilHolidays.Net.Extention;

namespace UnitTest
{
    [TestClass]
    public class ToNotLeapYearMoving
    {
        public int LeapYear => 2021;

        [TestMethod]
        public void Pascoa()
        {
            Assert.IsTrue(new DateTime(LeapYear, 4, 4).IsHoliday());
        }

        [TestMethod]
        public void SextaFeiraSanta()
        {
            Assert.IsTrue(new DateTime(LeapYear, 4, 2).IsHoliday());
        }

        [TestMethod]
        public void Carnaval()
        {
            Assert.IsTrue(new DateTime(LeapYear, 2, 16).IsHoliday());
        }

        [TestMethod]
        public void CorpusChristi()
        {
            Assert.IsTrue(new DateTime(LeapYear, 6, 3).IsHoliday());
        }
    }
}
