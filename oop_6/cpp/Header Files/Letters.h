#pragma once
#include "Strings.h"
class Letters :
    public Strings
{
private:
	char* letterline;
public:
	Letters(char* line);
	~Letters();
	char* GetLine() override;
	int Length() override;
	void DeleteSymbol(char symbol) override;
};
