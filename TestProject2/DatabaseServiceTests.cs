using Injection_Test2;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject2
{
    public class DatabaseServiceTests
    {
        [Fact]
        public void ValidateUser_ReturnsTrue_WhenUserIsValid()
        {
            // Arrange
            var mockDatabaseService = new Mock<IDatabaseService>();
            mockDatabaseService.Setup(db => db.ValidateUser("validUser", "validPass")).Returns(true);

            // Act
            bool result = mockDatabaseService.Object.ValidateUser("validUser", "validPass");

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void ValidateUser_ReturnsFalse_WhenUserIsInvalid()
        {
            // Arrange
            var mockDatabaseService = new Mock<IDatabaseService>();
            mockDatabaseService.Setup(db => db.ValidateUser("invalidUser", "invalidPass")).Returns(false);

            // Act
            bool result = mockDatabaseService.Object.ValidateUser("invalidUser", "invalidPass");

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void ValidateUser_WithEmptyCredentials_ReturnsFalse()
        {
            // Arrange
            var mockDatabaseService = new Mock<IDatabaseService>();
            mockDatabaseService.Setup(ds => ds.ValidateUser("", "")).Returns(false);

            var form = new Form1(mockDatabaseService.Object);

            // Act
            bool isValid = mockDatabaseService.Object.ValidateUser("", "");

            // Assert
            Assert.False(isValid);
        }
    }
}
