using GeometricShapesLib;
using Xunit;

namespace GeometricShapesLibTests
{
    public  class TypeShapeTest
    {
        [Fact]
        public void TypeShape_RightTriangle()
        {
            //Arrange
            Triangle triangle1 = new Triangle(3, 4, 5);

            //Act
            string type1 = TypeShape.GetTypeTriangle(triangle1);

            //Assert
            Assert.True(type1.Equals("The right triangle"));
        }

        [Fact]
        public void TypeShape_EquilateralTriangle()
        {
            //Arrange
            Triangle triangle2 = new Triangle(1, 1, 1);

            //Act
            string type2 = TypeShape.GetTypeTriangle(triangle2);

            //Assert
            Assert.True(type2.Equals("The equilateral triangle"));
        }

        [Fact]
        public void TypeShape_IsoscelesTriangle()
        {
            //Arrange
            Triangle triangle3 = new Triangle(3, 3, 5);

            //Act
            string type3 = TypeShape.GetTypeTriangle(triangle3);

            //Assert
            Assert.True(type3.Equals("The isosceles triangle"));
        }

        [Fact]
        public void TypeShape_VersatileTriangle()
        {
            //Arrange
            Triangle triangle4 = new Triangle(3, 5, 6);

            //Act
            string type4 = TypeShape.GetTypeTriangle(triangle4);

            //Assert
            Assert.True(type4.Equals("The versatile triangle"));
        }
    }
}
