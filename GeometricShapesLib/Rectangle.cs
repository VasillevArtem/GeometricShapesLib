using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricShapesLib
{   /// <summary>
    /// Класс, описывающий прямоугольник.
    /// </summary>
    internal class Rectangle : Shape, IComparable<Rectangle>
    {
        public double Side_A { get; }
        public double Side_B { get; }

        /// <summary>
        /// Конструктор экземпляра прямоугольника, где стороны имееют разную велечину.
        /// </summary>
        /// <param name="side_A">Сторона A.</param>
        /// <param name="side_B">Сторона В.</param>
        public Rectangle(double side_A, double side_B)
        {
            Side_A = side_A;
            Side_B = side_B;

            ValidInputData();
        }
        /// <summary>
        /// Конструктор экземпляра прямоугольника, где стороны имееют одинаковую велечину.
        /// </summary>
        /// <param name="side">Сторона прямоугольника</param>
        public Rectangle(double side)
        {
            Side_A = side;
            Side_B = side;

            ValidInputData();
        }
        /// <summary>
        /// Метод, который возвращает значение площади прямоугольника.
        /// </summary>
        /// <returns>Площадь прямоугольника</returns>
        /// <exception cref="ArgumentOutOfRangeException"> Значение площади прямоугольника выходит за границу максимального значения типа double.</exception>
        public override double AreaFigure()
        {
            double area = Side_A * Side_B ;
            if (area > double.MaxValue)
            {
                throw new ArgumentOutOfRangeException("Result is greater than the maximum allowed value of the double type");
            }
            return area;
        }
        /// <summary>
        /// Метод, который проверяет входные данные на их соответсвие.
        /// </summary>
        /// <exception cref="ArgumentException">Нулевое либо отрицательно значение данных. Несоответсвие данных признаку треугольника: Сумма двух любых сторон 
        /// треугольнка должна быть больше его третей стороны.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Переполнение типа данных double.</exception>
        protected override void ValidInputData()
        {
            if (Side_A <= 0 || Side_B <= 0)
            {
                throw new ArgumentException("Side can't be negative");
            }
            else if (Side_A > double.MaxValue || Side_B > double.MaxValue)
            {
                throw new ArgumentOutOfRangeException($"Incorrect data. Please enter value between 0 - {double.MaxValue}");
            }
        }

        /// <summary>
        /// Представляет данную фигуру в формате строки.
        /// </summary>
        /// <returns> Площадь и длинны сторон в формате строки.</returns>
        public override string ToString()
        {
            return $"Rectangle with sides: A = {this.Side_A}, B = {this.Side_B} and area: {this.Area}.";
        }

        /// <summary>
        /// Реализация интерфейса IComparable.<T>
        /// </summary>
        /// <param name="other">Объект для сравнения.</param>
        /// <returns></returns>
        public int CompareTo(Rectangle? other)
        {
            if( this.Area > other?.Area)
            {
                return 1;
            }
            else if( this.Area < other?.Area)
            {
                return -1;
            }
            return 0;
        }

       
    }
}
