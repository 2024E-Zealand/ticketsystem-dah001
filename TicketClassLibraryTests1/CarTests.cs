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
    }
}