namespace oop_4_cs
{
    class Line
    {
        private char[] line;
        private int length;

        // Конструктор за замовчуванням
        public Line()
        {
            line = new char[] {'Y', 'e', 's', ',', ' ', 'I', ' ', 'a', 'm', ' ',
                'f', 'r', 'o', 'm', ' ', 'I', 'S', '-', '0', '1' };
            length = Length(line);
        }
        // Конструктор з параметрами
        public Line(char[] line)
        {
            this.line = line;
            length = Length(line);
        }
        // Конструктор копіювання
        public Line(Line line)
        {
            this.line = line.line;
            length = line.length;
        }
        // Метод обчислення довжини рядка
        private int Length(char[] line)
        {
            int length = 0;
            foreach(char item in line)
            {
                length++;
            }
            return length;
        }
        // Перевантаження операції додавання
        public static Line operator +(Line left, Line right)
        {
            char[] result = new char[left.length + right.length];
            for(int i = 0; i < left.length; i++)
                result[i] = left.GetLine()[i];
            for(int i = left.length; i < (left.length + right.length); i++)
            {
                result[i] = right.GetLine()[i - left.length];
            }
            return new Line(result);
        }
        // Перевантаження операції віднімання
        public static Line operator -(Line line, char symbol)
        {
            Line result = new Line(line);
            for(int index = 0; index < result.length; index++)
            {
                if(result.GetLine()[index] == symbol)
                {
                    result.DeleteSymbol(index);
                }
            }
            return result;
        }
        // Метод отримання значення рядка
        public char[] GetLine()
        {
            return line;
        }

        public void DeleteSymbol(int index)
        {
            char[] result_line = new char[length - 1];
            for (int i = 0; i < index; i++)
            {
                result_line[i] = line[i];
            }
            for (int i = index + 1; i < length; i++)
            {
                result_line[i - 1] = line[i];
            }
            line = result_line;
            length--;
        }
    }
}
