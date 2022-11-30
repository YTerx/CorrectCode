using System;
using CorrectCodeClass;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace IsCorrectCode
{
    [TestClass]
    public class ClassCorrectTests
    {
        /// <summary>
        /// Тест на пустую строку
        /// </summary>
        [TestMethod]
        public void IsCorrectCode_EmptyString_ExpectedFalse()
        {
            // Arrange
            string candidate = "";
            // Act
            bool actual = ClassCorrect.IsCorrectCode(candidate);
            // Assert
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void IsCorrectCode_LengthString_ExpectedFalse()
        {
            // Arrange
            string candidate = "123";
            // Act
            bool actual = ClassCorrect.IsCorrectCode(candidate);
            // Assert
            Assert.IsFalse(actual);
        }
    }
}
