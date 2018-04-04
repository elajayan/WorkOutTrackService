using Microsoft.VisualStudio.TestTools.UnitTesting;
using WorkOutTrackService.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkOutDBLayer;
using WorkOutDBLayer.Model;
namespace WorkOutTrackService.Controllers.Tests
{
    [TestClass()]
    public class CategoryControllerTests
    {
        [TestMethod()]
        public void GetTest()
        {
            CateogryDb obj = new CateogryDb();
            int actualCount = obj.GetAll().Count;
            int expectedCount = 4;
            Assert.AreEqual(expectedCount, actualCount);
        }

        [TestMethod()]
        public void GetByIdTest()
        {
            CateogryDb obj = new CateogryDb();
            string actualCategoryName = obj.GetById(2).CategoryName;
            string expectedCategoryName = "Walking";
            Assert.AreEqual(expectedCategoryName, actualCategoryName);
        }
    }
}