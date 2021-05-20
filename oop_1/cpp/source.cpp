#include "source.h"

int length(int a)	//визначення довжини числа у двійковій формі
{
	int len = 0;
	while (a > 0)
	{
		a /= 2;
		len++;
	}
	return len;
}

void isless(int a, int b, bool& is_a_less)	//операція порівняння <
{
	is_a_less = false;
	for (int i = length(abs(max(a, b))) - 1; i >= 0; i--)
	{
		if ((a & (1 << i)) != (b & (1 << i)))
		{
			if (b & (1 << i))
			{
				is_a_less = true;
			}
		}
	}
}

int sum(int a, int b)	//операція додавання +
{
	int sum;
	while (b != 0)
	{
		sum = a & b;
		a = a ^ b;
		b = sum << 1;
	}
	return a;
}
