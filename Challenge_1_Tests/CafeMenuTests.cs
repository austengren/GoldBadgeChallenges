using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Challenge_1;
using System.Collections.Generic;

namespace Challenge_1_Tests
{
    [TestClass]
    public class CafeMenuTests
    {
        [TestMethod]
        public void Menu_AddToMenu_ShouldAddToMenu()
        {
            //-- Arrange
            MenuRepository _cafeMenu = new MenuRepository();
            CafeMenu cafeMenu1 = new CafeMenu("Chicken Tenders", 1, "Crispy delicious chicken tenders.", "Chicken, Breading, Fries, BBQ Sauce", 9.95m);
            _cafeMenu.AddItemToMenu(cafeMenu1);

            //-- Act
            int expected = 1;
            int actual = _cafeMenu.GetCount();

            //-- Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Menu_RemoveFromMenu_ShouldRemoveFromMenu()
        {
            //-- Arrange
            MenuRepository _cafeMenu = new MenuRepository();
            CafeMenu cafeMenu1 = new CafeMenu("Chicken Tenders", 1, "Crispy delicious chicken tenders.", "Chicken, Breading, Fries, BBQ Sauce", 9.95m);
            _cafeMenu.AddItemToMenu(cafeMenu1);
            _cafeMenu.RemoveItemFromMenu(cafeMenu1);

            //-- Act
            int expected = 0;
            int actual = _cafeMenu.GetCount();

            //-- Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Menu_GetList_ShouldGetList()
        {
            //-- Arrange
            MenuRepository _cafeMenu = new MenuRepository();
            CafeMenu cafeMenu1 = new CafeMenu("Chicken Tenders", 1, "Crispy delicious chicken tenders.", "Chicken, Breading, Fries, BBQ Sauce", 9.95m);
            _cafeMenu.AddItemToMenu(cafeMenu1);
            List<CafeMenu> _testRepo = _cafeMenu.GetList();

            //-- Act
            int expected = 1;
            int actual = _testRepo.Count;

            //-- Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Menu_MenuName_ShouldBeSetToString()
        {
            //-- Arrange
            CafeMenu cafeMenu = new CafeMenu("Chicken Tenders", 1, "Crispy delicious chicken tenders.", "Chicken, Breading, Fries, BBQ Sauce", 9.95m);

            //-- Act
            string actual = cafeMenu.Name;
            string expected = "Chicken Tenders";

            //-- Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Menu_MenuNumber_ShouldBeSetToInt()
        {
            //-- Arrange
            CafeMenu cafeMenu = new CafeMenu("Chicken Tenders", 1, "Crispy delicious chicken tenders.", "Chicken, Breading, Fries, BBQ Sauce", 9.95m);

            //-- Act
            int actual = cafeMenu.Number;
            int expected = 1;

            //-- Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Menu_MenuDescription_ShouldBeSetToString()
        {
            //-- Arrange
            CafeMenu cafeMenu = new CafeMenu("Chicken Tenders", 1, "Crispy delicious chicken tenders.", "Chicken, Breading, Fries, BBQ Sauce", 9.95m);

            //-- Act
            string actual = cafeMenu.Description;
            string expected = "Crispy delicious chicken tenders.";

            //-- Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Menu_MenuIngredients_ShouldBeSetToString()
        {
            //-- Arrange
            CafeMenu cafeMenu = new CafeMenu("Chicken Tenders", 1, "Crispy delicious chicken tenders.", "Chicken, Breading, Fries, BBQ Sauce", 9.95m);

            //-- Act
            string actual = cafeMenu.Ingredients;
            string expected = "Chicken, Breading, Fries, BBQ Sauce";

            //-- Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Menu_MenuPrice_ShouldBeSetToDecimal()
        {
            //-- Arrange
            CafeMenu cafeMenu = new CafeMenu("Chicken Tenders", 1, "Crispy delicious chicken tenders.", "Chicken, Breading, Fries, BBQ Sauce", 9.95m);

            //-- Act
            decimal actual = cafeMenu.Price;
            decimal expected = 9.95m;

            //-- Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
