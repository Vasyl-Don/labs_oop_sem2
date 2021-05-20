#include "Numbers.h"

Numbers::Numbers(char* line)
{
	digitline = line;
}
Numbers::~Numbers(){}

char* Numbers::GetLine()
{
	return digitline;
}
int Numbers::Length()
{
    int length = 0;
    int i = 0;
    while (digitline[i] != '\0')
    {
        length++;
        i++;
    }
    return length;
}
void Numbers::DeleteSymbol(char symbol = '5')
{
    int counterSymbols = 0;
    for (int i = 0; i < Length(); i++)
    {
        if (digitline[i] == '5')
        {
            counterSymbols++;
        }
    }
    char* result = new char[Length() - counterSymbols];
    int j = 0;
    for (int i = 0; i < Length(); i++)
    {
        if (digitline[i] != '5')
        {
            result[j] = digitline[i];
            j++;
        }
    }
    result[j] = '\0';
    delete[] digitline;
    digitline = result;
}
