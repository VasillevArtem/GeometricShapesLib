using System;
namespace GeometricShapesLib
{
    /// <summary>
    /// Абстрактный класс для геометрических фигур, обеспечивающий базовое поведение. 
    /// </summary>
    
    public abstract class Shape
    {
        /// <summary>
        /// Виртуальный метод, возвращающий название типа фигуры.
        /// </summary>
        /// <returns>Тип фигуры.</returns>
        public virtual string GetShapeName() => GetType().Name;

        /// <summary>
        /// Свойство, возвращающее площадь фигуры
        /// </summary>
        public double Area { get => AreaFigure(); }

        /// <summary>
        /// Абстрактный метод, для проверки входных даннх
        /// </summary>
        protected abstract void ValidInputData();

        /// <summary>
        /// Абстракный метод, для расчета площади фигуры.
        /// </summary>
        /// <returns> Площадь фигуры </returns>
        public abstract double AreaFigure();
        
    }
}
