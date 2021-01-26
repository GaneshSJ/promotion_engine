using NUnit.Framework;
using PromotionEngine.Models;

namespace PromotionEngine.Test
{
    public class Tests
    {
        private PromotionEngine _promotionEngine;

        [SetUp]
        public void Setup() => _promotionEngine = new PromotionEngine();

        [Test]
        public void TestOrder1()
        {
            // Arrange
            var order = new Order();
            order.Add(_promotionEngine.UnitA);
            order.Add(_promotionEngine.UnitB);
            order.Add(_promotionEngine.UnitC);

            // Act
            var value = _promotionEngine.CalculateValue(order);

            // Assert
            Assert.AreEqual(100, value);
        }

        [Test]
        public void TestOrder2()
        {
            // Arrange
            var order = new Order();
            order.Add(_promotionEngine.UnitA, 5);
            order.Add(_promotionEngine.UnitB, 5);
            order.Add(_promotionEngine.UnitC);

            // Act
            var value = _promotionEngine.CalculateValue(order);

            // Assert
            Assert.AreEqual(370, value);
        }

        [Test]
        public void TestOrder3()
        {
            // Arrange
            var order = new Order();
            order.Add(_promotionEngine.UnitA, 3);
            order.Add(_promotionEngine.UnitB, 5);
            order.Add(_promotionEngine.UnitC);
            order.Add(_promotionEngine.UnitD);

            // Act
            var value = _promotionEngine.CalculateValue(order);

            // Assert
            Assert.AreEqual(280, value);
        }
    }
}