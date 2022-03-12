using System;
using Xunit;
using GeometricShapesLib;

namespace GeometricShapesLibTests
{
    public class RectangleTests
    {
        [Theory]
        [InlineData(0.001, 0.001)]
        [InlineData(1.0, 1.0)]
        [InlineData(4.0, 5.0)]
        [InlineData(44.0, 76.0)]
        [InlineData(99.99, 99.99)]
        public void Rectangle_WithNormalData(double side_A, double side_B)
        {
            //Arrange
            var rectangle1 = new Rectangle(side_A, side_B);
            
            //Act           
            double result = side_A * side_B;

            //Assert
            Assert.Equal(rectangle1.Area, result);
        }

        [Theory]
        [InlineData(0.0, 0.0)]
        [InlineData(1.0, 0.0)]
        [InlineData(0.0, 1.0)]
        public void Rectangle_WithZeroData(double side_A, double side_B)
        {
            //Arrange         
            //Act           
            //Assert
            Assert.Throws<ArgumentException>(() => { var rectangle2 = (new Rectangle(side_A, side_B)).Area; });
        }

        [Theory]
        [InlineData(-1.0, -1.0)]
        [InlineData(1.0, -1.0)]
        [InlineData(-1.0, 1.0)]
        public void Rectangle_WithNegativeData(double side_A, double side_B)
        {
            //Arrange         
            //Act           
            //Assert
            Assert.Throws<ArgumentException>(() => { var rectangle3 = (new Rectangle(side_A, side_B)).Area; });
        }

        [Theory]
        [InlineData(double.MaxValue, double.MaxValue)]
        [InlineData(double.MaxValue / 2, double.MaxValue / 2)]
        public void Rectangle_WithOutOfRangeData(double side_A, double side_B)
        {
            //Arrange         
            //Act           
            //Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => { var rectangle4 = (new Rectangle(side_A, side_B)).Area; });
        }


        [Theory]
        [InlineData(double.MaxValue, double.MaxValue)]
        [InlineData(1.0E+300, 1.0E+300)]
        public void Rectangle_WithOutIncorrectData(double side_A, double side_B)
        {
            //Arrange         
            //Act           
            //Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => { var rectangle5 = (new Rectangle(side_A, side_B)).Area; });
        }


    }
}

