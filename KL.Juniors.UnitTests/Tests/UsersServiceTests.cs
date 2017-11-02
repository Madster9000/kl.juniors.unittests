using KL.Juniors.UnitTests.Workflows;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace KL.Juniors.UnitTests.Tests
{
    public class UsersServiceTests
    {
        [Fact]
        public void GetUser_IdIsCorrect_ReturnedUserNameIsCorrect()
        {
            // Arrange
            var testUser = new User
            {
                Id = Guid.NewGuid(),
                Name = "Denis"
            };
            var usersCollection = new List<User> { testUser };
            var storage = new Mock<IUsersStorage>();
            storage
                    .Setup(x => x.Users)
                    .Returns(usersCollection);

            var sut = new UsersService(storage.Object);
           

            // Act
            var executionResult = sut.GetUser(testUser.Id);

            // Assert
            Assert.Equal(executionResult, testUser.Name);
        }
    }
}
