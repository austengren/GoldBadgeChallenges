using System;
using System.Collections.Generic;
using Challenge_2;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Challenge_2_Tests
{
    [TestClass]
    public class ClaimTests
    {
        [TestMethod]
        public void Claim_AddToQueue_ShouldAddToQueue()
        {
            //-- Arrange
            ClaimRepository _claim = new ClaimRepository();
            DateTime date1 = new DateTime(2018, 4, 25);
            DateTime date2 = new DateTime(2018, 4, 27);
            Claim claim1 = new Claim(1, "Car", "Car accident on 465.", 400.00m, date1, date2);
            _claim.AddClaimToQueue(claim1);

            //-- Act
            int expected = 1;
            int actual = _claim.GetCount();

            //-- Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Claim_RemoveClaim_ShouldRemoveClaim()
        {
            //-- Arrange
            ClaimRepository _claim = new ClaimRepository();
            DateTime date1 = new DateTime(2018, 4, 25);
            DateTime date2 = new DateTime(2018, 4, 27);
            Claim claim1 = new Claim(1, "Car", "Car accident on 465.", 400.00m, date1, date2);
            _claim.AddClaimToQueue(claim1);
            _claim.RemoveClaim();

            //-- Act
            int expected = 0;
            int actual = _claim.GetCount();

            //-- Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Claim_GetList_ShouldGetList()
        {
            //-- Arrange
            ClaimRepository _claim = new ClaimRepository();
            DateTime date1 = new DateTime(2018, 4, 25);
            DateTime date2 = new DateTime(2018, 4, 27);
            Claim claim1 = new Claim(1, "Car", "Car accident on 465.", 400.00m, date1, date2);
            _claim.AddClaimToQueue(claim1);
            Queue<Claim> _testRepo = _claim.GetList();

            //-- Act
            int expected = 1;
            int actual = _testRepo.Count;

            //-- Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
