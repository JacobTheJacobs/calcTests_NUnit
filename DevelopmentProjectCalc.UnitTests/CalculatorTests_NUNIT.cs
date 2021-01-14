using System;
using NUnit.Framework;

namespace DevelopmentProjCalc.UnitTests
{
    [TestFixture]
    public class CalculatorTests_NUNIT
    {
        [Test]
        public void Add_12Add3_Returns15()
        {

            //Arrange
            double x = 12;
            double y = 3;
            double ExpectedResult = 15;
            Calculator calculatorForTheTest = new Calculator();

            //Act
            double ActualResult = calculatorForTheTest.Add(x, y);

            //Assert   
            Assert.AreEqual(ExpectedResult, ActualResult, "Add calculation returns the wrong result");

        }

        [Test]
        public void Sub_12Sub3_Returns9()
        {

            //Arrange
            double x = 12;
            double y = 3;
            double ExpectedResult = 9; // x - y
            Calculator calculatorForTheTest = new Calculator();

            //Act
            double ActualResult = calculatorForTheTest.Sub(x, y);

            //Assert   
            Assert.AreEqual(ExpectedResult, ActualResult, "Sub calculation returns the wrong result");

        }

        [Test]
        public void Mul_12Mul3_Returns36()
        {

            //Arrange
            double x = 12;
            double y = 3;
            double ExpectedResult = 36; // x * y
            Calculator calculatorForTheTest = new Calculator();

            //Act
            double ActualResult = calculatorForTheTest.Mul(x, y);

            //Assert   
            Assert.AreEqual(ExpectedResult, ActualResult, "Mul calculation returns the wrong result");

        }

        [Test]
        public void Div_12Div3_Returns4()
        {

            //Arrange
            double x = 12;
            double y = 3;
            double ExpectedResult = 4; // x / y
            Calculator calculatorForTheTest = new Calculator();

            //Act
            double ActualResult = calculatorForTheTest.Div(x, y);

            //Assert   
            Assert.AreEqual(ExpectedResult, ActualResult, "Div calculation returns the wrong result");

        }

    }
}
