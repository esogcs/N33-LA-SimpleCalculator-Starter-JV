﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimpleCalculator.Test.Unit
{
    [TestClass]
    public class InputConverterTest
    {
        [TestMethod]
        public void ConvertsValidStringInputIntoDouble()
        {
            string inputNumber = "5";
            double convertedNumber = InputConverter.ConvertInputToNumeric(inputNumber);
            Assert.AreEqual(5, convertedNumber);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void FailsToConvertsInvalidStringInputIntoDouble()
        {
            string inputNumber = "*";
            double convertedNumber = InputConverter.ConvertInputToNumeric(inputNumber);
            Assert.AreEqual(2, convertedNumber);
        }
    }
}
