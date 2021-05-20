using System;

namespace oop_6_cs
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] digits1 = { '1', '5', '0', '5', '3' };
            char[] letters1 = { 'a', 'v', 'e', ' ', 'M', 'a', 'r', 'i', 'a' };
            Strings strings = new Strings();
            Digits digits = new Digits(digits1);
            Letters letters = new Letters(letters1);

            Console.WriteLine("'strings' length = " + strings.Length());
            Console.WriteLine("'digits' length = " + digits.Length());
            Console.WriteLine("'letters' length = " + letters.Length());

            strings.DeleteSymbol('r');
            Console.WriteLine("Edited 'strings': ");
            Console.WriteLine(strings.GetLine());

            digits.DeleteSymbol();
            Console.WriteLine("Edited 'digits': ");
            Console.WriteLine(digits.GetLine());

            letters.DeleteSymbol();
            Console.WriteLine("Edited 'letters': ");
            Console.WriteLine(letters.GetLine());
        }
    }
}
