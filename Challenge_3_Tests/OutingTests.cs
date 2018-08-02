using System;
using System.Collections.Generic;
using Challenge_3;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Challenge_3_Tests
{
    [TestClass]
    public class OutingTests
    {
        [TestMethod]
        public void Outing_AddToList_ShouldAddToList()
        {
            //-- Arrange
            OutingRepository _outingsRepo = new OutingRepository();
            DateTime date1 = new DateTime(2018, 4, 25);
            Outings outing1 = new Outings("Golf", 4, date1, 100.00);
            _outingsRepo.AddOutingToList(outing1);

            //-- Act
            int expected = 1;
            int actual = _outingsRepo.GetCount();

            //-- Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Outing_GetList_ShouldGetList()
        {
            //-- Arrange
            OutingRepository _outingsRepo = new OutingRepository();
            DateTime date1 = new DateTime(2018, 4, 25);
            Outings outing1 = new Outings("Golf", 4, date1, 100.00);
            _outingsRepo.AddOutingToList(outing1);
            List<Outings> _testRepo = _outingsRepo.GetList();

            //-- Act
            int expected = 1;
            int actual = _testRepo.Count;

            //-- Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Outing_TotalEventCost_ShouldGetSum()
        {
            //-- Arrange
            OutingRepository _outingsRepo = new OutingRepository();
            DateTime date1 = new DateTime(2018, 4, 25);
            DateTime date2 = new DateTime(2018, 5, 25);
            DateTime date3 = new DateTime(2018, 6, 25);
            DateTime date4 = new DateTime(2018, 7, 25);
            Outings outing1 = new Outings("Golf", 4, date1, 100.00);
            Outings outing2 = new Outings("Bowling", 4, date2, 80.00);
            Outings outing3 = new Outings("Amusement Park", 4, date3, 200.00);
            Outings outing4 = new Outings("Concert", 4, date4, 400.00);
            _outingsRepo.AddOutingToList(outing1);
            _outingsRepo.AddOutingToList(outing2);
            _outingsRepo.AddOutingToList(outing3);
            _outingsRepo.AddOutingToList(outing4);

            //-- Act
            double expected = 780;
            double actual = _outingsRepo.CostPerEvent();

            //-- Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Outing_CostByEventType_ShouldGetTotalForEventType()
        {
            //-- Arrange
            OutingRepository _outingsRepo = new OutingRepository();
            DateTime date1 = new DateTime(2018, 4, 25);
            DateTime date2 = new DateTime(2018, 5, 25);
            DateTime date3 = new DateTime(2018, 6, 25);
            DateTime date4 = new DateTime(2018, 7, 25);
            Outings outing1 = new Outings("Golf", 4, date1, 100.00);
            Outings outing2 = new Outings("Golf", 4, date2, 80.00);
            Outings outing3 = new Outings("Amusement Park", 4, date3, 200.00);
            Outings outing4 = new Outings("Concert", 4, date4, 400.00);
            _outingsRepo.AddOutingToList(outing1);
            _outingsRepo.AddOutingToList(outing2);
            _outingsRepo.AddOutingToList(outing3);
            _outingsRepo.AddOutingToList(outing4);

            //-- Act
            double expected = 180;
            double actual = _outingsRepo.EventType("Golf");

            //-- Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
