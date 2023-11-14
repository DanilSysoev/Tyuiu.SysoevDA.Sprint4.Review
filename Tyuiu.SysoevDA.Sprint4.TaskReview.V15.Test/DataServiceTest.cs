using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.SysoevDA.Sprint4.TaskReview.V15.Lib;

namespace Tyuiu.SysoevDA.Sprint4.TaskReview.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            Assert.AreEqual(4, ds.Calculate(4, 2, "10293847"));
        }
    }
}
