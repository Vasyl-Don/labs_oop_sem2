#pragma once
#include "Figure.h"
class Triangle :
    public Figure
{
public:
    Triangle(double x[], double y[]);
    ~Triangle();

    double Area();
    double Perimeter();
    double** Coordinates();
};
