#include "Letters.h"

Letters::Letters(char* line)
{
    letterline = line;
}
Letters::~Letters(){}

char* Letters::GetLine()
{
    return letterline;
}
int Letters::Length()
{
    int length = 0;
    int i = 0;
    while (letterline[i] != '\0')
    {
        length++;
        i++;
    }
    return length;
}
void Letters::DeleteSymbol(char symbol = 'a')
{
    int counterSymbols = 0;
    for (int i = 0; i < Length(); i++)
    {
        if (letterline[i] == 'a')
        {
            counterSymbols++;
        }
    }
    char* result = new char[Length() - counterSymbols];
    int j = 0;
    for (int i = 0; i < Length(); i++)
    {
        if (letterline[i] != 'a')
        {
            result[j] = letterline[i];
            j++;
        }
    }
    result[j] = '\0';
    delete[] letterline;
    letterline = result;
}
