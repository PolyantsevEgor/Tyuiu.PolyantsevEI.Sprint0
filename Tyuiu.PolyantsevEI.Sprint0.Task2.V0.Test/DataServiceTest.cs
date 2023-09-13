﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.PolyantsevEI.Sprint0.Task2.V0.Lib;
namespace Tyuiu.PolyantsevEI.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Егор";
            var res = DataService.GetMessage(name);

            Assert.AreEqual("Привет..., Егор", res);
        }
    }
}
