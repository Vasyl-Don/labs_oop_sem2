using System;


namespace oop_1_csh
{
    class Program
    {
        static void Main(string[] args)
        {
            bool c = false;	    //c - результат порівняння
            Console.WriteLine("Vasyl Don, IS-01");
            //a, b - числа, над якими будуть проводитися операції
            Console.Write("Input the first number: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Input the second number: ");
            int b = int.Parse(Console.ReadLine());

            isless(a, b, ref c);
            Console.WriteLine($"{a} < {b} = {c}");
            Console.WriteLine($"{a} + {b} = {sum(a, b)}");
        }
        public static int leng(int a)
        {
            int len = 0;
            while (a > 0)
            {
                a /= 2;
                len++;
            }
            return len;
        }
        public static void isless(int a, int b, ref bool is_a_less)
        {
            is_a_less = false;
            for (int i = leng(Math.Abs(Math.Max(a, b))) - 1; i >= 0; i--)
            {
                if ((a & (1 << i)) != (b & (1 << i)))
                {
                    if (Convert.ToBoolean(b & (1 << i)))
                    {
                        is_a_less = true;
                    }
                }
            }
        }
        public static int sum(int a, int b)
        {
            int sum;
            while(b != 0)
            {
                sum = a & b;
                a = a ^ b;
                b = sum << 1;
            }
            return a;
        }
    }
}
