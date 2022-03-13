namespace GeometricShapesLib
{
    /// <summary>
    /// Статический класс для определения вида конкретной фигуры.
    /// </summary>
    public static class TypeShape
    {
        /// <summary>
        /// Статический метод, который определяет вид треугольника: равносторонний, равнобедренный, прямоугольный, разносторонний.
        /// </summary>
        /// <param name = "triangle"> Экземпляр треугольника.</param>
        /// <returns>Возвращает строку, описывающую вид треугольника.</returns>
        public static string GetTypeTriangle(Triangle triangle)
         {
            
            if (triangle.Side_A == triangle.Side_B && triangle.Side_B == triangle.Side_C)
                return "The equilateral triangle";


            else if (triangle.Side_A == triangle.Side_B || triangle.Side_B == triangle.Side_C || triangle.Side_C == triangle.Side_A)
                return "The isosceles triangle";


            else if (Math.Pow(triangle.Side_A, 2) + Math.Pow(triangle.Side_B, 2) == Math.Pow(triangle.Side_C, 2) ||
                     Math.Pow(triangle.Side_B, 2) + Math.Pow(triangle.Side_C, 2) == Math.Pow(triangle.Side_A, 2) ||
                     Math.Pow(triangle.Side_C, 2) + Math.Pow(triangle.Side_A, 2) == Math.Pow(triangle.Side_B, 2))

                return "The right triangle";


            return "The versatile triangle";
         }

        public static string GetTypeRectangle(Rectangle rectangle)
        {

        }

        public static string GetTypeCircle(Circle circle)
        {

        }

        
    }
    
}
