#include "Strings.h"

Strings::Strings()
{
	line = new char[] { 'F', 'r', 'o', 'g', '2', '2', '8' , '\0'};
}
Strings::~Strings(){}

char* Strings::GetLine()
{
	return line;
}
int Strings::Length()
{
    int length = 0;
    int i = 0;
    while (line[i] != '\0')
    {
        length++;
        i++;
    }
    return length;
}
void Strings::DeleteSymbol(char symbol)
{
    int counterSymbols = 0;
    for (int i = 0; i < Length(); i++)
    {
        if (line[i] == symbol)
        {
            counterSymbols++;
        }
    }
    char* result = new char[Length() - counterSymbols];
    int j = 0;
    for (int i = 0; i < Length(); i++)
    {
        if (line[i] != symbol)
        {
            result[j] = line[i];
            j++;
        }
    }
    result[j] = '\0';
    delete[] line;
    line = result;
}
