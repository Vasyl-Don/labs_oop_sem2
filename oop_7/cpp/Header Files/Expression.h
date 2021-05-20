#pragma once
#include <math.h>
#include <iostream>
using namespace std;

class Expression
{
private:
	double a, c, d;
	double result;
	void Calculate();
public:
	Expression();
	Expression(double a, double c, double d);
	void Set_a(double a);
	void Set_c(double c);
	void Set_d(double d);
	double GetResult();
};
