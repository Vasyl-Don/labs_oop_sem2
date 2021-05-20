namespace oop_6_cs
{
    class Strings
    {
        private char[] line;
        public Strings()
        {
            line = new char[] { 'F', 'r', 'o', 'g', '2', '2', '8' };
        }
        public virtual char[] GetLine()
        {
            return line;
        }
        public virtual int Length()
        {
            return line.Length;
        }
        public virtual void DeleteSymbol(char symbol)
        {
            int counterSymbols = 0;
            for (int i = 0; i < line.Length; i++)
            {
                if (line[i] == symbol)
                {
                    counterSymbols++;
                }
            }
            char[] result = new char[line.Length - counterSymbols];
            int j = 0;
            for (int i = 0; i < line.Length; i++)
            {
                if (line[i] != symbol)
                {
                    result[j] = line[i];
                    j++;
                }
            }
            line = result;
        }
    }
}
