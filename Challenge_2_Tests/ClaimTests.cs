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
            ClaimRepository _claimRepo = new ClaimRepository();
            DateTime date1 = new DateTime(2018, 4, 25);
            DateTime date2 = new DateTime(2018, 4, 27);
            Claim claim1 = new Claim(1, "Car", "Car accident on 465.", 400.00m, date1, date2);
            _claimRepo.AddClaimToQueue(claim1);

            //-- Act
            int expected = 1;
            int actual = _claimRepo.GetCount();

            //-- Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Claim_RemoveClaim_ShouldRemoveClaim()
        {
            //-- Arrange
            ClaimRepository _claimRepo = new ClaimRepository();
            DateTime date1 = new DateTime(2018, 4, 25);
            DateTime date2 = new DateTime(2018, 4, 27);
            Claim claim1 = new Claim(1, "Car", "Car accident on 465.", 400.00m, date1, date2);
            _claimRepo.AddClaimToQueue(claim1);
            _claimRepo.RemoveClaim();

            //-- Act
            int expected = 0;
            int actual = _claimRepo.GetCount();

            //-- Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Claim_GetList_ShouldGetList()
        {
            //-- Arrange
            ClaimRepository _claimRepo = new ClaimRepository();
            DateTime date1 = new DateTime(2018, 4, 25);
            DateTime date2 = new DateTime(2018, 4, 27);
            Claim claim1 = new Claim(1, "Car", "Car accident on 465.", 400.00m, date1, date2);
            _claimRepo.AddClaimToQueue(claim1);
            Queue<Claim> _testRepo = _claimRepo.GetList();

            //-- Act
            int expected = 1;
            int actual = _testRepo.Count;

            //-- Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
