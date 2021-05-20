namespace oop_6_cs
{
    class Digits : Strings
    {
        private char[] digitline;
        public Digits(char[] line)
        {
            digitline = line;
        }
        public override char[] GetLine()
        {
            return digitline;
        }
        public override int Length()
        {
            return digitline.Length;
        }
        public override void DeleteSymbol(char symbol = '5')
        {
            int counterSymbols = 0;
            for (int i = 0; i < digitline.Length; i++)
            {
                if (digitline[i] == '5')
                {
                    counterSymbols++;
                }
            }
            char[] result = new char[digitline.Length - counterSymbols];
            int j = 0;
            for (int i = 0; i < digitline.Length; i++)
            {
                if (digitline[i] != '5')
                {
                    result[j] = digitline[i];
                    j++;
                }
            }
            digitline = result;
        }
    }
}
