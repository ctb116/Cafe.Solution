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
            //Act
            Coffee coffeeOrder = new Coffee(coffeeQuantity);
            //Assert
            Assert.AreEqual(5, coffeeOrder.CoffeeCost());
        }
    }
}