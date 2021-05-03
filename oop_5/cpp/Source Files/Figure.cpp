#include "Figure.h"

	Figure::Figure(int numberOfPoints, double x_coord[], double y_coord[])
	{
		this->numberOfPoints = numberOfPoints;
		coordinates = new double* [numberOfPoints];
		for (int i = 0; i < numberOfPoints; i++)
		{
			coordinates[i] = new double[2];
			coordinates[i][0] = x_coord[i];
			coordinates[i][1] = y_coord[i];
		}
	}
	Figure::~Figure()
	{
		for (int i = 0; i < numberOfPoints; i++)
		{
			delete[] coordinates[i];
		}
		delete[] coordinates;
	}

	double Figure::SideLength(int point1, int point2)
	{
		point1--;
		point2--;
		return sqrt(pow(coordinates[point1][0] - coordinates[point2][0], 2) +
			pow(coordinates[point1][1] - coordinates[point2][1], 2));
	}
