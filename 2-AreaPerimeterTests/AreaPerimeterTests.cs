using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _2_AreaPerimeterTests
{
    [TestClass]
    public class AreaPerimeterTests
    {
        [TestMethod]
        public void ShouldCalculateArea()
        {
            var areaPerimeter = new AreaPerimeter();
            var result = areaPerimeter.CalculateArea(5);

            Assert.AreEqual(25, result);
        }

        [TestMethod]
        public void ShouldCalculatePerimeter()
        {
            var areaPerimeter = new AreaPerimeter();
            var result = areaPerimeter.CalculatePerimeter(5);

            Assert.AreEqual(20, result);
        }
    }
}