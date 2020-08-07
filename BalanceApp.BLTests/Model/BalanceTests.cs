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
            var category = new Category("Salary", "Incomes", null);

            //Act
            var balance = new Balance("choto", num,DateTime.Today,category);

            //Assert
            Assert.AreEqual(num, balance.Cost);
            
        }
    }
}