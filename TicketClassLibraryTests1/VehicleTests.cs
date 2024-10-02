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

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void LicenseplateTest()
        {
            // Arrange
            Vehicle car = new Car();

            // Act
            car.Licenseplate = "12345678"; // Dette er længere end 7 tegn

            // Assert er implicit, da [ExpectedException] venter en exception.
        }

        [TestMethod()]
        public void MedBrobizzCarTest()
        {
            // Arrange
            Car car = new Car()
            {
                HasBrobizz = true,
            };

            // Act
            double PriceMedBrobizz = car.Price();
            double expectedPrice = 240 * 0.95;
            double delta = 0.01;

            // Assert
            Assert.AreEqual(expectedPrice, PriceMedBrobizz, delta, "Car prisen burde give 5% rabat");
        }

        [TestMethod()]
        public void UdenBrobizzCarTest()
        {
            // Arrange
            Car car = new Car()
            {
                HasBrobizz = false,
            };

            // Act
            double PriceMedBrobizz = car.Price();
            double expectedPrice = 240;
            double delta = 0.01;

            // Assert
            Assert.AreEqual(expectedPrice, PriceMedBrobizz, delta, "Car prisen burde ikke give 5% rabat");
        }

        [TestMethod()]
        public void MedBrobizzMCTest()
        {
            // Arrange
            MC mc = new MC()
            {
                HasBrobizz = true,
            };

            // Act
            double PriceMedBrobizz = mc.Price();
            double expectedPrice = 125 * 0.95;
            double delta = 0.01;

            // Assert
            Assert.AreEqual(expectedPrice, PriceMedBrobizz, delta, "Mc prisen burde give 5% rabat");
        }

        [TestMethod()]
        public void UdenBrobizzMCTest()
        {
            // Arrange
            MC mc = new MC()
            {
                HasBrobizz = false,
            };

            // Act
            double PriceMedBrobizz = mc.Price();
            double expectedPrice = 125;
            double delta = 0.01;

            // Assert
            Assert.AreEqual(expectedPrice, PriceMedBrobizz, delta, "MC prisen er uden 5% rabat");
        }

    }
}