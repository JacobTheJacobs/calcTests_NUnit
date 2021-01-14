using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DevelopmentProjCalc.UnitTests
{
    [TestClass]
    public class MathUtilsTests
    {

        [TestMethod]
        public void IsEven_EvenNumber_ReturnsTrue()
        {
            // Arrange
            int numToCheck = 900;
            MathUtils myMathUtils = new MathUtils();

            // Act
            bool ActualResult = myMathUtils.IsEven(numToCheck);

            // Assert
            Assert.IsTrue(ActualResult, numToCheck + " is an even number");
        }

        [TestMethod]
        public void IsEven_OddNumber_ReturnsFalse()
        {
            // Arrange
            int numToCheck = 9;
            MathUtils myMathUtils = new MathUtils();

            // Act
            bool ActualResult = myMathUtils.IsEven(numToCheck);

            // Assert
            Assert.IsFalse(ActualResult, numToCheck + " is an odd number");
        }

        [TestMethod]
        public void IsOdd_EvenNumber_ReturnsFalse()
        {
            // Arrange
            int numToCheck = 8;
            MathUtils myMathUtils = new MathUtils();

            // Act
            bool ActualResult = myMathUtils.IsOdd(numToCheck);

            // Assert
            Assert.IsFalse(ActualResult, "Error when using " + numToCheck + " value");
        }

        [TestMethod]
        public void IsOdd_OddNumber_ReturnsTrue()
        {
            // Arrange
            int numToCheck = 9;
            MathUtils myMathUtils = new MathUtils();

            // Act
            bool ActualResult = myMathUtils.IsOdd(numToCheck);

            // Assert
            Assert.IsTrue(ActualResult, "Error when using " + numToCheck + " value");
        }



        [TestMethod]
        public void IsPrime_100_ReturnsFalse()
        {
            // Arrange
            int numToCheck = 100;
            MathUtils myMathUtils = new MathUtils();

            // Act
            bool ActualResult = myMathUtils.IsPrime(numToCheck);

            // Assert
            Assert.IsFalse(ActualResult, numToCheck + " is not a prime number");
        }

        [TestMethod]
        public void IsPrime_17_ReturnsTrue()
        {
            // Arrange
            int numToCheck = 17;
            MathUtils myMathUtils = new MathUtils();

            // Act
            bool ActualResult = myMathUtils.IsPrime(numToCheck);

            // Assert
            Assert.IsTrue(ActualResult, numToCheck + " is a prime number");
        }

        [TestMethod]
        public void IsPrime_NegativeNumber_ReturnsFalse()
        {
            // Arrange
            int numToCheck = -100;
            MathUtils myMathUtils = new MathUtils();

            // Act
            bool ActualResult = myMathUtils.IsPrime(numToCheck);

            // Assert
            Assert.IsFalse(ActualResult, numToCheck + " is a NOT prime number");
        }

        [TestMethod]
        public void IsPrime_1_ReturnsFalse()
        {
            // Arrange
            int numToCheck = 1;
            MathUtils myMathUtils = new MathUtils();

            // Act
            bool ActualResult = myMathUtils.IsPrime(numToCheck);

            // Assert
            Assert.IsFalse(ActualResult, numToCheck + " is a NOT prime number");
        }

    }
}
