using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _3_DoubleTripleSquareCubeSqrtTests
{
    [TestClass]
    public class DoubleTripleSquareCubeSqrtTests
    {
        [TestMethod]
        public void ShouldCalculateDouble()
        {
            var doubleTripleSquareCubeSqrt = new DoubleTripleSquareCubeSqrt();
            var result = doubleTripleSquareCubeSqrt.CalculateDouble(4);
            Assert.AreEqual(8, result);
        }

        [TestMethod]
        public void ShouldCalculateTriple()
        {
            var doubleTripleSquareCubeSqrt = new DoubleTripleSquareCubeSqrt();
            var result = doubleTripleSquareCubeSqrt.CalculateTriple(4);
            Assert.AreEqual(12, result);
        }

        [TestMethod]
        public void ShouldCalculateSquare()
        {
            var doubleTripleSquareCubeSqrt = new DoubleTripleSquareCubeSqrt();
            var result = doubleTripleSquareCubeSqrt.CalculateSquare(4);
            Assert.AreEqual(16, result);

        }

        [TestMethod]
        public void ShouldCalculateCube()
        {
            var doubleTripleSquareCubeSqrt = new DoubleTripleSquareCubeSqrt();
            var result = doubleTripleSquareCubeSqrt.CalculateCube(4);
            Assert.AreEqual(64, result);
        }

        [TestMethod]
        public void ShouldCalculateSqrt()
        {
            var doubleTripleSquareCubeSqrt = new DoubleTripleSquareCubeSqrt();
            var result = doubleTripleSquareCubeSqrt.CalculateSqrt(4);
            Assert.AreEqual(2, result);
        }


    }
}