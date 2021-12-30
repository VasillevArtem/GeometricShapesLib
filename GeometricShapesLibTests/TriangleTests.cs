using System;
using Xunit;
using GeometricShapesLib;

namespace GeometricShapesLibTests
{
    public class TriangleTests
    {
        [Theory]       
        [InlineData(0.001, 0.001, 0.001)]
        [InlineData(1.0, 1.0, 1.0)]
        [InlineData(4.0, 5.0, 6.0)]
        [InlineData(44.0, 76.0, 44.0)]
        [InlineData(99.99, 99.99, 99.99)]        
        public void Triangle_WithNormalData(double side_A, double side_B, double side_C)
        {
            //Arrange
            var triangle1 = new Triangle(side_A, side_B, side_C);

            //Act
            var area1 = triangle1.Area;
            double p = 0.5 * (side_A + side_B + side_C);
            double result = Math.Sqrt(p * (p - side_A) * (p - side_B) * (p - side_C));

            //Assert
            Assert.Equal(triangle1.Area, result);
        }

        [Theory]
        [InlineData(0.0, 0.0, 0.0)]
        [InlineData(1.0, 1.0, 0.0)]
        [InlineData(1.0, 0.0, 1.0)]
        [InlineData(0.0, 1.0, 1.0)]
        public void Triangle_WithZeroData(double side_A, double side_B, double side_C)
        {
            //Arrange         
            //Act           
            //Assert
            Assert.Throws<ArgumentException>(() => {var triangle2 = (new Triangle(side_A, side_B, side_C)).Area; });
        }

        [Theory]
        [InlineData(-1.0, -1.0, -1.0)]
        [InlineData(1.0, 1.0, -1.0)]
        [InlineData(1.0, -1.0, 1.0)]
        [InlineData(-1.0, 1.0, 1.0)]
        public void Triangle_WithNegativeData(double side_A, double side_B, double side_C)
        {
            //Arrange         
            //Act           
            //Assert
            Assert.Throws<ArgumentException>(() => { var triangle3 = (new Triangle(side_A, side_B, side_C)).Area; });
        }

        [Theory]
        [InlineData(double.MaxValue, double.MaxValue, double.MaxValue)]
        [InlineData(double.MaxValue/3, double.MaxValue/3, double.MaxValue/3)]
        public void Triangle_WithOutOfRangeData(double side_A, double side_B, double side_C)
        {
            //Arrange         
            //Act           
            //Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => { var triangle4 = (new Triangle(side_A, side_B, side_C)).Area; });
        }


        [Theory]
        [InlineData(double.MaxValue, double.MaxValue, double.MaxValue)]
        [InlineData(1.0E+300, 1.0E+300, 1.0E+300)]
        public void Triangle_WithOutIncorrectData(double side_A, double side_B, double side_C)
        {
            //Arrange         
            //Act           
            //Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => { var triangle5 = (new Triangle(side_A, side_B, side_C)).Area; });
        }

        
    }
}

