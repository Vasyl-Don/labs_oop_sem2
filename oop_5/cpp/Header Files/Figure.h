#pragma once
#include <cmath>


class Figure
{
protected:
	int numberOfPoints;
	double** coordinates;
public:
	Figure(int numberOfPoints, double x[], double y[]);
	~Figure();
	double SideLength(int point1, int point2);
};