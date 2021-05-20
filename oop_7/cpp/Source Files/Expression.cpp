#include "Expression.h"

Expression::Expression()
{
	a = 2;
	c = 2;
	d = 2;
	result = GetResult();
}

Expression::Expression(double a, double c, double d)
{
	if (a == 1 || a == -1)
		throw exception("Помилка. Дiлення на нуль");
	if (d <= 0)
		throw exception("Помилка. Значення пiдлогарифмiчного виразу менше чи дорiвнює нулю");

	this->a = a;
	this->c = c;
	this->d = d;
	result = GetResult();
}

void Expression::Set_a(double a)
{
	if (a == 1 || a == -1)
		throw exception("Помилка. Дiлення на нуль");
	this->a = a;
}

void Expression::Set_c(double c)
{
	this->c = c;
}

void Expression::Set_d(double d)
{
	if (d <= 0)
		throw exception("Помилка. Значення пiдлогарифмiчного виразу менше чи дорiвнює нулю");
	this->d = d;
}

void Expression::Calculate()
{
	result = (2 * c - log(d / 4)) / (a * a - 1);
}

double Expression::GetResult()
{
	Calculate();
	return result;
}
