using Calculations;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace CalculatorTests
{
    public class GeometryTests
    {
        [Fact]
        public void AreaOfASquare_ShouldReturnArea()
        {
            //Arrange
            double expected = 25;

            //Act
            double actual = Geometry.AreaOfASquare(5);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void AreaOfARectangle_ShouldReturnArea()
        {
            //Arrange
            double expected = 1121.0664;

            //Act
            double actual = Geometry.AreaOfARectangle(75.3, 14.888);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void AreaOfATriangle_ShouldReturnArea()
        {
            //Arrange
            double expected = 242.36;

            //Act
            double actual = Geometry.AreaOfTriangle(14.6, 33.2);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
