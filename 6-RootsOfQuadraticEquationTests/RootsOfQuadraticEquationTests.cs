using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Win32.SafeHandles;

namespace _6_RootsOfQuadraticEquationTests
{
    [TestClass]
    public class RootsOfQuadraticEquationTests
    {
        [TestMethod]
        public void ShouldCalculateDelta()
        {
            var deltaOfQuadraticEquation = new RootsOfQuadraticEquation();
            var valueDelta = deltaOfQuadraticEquation.CalculateDelta(2, 3, -5);

            Assert.AreEqual(49, valueDelta);
        }

        public void ShouldCalculateRootsOfQuadraticEquation()
        {
            var rootsOfQuadraticEquation = new RootsOfQuadraticEquation();
            var result = rootsOfQuadraticEquation.CalculateRootsOfQuadraticEquation();

            Assert.AreEqual( , result );
        }
    }
}