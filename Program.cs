using System;


namespace TriagT
{
    public enum TriangleType
    {
        Equilateral,
        Isosceles,
        Versatile,
        NotExist
    }
    /// <summary>
    /// Bank account demo class.
    /// </summary>
    public class Triangle
    {
        private int t_a;
        private int t_b;
        private int t_c;

        private Triangle() { }

        public Triangle(int a,int b,int c)
        {
            t_a = a;
            t_b = b;
            t_c = c;
        }

       
        public TriangleType TrianglEx(int a,int b,int c)
        {
            if (a + b <= c || a + c <= b || b + c <= a)
                return TriangleType.NotExist;
            else if (a == b && b == c)
                return TriangleType.Equilateral;
            else if (a == b || a == c || b == c)
                return TriangleType.Isosceles;
            else
                return TriangleType.Versatile;
        }

        

        public static void Main()
        {
            Triangle tr = new Triangle(2, 3, 2);
            Console.WriteLine("Создан треугольник");
        }
    }
}