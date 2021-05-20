#include "Main.h"

int main()
{
	setlocale(LC_ALL, "");

    Expression expressions[2];
    try
    {
        expressions[0] = Expression();
        expressions[1] = Expression(3, 3, 3);
        //expressions[2] = Expression(1, 1, 1);   // Ділення на нуль
        //expressions[3] = Expression(0, 1, -1);  // Значення під логарифмом <= 0
        //expressions[4] = Expression(1, 0, -1);  // Обидві помилки
        for (int i = 0; i < (sizeof(expressions) / sizeof(expressions[0])); i++)
            cout << "Значення виразу " << i + 1 << ": " << expressions[i].GetResult() << endl;
    }
    catch (exception exception)
    {
        cout << exception.what() << endl;
        cout << "Змiнiть вхiднi данi" << endl;
    }

    try
    {
        expressions[0].Set_a(0);
        expressions[1].Set_d(12);
        for (int i = 0; i < (sizeof(expressions) / sizeof(expressions[0])); i++)
            cout << "Значення виразу " << i + 1 << ": " << expressions[i].GetResult() << endl;
    }
    catch (exception exception)
    {
        cout << exception.what() << endl;
        cout << "Змiнiть вхiднi данi" << endl;
    }

	return 0;
}
