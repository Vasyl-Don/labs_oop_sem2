namespace oop_6_cs
{
    class Letters : Strings
    {
        private char[] letterline;
        public Letters(char[] line)
        {
            letterline = line;
        }
        public override char[] GetLine()
        {
            return letterline;
        }
        public override int Length()
        {
            return letterline.Length;
        }
        public override void DeleteSymbol(char symbol = 'a')
        {
            int counterSymbols = 0;
            for (int i = 0; i < letterline.Length; i++)
            {
                if (letterline[i] == 'a')
                {
                    counterSymbols++;
                }
            }
            char[] result = new char[letterline.Length - counterSymbols];
            int j = 0;
            for (int i = 0; i < letterline.Length; i++)
            {
                if (letterline[i] != 'a')
                {
                    result[j] = letterline[i];
                    j++;
                }
            }
            letterline = result;
        }
    }
}
