#include <iostream>
#include "Line.cpp"
using namespace std;

int main()
{
	char *line_1 = new char[] { 'I', ' ', 'l', 'o', 'v', 'e', ' ', 'C', '#', '\0'};

	Line S1 = Line();
	Line S2 = Line(line_1);
	Line S3 = Line(S1);

	cout << "S1 = " << S1.GetLine() << endl;
	cout << "S2 = " << S2.GetLine() << endl;
	cout << "S3 = " << S3.GetLine() << endl;

	S2 = S2 - '#';
	cout << "\nS2 - '#' = " << S2.GetLine() << endl;

	S1 = S2 + S3;
	cout << "\nS2 + S3 = " << S1.GetLine() << endl;

	return 0;
}
