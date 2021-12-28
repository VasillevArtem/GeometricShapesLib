

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
         /// <param name="tri"> Экземпляр треугольника.</param>
         /// <returns>Возвращает строку, описывающую вид треугольника.</returns>
         public static string GetTypeTriangle(Triangle tri)
         {
            
            if (tri.Side_A == tri.Side_B && tri.Side_B == tri.Side_C)
                return "The equilateral triangle";


            else if (tri.Side_A == tri.Side_B || tri.Side_B == tri.Side_C || tri.Side_C == tri.Side_A)
                return "The isosceles triangle";


            else if (Math.Pow(tri.Side_A, 2) + Math.Pow(tri.Side_B, 2) == Math.Pow(tri.Side_C, 2) ||
                 Math.Pow(tri.Side_B, 2) + Math.Pow(tri.Side_C, 2) == Math.Pow(tri.Side_A, 2) ||
                 Math.Pow(tri.Side_C, 2) + Math.Pow(tri.Side_A, 2) == Math.Pow(tri.Side_B, 2))
                return "The right triangle";


            return "The versatile triangle";
         }
    }
    
}
