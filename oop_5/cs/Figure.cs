using System;

namespace oop_5_cs
{
    class Figure
    {
        protected int numberOfPoints;
        protected double[,] coordinates;
        public Figure(int numberOfPoints, double[] x_coord, double[] y_coord)
        {
            this.numberOfPoints = numberOfPoints;
            coordinates = new double[numberOfPoints, 2];
            for(int i = 0; i < numberOfPoints; i++)
            {
                coordinates[i, 0] = x_coord[i];
                coordinates[i, 1] = y_coord[i];
            }
        }

        public double SideLength(int point1, int point2)
        {
            point1--;
            point2--;
            return Math.Sqrt(Math.Pow(coordinates[point1, 0] - coordinates[point2, 0], 2) + 
                Math.Pow(coordinates[point1, 1] - coordinates[point2, 1], 2));
        }

        public class Triangle : Figure
        {
            public Triangle(double[] x, double[] y) : base(3, x, y) { }

            public double Area()
            {
                double a, b, c, p, S;
                a = SideLength(1, 2);
                b = SideLength(2, 3);
                c = SideLength(3, 1);
                p = (a + b + c) / 2;
                S = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                return S;
            }

            public double Perimeter()
            {
                return SideLength(1, 2) + SideLength(2, 3) + SideLength(3, 1);
            }

            public double[,] Coordinates()
            {
                return coordinates;
            }
        }
    }
}
