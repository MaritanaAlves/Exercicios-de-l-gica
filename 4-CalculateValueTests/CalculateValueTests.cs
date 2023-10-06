using Microsoft.VisualStudio.TestTools.UnitTesting;
using _4_CalculateValue;

namespace _4_CalculateValueTests
{
    [TestClass]
    public class CalculateValueTests
    {
        [TestMethod]
        public void ShouldCalculateValueToPay()
        {
            CalculateValue calculateValue = new CalculateValue();
            Product product1 = new Product(2, 1, 5.3);
            Product product2 = new Product(16, 2, 5.1);
            double result = calculateValue.CalculateValueToPay(product1, product2);

            Assert.AreEqual(15.5, result);   
        }
    }
}