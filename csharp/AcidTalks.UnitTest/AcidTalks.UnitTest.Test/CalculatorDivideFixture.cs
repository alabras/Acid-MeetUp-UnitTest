using System;
using NUnit.Framework;

namespace AcidTalks.UnitTest.Test
{
    [TestFixture]
    public class CalculatorDivideFixture
    {
        [Test]
        public void divide_with_10_5_return_2()
        {
            //Arrangewith
            var calc = new Calculator();

            //Act
            var result = calc.Divide(10, 5);

            //Assert
            Assert.AreEqual(2, result);
        }

        [Test, ExpectedException(typeof(DivideByZeroException))]
        public void divide_with_zero_then_return_throw_exception()
        {
            //Arrange
            var calc = new Calculator();

            //Act
            calc.Divide(10, 0);
        }
    }
}