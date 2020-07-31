using Microsoft.VisualStudio.TestTools.UnitTesting;
using BalanceApp.BL.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BalanceApp.BL.Model.Tests
{
    [TestClass()]
    public class BalanceTests
    {
        [TestMethod()]
        public void BalanceTest()
        {
            //Arrange
            double num = 100.3;

            //Act
            var balance = new Balance("choto", num);

            //Assert
            Assert.AreEqual(num, balance.Cost);
            
        }
    }
}