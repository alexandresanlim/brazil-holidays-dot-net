using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using BrazilHolidays.Net.Extention;

namespace UnitTest
{
    [TestClass]
    public class ToCurrentYearTest
    {
        public int Year => DateTime.Now.Year;

        [TestMethod]
        public void AnoNovo()
        {
            Assert.IsTrue(new DateTime(Year, 1, 1).IsHoliday());
        }

        [TestMethod]
        public void Tiradentes()
        {
            Assert.IsTrue(new DateTime(Year, 4, 21).IsHoliday());
        }

        [TestMethod]
        public void DiaDoTrabalho()
        {
            Assert.IsTrue(new DateTime(Year, 5, 1).IsHoliday());
        }

        [TestMethod]
        public void Independencia()
        {
            Assert.IsTrue(new DateTime(Year, 9, 7).IsHoliday());
        }

        [TestMethod]
        public void NossaSenhoraAparecida()
        {
            Assert.IsTrue(new DateTime(Year, 10, 12).IsHoliday());
        }

        [TestMethod]
        public void Finados()
        {
            Assert.IsTrue(new DateTime(Year, 11, 2).IsHoliday());
        }

        [TestMethod]
        public void ProclamacaoDaRepublica()
        {
            Assert.IsTrue(new DateTime(Year, 11, 15).IsHoliday());
        }

        [TestMethod]
        public void Natal()
        {
            Assert.IsTrue(new DateTime(Year, 12, 25).IsHoliday());
        }
    }
}
