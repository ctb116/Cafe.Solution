using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using Cafe.Models;

namespace Cafe.Tests
{
    [TestClass]
    public class CoffeeTests
    {
        [TestMethod]
        public void  CoffeeCost_CostOneCupNoDiscount_Int()
        {
            //Arrange
            int coffeeQuantity = 1;
            double coffeeCost = 5;
            //Act
            Coffee coffeeOrder = new Coffee(coffeeQuantity);
            //Assert
            Assert.AreEqual(coffeeCost, coffeeOrder.CoffeeCost());
        }
        [TestMethod]
        public void CoffeeCost_CostTwoCupNoDiscount_Int()
        {
            int coffeeQuantity = 2;
            double coffeeCost = 10;
            Coffee coffeeOrder = new Coffee(coffeeQuantity);
            Assert.AreEqual(coffeeCost, coffeeOrder.CoffeeCost());
        }
        [TestMethod]
        public void CoffeeCost_ThirdCupIsDiscounted_Int()
        {
            int coffeeQuantity = 3;
            double coffeeCost = 12.50;
            Coffee coffeeOrder = new Coffee(coffeeQuantity);
            Assert.AreEqual(coffeeCost, coffeeOrder.CoffeeCost());
        }
        [TestMethod]
        public void CoffeeCost_ThirdCupsAreDiscountedSixCupsOrdered_Int()
        {
            int coffeeQuantity = 6;
            double coffeeCost = 25;
            Coffee coffeeOrder = new Coffee(coffeeQuantity);
            Assert.AreEqual(coffeeCost, coffeeOrder.CoffeeCost());
        }
    }
}