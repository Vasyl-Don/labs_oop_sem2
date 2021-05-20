#pragma once
#include "Strings.h"
class Numbers :
    public Strings
{
private:
	char* digitline;
public:
	Numbers(char* line);
	~Numbers();
	char* GetLine() override;
	int Length() override;
	void DeleteSymbol(char symbol) override;
};
