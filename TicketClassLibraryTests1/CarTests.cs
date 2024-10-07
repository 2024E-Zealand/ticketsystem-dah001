using Microsoft.VisualStudio.TestTools.UnitTesting;
using TicketClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketClassLibrary.Tests
{
    [TestClass()]
    public class CarTests
    {
        [TestMethod()]
        public void PriceTest()
        {
            // Arrange
            Car car = new Car();

            // Act
            double result = car.Price();

            // Assert
            Assert.AreEqual(240, result, "Prisen skal return 240.");
        }

        [TestMethod()]
        public void VehicleTypeTest()
        {
            // Arrange
            Car car = new Car();

            // Act
            string result = car.VehicleType();

            // Assert
            Assert.AreEqual("Car", result, "VehicleType skal return strengen 'Car'.");
        }
        
        [TestMethod]
        public void WeekendDiscountOmWeekenden()
        {
            var car = new Car()
            {
                Date = new DateTime(2025, 03, 23),
                HasBrobizz = false
            };
            var discountedPrice = car.WeekendDiscount();
            Assert.AreEqual(192.0, discountedPrice, 0.01);
        }

        [TestMethod()]
        public void WeekendenTestMedBrobizz() 
        {
            var car = new Car()
            {
                Date = new DateTime(2025, 03, 23),
                HasBrobizz = true
            };
            var discountedPrice = car.WeekendDiscount();
            Assert.AreEqual(182.4, discountedPrice, 0.01);

        }

    }
}