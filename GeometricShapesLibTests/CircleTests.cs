using Xunit;
using GeometricShapesLib;
using System;

namespace GeometricShapesLibTests
{
    public class CircleTests
    {
        [Theory]
        [InlineData(0.0)]
        [InlineData(0.001)]
        [InlineData(1.0)]
        [InlineData(100.67)]        
        [InlineData(999.999E+100)]        
        public void Circle1_CreateWithNormalData(double value)
        {
            //Arrange
            var circle1 = new Circle(value);

            //Act
            var area1 = circle1.Area;

            //Assert
            Assert.Equal(area1, Math.PI * value * value);
        }

        [Theory]        
        [InlineData(-0.001)]
        [InlineData(-1.0)]
        [InlineData(-999)]        
        public void Circle2_CreateWithNegativeData(double value)
        {
            //Arrange
            //Act
            //Assert
            Assert.Throws<ArgumentException>(() => { var circle2 = (new Circle(value).Area);});
        }

        [Fact]
        public void Circle3_OutOfRangeData()
        {
            //Arrange
            //Act
            //Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => { var circle3 = (new Circle(double.MaxValue).Area);});
        }
    }
}