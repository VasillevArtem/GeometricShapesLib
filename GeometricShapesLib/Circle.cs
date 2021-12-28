using System;
namespace GeometricShapesLib
{
    /// <summary>
    /// Класс, описывающий круг.
    /// </summary>
    public class Circle : Shape
    {
        /// <summary>
        /// Радиус круга.
        /// </summary>
        public double Radius { get; }

        /// <summary>
        /// Конструктор экземпляра круга.
        /// </summary>
        /// <param name="radius" >Радиус круга.</param>
        public Circle(double radius)
        {
            Radius = radius;
            ValidInputData();
        }

        /// <summary>
        ///  Метод, выполняет проверку входных данных на их соответсвие.
        /// </summary>
        /// <exception cref="ArgumentException"> Радиус круга не может быть отрицательным значением.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Переполнение типа данных double.</exception>
        protected override void ValidInputData()
        {
            if (Radius < 0)
                throw new ArgumentException("Radius can't be negative");
            else if (Radius > double.MaxValue)
                throw new ArgumentOutOfRangeException($"Incorrect data. Please enter value between 0 - {double.MaxValue}");
        }

        /// <summary>
        /// Представляет данную фигуру в формате строки.
        /// </summary>
        /// <returns> Площадь и радиус в формате строки.</returns>
        public override string ToString()
        {
            return $"Сircle with radius: {this.Radius} and area: {this.Area}. ";
        }

        /// <summary>
        ///  Метод, который площадь круга.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException">Значение площади круга выходит за границу максимального значения типа double.</exception>
        public override double AreaFigure()
        {
            double result = Math.PI * Radius * Radius;//Math.Pow() - милионные доли не совпадают.
            if (result > double.MaxValue)
                throw new ArgumentOutOfRangeException("Result is greater than the maximum allowed value of the double type");
            return result;

        }


    }
}
