using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebRuby.Controllers;
using System.Web.Mvc;

namespace WebRuby.Tests.Controllers
{

    [TestClass]
    public class ManageControllerTest
    {
        [TestMethod]
        public void IndexViewResultNotNull()
        {
            ManageController controller = new ManageController();

            ViewResult result = controller.TaskBoard() as ViewResult;

            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void IndexViewEqualIndexCshtml()
        {
            ManageController controller = new ManageController();

            ViewResult result = controller.TaskBoard() as ViewResult;

            Assert.AreEqual("TaskBoard", result.ViewName);
        }

        //[TestMethod]
        //public void IndexStringInViewbag()
        //{
        //    StoreController controller = new StoreController();

        //    ViewResult result = controller.Index() as ViewResult;

        //    Assert.AreEqual("Hello world!", result.ViewBag.Message);
        //}
    }
}
