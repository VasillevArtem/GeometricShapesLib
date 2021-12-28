using System;
namespace GeometricShapesLib
{   /// <summary>
    /// Класс описывающий треугольник.
    /// </summary>
    public class Triangle : Shape
    {
        /// <summary>
        /// Свойства, для хранения значений сторон треугольника.
        /// </summary>
        public double Side_A { get; }
        public double Side_B { get; }
        public double Side_C { get; }

        

        /// <summary>
        /// Конструктор экземпляра треугольника.
        /// </summary>
        /// <param name="side_A">Сторона А.</param>
        /// <param name="side_B">Сторона В.</param>
        /// <param name="side_C">Сторона С.</param>
        public Triangle(double side_A, double side_B, double side_C)
        {
            Side_A = side_A;
            Side_B = side_B;
            Side_C = side_C;
            ValidInputData();
        }

        /// <summary>
        /// Метод, который проверяет входные данные на их соответсвие.
        /// </summary>
        /// <exception cref="ArgumentException">Нулевое либо отрицательно значение данных. Несоответсвие данных признаку треугольника: Сумма двух любых сторон 
        /// треугольнка должна быть больше его третей стороны.</exception>
        protected override void ValidInputData()
        {
            if (Side_A <= 0 || Side_B <= 0 || Side_C <= 0)
                throw new ArgumentException("Triangle cannot have a negative or zero side");

            else if (Side_A + Side_B <= Side_C || Side_A + Side_C <= Side_B || Side_B + Side_C <= Side_A)
                throw new ArgumentException("It is impossible to build a triangle based on these values");

        }

        /// <summary>
        /// Представляет данную фигуру в формате строки.
        /// </summary>
        /// <returns> Площадь и длинны сторон в формате строки.</returns>
        public override string ToString()
        {
            return $"Triangle with sides: A = {this.Side_A}, B = {this.Side_B}, C = {this.Side_C} and area: {this.Area}.";
        }
        

        /// <summary>
        /// Метод, который возвращает значение площади треугольника.
        /// </summary>
        /// <returns>Площадь треугольника</returns>
        /// <exception cref="ArgumentOutOfRangeException"> Значение площади треугольника выходит за границу максимального значения типа double.</exception>
        public override double AreaFigure()
        {

            double p = 0.5 * (Side_A + Side_B + Side_C);
            double result = Math.Sqrt(p * (p - Side_A) * (p - Side_B) * (p - Side_C));
            if (result > double.MaxValue)
                throw new ArgumentOutOfRangeException("Result is greater than the maximum allowed value of the double type");
            return result;

        }


    }
}
