using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _1_ArithmeticAverageTests
{
    [TestClass]
    public class ArithmeticAverageTests
    {
        [TestMethod]
        public void ShouldCalculateArithmeticAverage()
        {
            var arithmeticAverage = new ArithmeticAverage();
            
            var result = arithmeticAverage.CalculateArithmeticAverage(5, 10, 15);
            
            Assert.AreEqual(10, result);
        }
    }
}