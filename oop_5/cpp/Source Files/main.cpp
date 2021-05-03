#include "main.h"

int main()
{
	setlocale(LC_ALL, "");

	double x[] = { 0,0,3 };
	double y[] = { 4,0,0 };

	Triangle triangle = Triangle(x, y);

	for (int i = 0; i < 3; i++)
		cout << "Точка " << i + 1 << " (" << triangle.Coordinates()[i][0] << " , " << triangle.Coordinates()[i][0] << ")" << endl;
	cout << "Довжина сторони 1: " << triangle.SideLength(1, 2) << endl;
	cout << "Довжина сторони 2: " << triangle.SideLength(2, 3) << endl;
	cout << "Довжина сторони 3: " << triangle.SideLength(3, 1) << endl;
	cout << "Периметр трикутника: " << triangle.Perimeter() << endl;
	cout << "Площа трикутника: " << triangle.Area() << endl;
	return 0;
}
