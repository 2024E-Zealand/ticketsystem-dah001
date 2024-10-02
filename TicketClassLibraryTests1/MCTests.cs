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
    public class MCTests
    {
        [TestMethod()]
        public void PriceTest()
        {
            // Arrange
            MC mc = new MC();

            // Act
            double result = mc.Price();

            // Assert
            Assert.AreEqual(125, result, "Prisen skal return 125.");
        }

        [TestMethod()]
        public void VehicleTypeTest()
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