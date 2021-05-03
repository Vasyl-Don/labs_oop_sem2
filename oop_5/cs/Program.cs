using System;

namespace oop_5_cs
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] x = { 0, 0, 3 };
            double[] y = { 4, 0, 0 };

            Figure.Triangle triangle = new Figure.Triangle(x, y);

            for(int i = 0; i < 3; i++)
                Console.WriteLine($"Точка {i + 1} ({triangle.Coordinates()[i,0]} , {triangle.Coordinates()[i, 1]})");
            Console.WriteLine("Довжина сторони 1: " + triangle.SideLength(1, 2));
            Console.WriteLine("Довжина сторони 2: " + triangle.SideLength(2, 3));
            Console.WriteLine("Довжина сторони 3: " + triangle.SideLength(3, 1));
            Console.WriteLine("Периметр трикутника: " + triangle.Perimeter());
            Console.WriteLine("Площа трикутника: " + triangle.Area());
        }
    }
}
