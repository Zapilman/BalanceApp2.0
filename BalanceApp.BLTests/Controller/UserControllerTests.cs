using Microsoft.VisualStudio.TestTools.UnitTesting;
using BalanceApp.BL.Controller;
using System;
using System.Collections.Generic;
using System.Text;

namespace BalanceApp.BL.Controller.Tests
{
    [TestClass()]
    public class UserControllerTests
    {
        
        [TestMethod()]
        public void SaveTest()
        {
            //Arrange
            var userName = Guid.NewGuid().ToString();

            //Act
            var controller = new UserController(userName);

            //Assert
            Assert.AreEqual(userName, controller.CurrentUser.Name);
        }
    }
}