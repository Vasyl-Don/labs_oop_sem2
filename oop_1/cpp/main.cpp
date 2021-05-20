#include "source.h"

int main()
{
	int a, b;	//a, b - числа, над якими будуть проводитися операції
	bool c;		//c - результат порівняння
	cout << "Vasyl Don, IS-01" << endl;
	cout << "Input the first number: ";
	cin >> a;
	cout << "Input the second number: ";
	cin >> b;
	isless(a, b, c);
	cout << a << " < " << b << " = " << c << endl;
	cout << a << " + " << b << " = " << sum(a, b);
}
