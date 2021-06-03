#include <iostream>

int IndexOfFirstSymbol(char*, char);
int ArrayLength(char*);

using namespace std;
int main()
{
	char* symbols = new char[] {'A', 'B', 'O', 'B', 'A'};

	int(*Ptr)(char*, char) = IndexOfFirstSymbol;
	cout << "Index of first symbol 'B' in stack: " << (*Ptr)(symbols, 'B');
	
	return 0;
}
int ArrayLength(char* array)
{
	int length = 0;
	int i = 0;
	while (array[i])
	{
		length++;
		i++;
	}
	return length;
}
int IndexOfFirstSymbol(char* array, char symbol)
{
	int index = 0;
	for (index = 0; index < ArrayLength(array); index++)
	{
		if (array[index] == symbol)
			return index + 1;
	}
	throw exception("No such element in stack");
}