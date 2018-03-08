using System;
using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    // Naming: Method_Scenario_ReturnValue
    // IS USING MSTESTS
    [TestFixture]
    public class ReservationTests
    {
        [Test]
        public void CanBeCancelledBy_AdminCancelling_ReturnsTrue()
        {
            // Arrange
            var user = new User { IsAdmin = true };
            var reservation = new Reservation();

            // Act
            var result = reservation.CanBeCancelledBy(user);

            // Assert
            Assert.That(result, Is.True);
        }

        [Test]
        public void CanBeCancelledBy_SameUserCancelling_ReturnsTrue()
        {
            // Arrange
            var user = new User();
            var reservation = new Reservation { MadeBy = user };

            // Act
            var result = reservation.CanBeCancelledBy(user);

            // Assert
            Assert.IsTrue(result);
        }

        [Test]
        public void CanBeCancelledBy_AnotherUserCancelling_ReturnsFalse()
        {
            // Arrange
            var user = new User();
            var reservation = new Reservation();

            // Act
            var result = reservation.CanBeCancelledBy(user);

            // Assert
            Assert.IsFalse(result);
        }
    }
}
