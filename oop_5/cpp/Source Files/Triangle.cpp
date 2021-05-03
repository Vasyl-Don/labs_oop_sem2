#include "Triangle.h"

Triangle::Triangle(double x[], double y[]):Figure(3,x,y){}
Triangle::~Triangle(){}

double Triangle::Area()
{
    double a, b, c, p, S;
    a = SideLength(1, 2);
    b = SideLength(2, 3);
    c = SideLength(3, 1);
    p = (a + b + c) / 2;
    S = sqrt(p * (p - a) * (p - b) * (p - c));
    return S;
}

double Triangle::Perimeter()
{
    return SideLength(1, 2) + SideLength(2, 3) + SideLength(3, 1);
}

double** Triangle::Coordinates()
{
    return coordinates;
}
