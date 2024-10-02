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
    public class VehicleTests
    {
        [TestMethod()]
        public void PriceCarTest()
        {
            // Arrange
            Car car = new Car();
           
            // Act
            double result = car.Price();
            

            // Assert
            Assert.AreEqual(240, result, "Prisen skal return 240.");
           
        }

        [TestMethod()]
        public void PriceMCTest()
        {
            // Arrange
            MC mc = new MC();

            // Act
            double result = mc.Price();

            // Assert
            Assert.AreEqual(125, result, "Prisen skal return 125.");
        }

        [TestMethod()]
        public void VehicleTypeCarTest()
        {
            // Arrange
            Car car = new Car();

            // Act
            string result = car.VehicleType();

            // Assert
            Assert.AreEqual("Car", result, "VehicleType skal return strengen 'Car'.");
        }

        [TestMethod()]
        public void VehicleTypeMCTest()
        {
            // Arrange
            MC mc = new MC();

            // Act
            string result = mc.VehicleType();

            // Assert
            Assert.AreEqual("MC", result, "Vehicle skal return strengen 'MC'.");
        }
    }
}