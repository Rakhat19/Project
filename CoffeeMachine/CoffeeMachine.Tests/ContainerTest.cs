using System;
using Xunit;

namespace CoffeeMachine.Tests
{
    public class ContainerTest
    {
        [Fact]
        public void ContainerCapacitySet_Success()
        {
            //Arrange
            const int expectedCapacity = 1000;
            var container = new Container(expectedCapacity);
            //Act
            var actualCapacity = container.Capacity;
            //Assert
            Assert.Equal(expectedCapacity, actualCapacity);
        }
    }
}