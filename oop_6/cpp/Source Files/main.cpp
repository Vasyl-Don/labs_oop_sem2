#include "main.h"

int main()
{
	char* digits1 = new char[] { '1', '5', '0', '5', '3', '\0'};
	char* letters1 = new char[] { 'a', 'v', 'e', ' ', 'M', 'a', 'r', 'i', 'a', '\0' };
	Strings strings = Strings();
	Numbers digits = Numbers(digits1);
	Letters letters = Letters(letters1);

	cout << "'strings' length = " << strings.Length() << endl;
	cout << "'digits' length = " << digits.Length() << endl;
	cout << "'letters' length = " << letters.Length() << endl;

	strings.DeleteSymbol('r');
	cout << "Edited 'strings': " << strings.GetLine() << endl;
	digits.DeleteSymbol('5');
	cout << "Edited 'digits': " << digits.GetLine() << endl;
	letters.DeleteSymbol('a');
	cout << "Edited 'letters': " << letters.GetLine() << endl;

	return 0;
}
