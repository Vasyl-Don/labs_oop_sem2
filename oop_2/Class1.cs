//Файл бібліотеки MyLib
using System;

namespace MyLib
{
    public class MyText
    {
        private int _numberOfLines = 0;
        private MyLine[] _text;
        private char[] _consonants = new char[] { 'q', 'w', 'r', 't', 'p', 's', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'z', 'x', 'c', 'v', 'b', 'n', 'm',
            'Q', 'W', 'R', 'T', 'P', 'A', 'S', 'D', 'F', 'G', 'H', 'J', 'K', 'L', 'Z', 'X', 'C', 'V', 'B', 'N', 'M',
            'й', 'ц', 'к', 'н', 'г', 'ш', 'щ', 'з', 'х', 'ф', 'в', 'п', 'р', 'л', 'д', 'ж', 'ч', 'с', 'м', 'т', 'ь', 'б',
            'Й', 'Ц', 'К', 'Н', 'Г', 'Ш', 'Щ', 'З', 'Х', 'Ф', 'В', 'П', 'Р', 'Л', 'Д', 'Ж', 'Ч', 'С', 'М', 'Т', 'Ь', 'Б' };
        public int GetNumberOfLines()
        {
            return _numberOfLines;
        }

        public MyText(MyLine line)
        {
            _text = new MyLine[1];
            _text[0] = line;
            _numberOfLines++;
        }
        public char[][] GetText()
        {
            char[][] text = new char[_numberOfLines][];
            for (int i = 0; i < _numberOfLines; i++)
            {
                char[] temp_line = _text[i].GetLine();
                text[i] = new char[_text[i].Size()];
                for (int j = 0; j < _text[i].Size(); j++)
                {
                    text[i][j] = temp_line[j];
                }
            }
            return text;
        }

        public void AddLine(MyLine line)
        {
            MyLine[] temporary = new MyLine[_numberOfLines + 1];
            for (int i = 0; i < _numberOfLines; i++)
            {
                temporary[i] = _text[i];
            }
            temporary[_numberOfLines] = line;
            _text = temporary;
            _numberOfLines++;
        }

        public void DeleteLine(int line_number)
        {
            if (line_number > _numberOfLines || line_number <= 0)
                Console.WriteLine("В текстi немає рядка з таким номером!");
            else
            {
                line_number--;
                MyLine[] temporary = new MyLine[_numberOfLines - 1];
                for (int i = 0; i < line_number; i++)
                {
                    temporary[i] = _text[i];
                }
                for (int i = line_number + 1; i < _numberOfLines; i++)
                {
                    temporary[i - 1] = _text[i];
                }
                _text = temporary;
                _numberOfLines--;
            }
            
        }

        public void ClearText()
        {
            _text = new MyLine[1];
            _numberOfLines = 0;
        }

        public int GetShortest()
        {
            int shortest = _text[0].Size();
            for (int i = 0; i < _numberOfLines; i++)
            {
                if (_text[i].Size() < shortest)
                {
                    shortest = _text[i].Size();
                }
            }
            return --shortest;
        }

        public double ConsonantsPercent()
        {
            double symbols = 0;
            double consonants = 0;
            for (int i = 0; i < _numberOfLines; i++)
            {
                int j = 0;
                while (_text[i].GetLine()[j] != '\0')
                {
                    foreach (char element in _consonants)
                    {
                        if (_text[i].GetLine()[j] == element)
                        {
                            consonants++;
                        }
                    }
                    j++;
                    symbols++;
                }
            }
            double consonants_percent = (consonants / symbols) * 100;
            return consonants_percent;
        }
        public void ReplaceSpaces()
        {
            for (int i = 0; i < _numberOfLines; i++)
            {
                int j = 0;
                while (_text[i].GetLine()[j] != '\0')
                {
                    while (_text[i].GetLine()[j] == ' ' && _text[i].GetLine()[j + 1] == ' ')
                    {
                        _text[i].DeleteSymbol(j + 1);
                    }
                    j++;
                }
            }
        }
        public void DeleteSpaces()
        {
            for (int i = 0; i < _numberOfLines; i++)
            {
                while (_text[i].GetLine()[0] == ' ')
                {
                    _text[i].DeleteSymbol(0);
                }
                while (_text[i].GetLine()[_text[i].Size() - 1] == ' ')
                {
                    _text[i].DeleteSymbol(_text[i].Size());
                }
            }
        }
    }
    public class MyLine
    {
        private char[] _line;
        private int _size;
        public int Lengt(char[] arr)
        {
            int len = 0;
            while (arr[len] != '\0')
            {
                len++;
            }
            return len;
        }
        public MyLine(char[] line)
        {
            int len = Lengt(line);
            _line = new char[len + 1];
            for (int i = 0; i < len; i++)
            {
                _line[i] = line[i];
            }
            _line[len] = '\0';
            _size = _line.Length;
        }
        public void DeleteSymbol(int index)
        {
            char[] line = new char[_size - 1];
            for (int i = 0; i < index; i++)
            {
                line[i] = _line[i];
            }
            for (int i = index + 1; i < _size; i++)
            {
                line[i - 1] = _line[i];
            }
            _line = line;
            _size--;
        }
        public char[] GetLine()
        {
            return _line;
        }
        public int Size()
        {
            return _size;
        }
    }
}
