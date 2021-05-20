#pragma once
class Strings
{
private:
	char* line;
public:
	Strings();
	~Strings();
	virtual char* GetLine();
	virtual int Length();
	virtual void DeleteSymbol(char symbol);
};
