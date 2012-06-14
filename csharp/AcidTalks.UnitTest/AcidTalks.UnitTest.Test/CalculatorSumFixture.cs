using NUnit.Framework;

namespace AcidTalks.UnitTest.Test
{
    [TestFixture]
    public class CalculatorSumFixture
    {
         [Test]
        public void sum_with_5_and_5_return_10()
         {
             //Arrange
             var calc = new Calculator();
             
             //Act
             var result = calc.Sum(5, 5);
             
             //Assert
             Assert.AreEqual(10, result);
         }

        [Test]
        public void sum_with_negative_5_and_5_then_10_negative()
        {
            //Arrange
            var calc = new Calculator();

            //Act
            var result = calc.Sum(-5, -5);

            //Assert
            Assert.AreEqual(-10, result);
        }
    }
}