using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _5_CircleAreaTests
{
    [TestClass]
    public class CircleAreaTests
    {
        [TestMethod]
        public void ShouldCalculateCircleArea()
        {
            var circleArea = new CircleArea();
            var result = circleArea.CalculateCircleArea(5, 3.14159);

            Assert.AreEqual(78.53975, result);
        }
    }
}