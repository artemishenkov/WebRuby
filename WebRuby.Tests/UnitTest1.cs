using System;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebRuby.Controllers;

namespace WebRuby.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
        }
        [TestMethod]
        public void IndexViewResultNotNull()
        {
            ManageController controller = new ManageController();

            var result = controller.TaskBoard();

            //Assert.IsNotNull(result);
        }
    }
}
