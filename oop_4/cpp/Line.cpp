class Line
{
private:
	char *line;
	int length;

public:
	// Конструктор за замовчуванням
	Line()
	{
		line = new char[] {'Y', 'e', 's', ',', ' ', 'I', ' ', 'a', 'm', ' ',
			'f', 'r', 'o', 'm', ' ', 'I', 'S', '-', '0', '1', '\0' };
		length = Length();
	}
	// Конструктор з параметрами
	Line(char *line)
	{
		this->line = line;
		length = Length();
	}
	// Конструктор копіювання
	Line(const Line &obj)
	{
		line = obj.line;
		length = obj.length;
	}
	// Деструктор
	~Line(){}
	// Метод обчислення довжини рядка
	int Length()
	{
		int i = 0, length = 0;
		while (line[i])
		{
			i++;
			length++;
		}
		return length;
	}
	// Метод отримання значення рядка
	char* GetLine()
	{
		return line;
	}
	// Перевантаження операції додавання
	Line operator +(Line right)
	{
		char* result = new char[this->Length() + right.Length()];
		for (int i = 0; i < this->Length(); i++)
			result[i] = this->GetLine()[i];
		for (int i = this->Length(); i < (this->Length() + right.length); i++)
		{
			result[i] = right.GetLine()[i - this->Length()];
		}
		result[this->Length() + right.Length()] = '\0';
		return Line(result);
	}
	// Перевантаження операції віднімання
	Line operator -(char symbol)
	{
		Line result = Line(line);
		for (int index = 0; index < result.Length(); index++)
		{
			if (result.GetLine()[index] == symbol)
			{
				result.DeleteSymbol(index);
			}
		}
		return result;
	}

private:
	void DeleteSymbol(int index)
	{
		char* result_line = new char[length - 1];
		for (int i = 0; i < index; i++)
		{
			result_line[i] = line[i];
		}
		for (int i = index + 1; i < length; i++)
		{
			result_line[i - 1] = line[i];
		}
		result_line[length - 1] = '\0';
		line = result_line;
		length--;
	}
};
