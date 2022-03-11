using System;
namespace GeometricShapesLib
{
    /// <summary>
    /// Абстрактный класс для геометрических фигур, обеспечивающий базовое поведение. 
    /// </summary>
    
    public abstract class Shape : IComparable<Shape>, ICloneable
    {
        /// <summary>
        /// Виртуальный метод, возвращающий название типа фигуры.
        /// </summary>
        /// <returns>Тип фигуры.</returns>
        public virtual string GetShapeName() => GetType().Name;

        /// <summary>
        /// Свойство, возвращающее площадь фигуры.
        /// </summary>
        public double Area { get => AreaFigure(); }

        /// <summary>
        /// Абстрактный метод, для проверки входных данных
        /// </summary>
        protected abstract void ValidInputData();

        /// <summary>
        /// Абстракный метод, для расчета площади фигуры.
        /// </summary>
        /// <returns> Площадь фигуры </returns>
        public abstract double AreaFigure();

        /// <summary>
        /// Абстрактный метод для реализации интерфейса IComparable<Shape>.
        /// </summary>
        /// <param name="other">Объект текущей фигуры.</param>
        /// <returns>return 0  если объекты равны.
        ///          return 1  если текущий объект больше чем обьект переданный в качестве параметра.
        ///          return -1 если текущий объктт меньше чем объект переданный в качестве параметра.</returns>
        public abstract int CompareTo(Shape? other);

        /// <summary>
        /// Абстрактный метод для реализации интерфейса ICloneable.
        /// </summary>
        /// <returns>Новый объект данной фигуры с текущими параметрами.</returns>
        public abstract object Clone();
    }
}
