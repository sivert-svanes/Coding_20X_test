using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype_test.UnitTests.Controllers
{
    public class HomeControllerUnitTests
    {
        // Unit tests for HomeController will be implemented here.
        [Fact]
        public void SampleTest()
        {
            // Arrange
            int expected = 5;
            // Act
            int actual = 2 + 3;
            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
