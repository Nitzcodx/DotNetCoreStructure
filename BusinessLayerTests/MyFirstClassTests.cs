using Microsoft.VisualStudio.TestTools.UnitTesting;
using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Tests
{
    [TestClass()]
    public class MyFirstClassTests
    {
        [TestMethod()]
        public void MyFirstMethodTest()
        {
            MyFirstClass myTestObject = new MyFirstClass();

            int result = myTestObject.MyFirstMethod(23);
            Assert.AreEqual(result, 46);
            
            result = myTestObject.MyFirstMethod(50);
            Assert.AreEqual(result, 100);
        }
    }
}